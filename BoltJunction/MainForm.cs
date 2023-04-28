using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoltJunction
{
    public partial class MainForm : Form
    {
        private double m_flangeHeight1;
        private double m_flangeHeight2;
        private double m_flangeWidth;
        private double m_flangeLength;

        private Bolt m_bolt;
        private Washer m_washer;
        private Nut m_nut;
        public MainForm()
        {
            InitializeComponent();
        }

        private async void OnLoad(object sender, EventArgs e)
        {
            Icon = Properties.Resources.boltnut32;
           
            List<Nut> nlst = await Program.m_helper.GetNuts();
            nutComboBox.DataSource = nlst;

            List<Washer> wlst = await Program.m_helper.GetWashers();
            washerComboBox.DataSource = wlst;

            List<Bolt> blst = await Program.m_helper.GetBolts();
            boltComboBox.DataSource = blst;
            if (boltComboBox.Items.Count > 0)
                boltComboBox.SelectedIndex = 0;
        }

        private void OnClosed(object sender, FormClosedEventArgs e)
        {
            Program.m_helper.Dispose();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// Подборка гайки и шайбы по диаметру болта
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BoltSelectionCahnged(object sender, EventArgs e)
        {
            int idx = boltComboBox.SelectedIndex;
            if (idx < 0) return;
            m_bolt = boltComboBox.Items[idx] as Bolt;
            if (m_bolt == null) return;

            int i = 0;
            int n = nutComboBox.Items.Count;
            for(i = 0; i < n; i++)
            {
                m_nut = nutComboBox.Items[i] as Nut;
                if (m_nut == null) continue;
                if (m_nut.d == m_bolt.d) break;
            }

            if(i < n)
            {
                nutComboBox.SelectedIndex = i;
            }

            n = washerComboBox.Items.Count;
            for (i = 0; i < n; i++)
            {
                m_washer = washerComboBox.Items[i] as Washer;
                if (m_washer == null) continue;
                if (m_washer.d == m_bolt.d) break;
            }

            if (i < n)
            {
                washerComboBox.SelectedIndex = i;
            }
            if (m_nut == null || m_washer == null) return;
            string text = $"Длина болта l (мм): {m_bolt.l + m_bolt.k}\r\n" +
                $"Размер под ключ S (мм):{m_bolt.S}\r\n" +
                $"Диаметр болта d (мм): {m_bolt.d}\r\n" +
                $"Диаметр окружности D (мм): {m_bolt.e}\r\n" +
                $"Высота гайки m (мм): {m_nut.m}\r\n" +
                $"Высота шайбы s (мм): {m_washer.s}";
            junctionTextBox.Text = text;

            m_flangeHeight1 = 0.5 * (m_bolt.l - m_nut.m - m_washer.s - 3.0);
            m_flangeHeight2 = m_flangeHeight1;
            m_flangeLength = m_bolt.e * 2.0;
            m_flangeWidth = m_bolt.S * 2.0;

            firstFlangeHeightTextBox.Text = $"{m_flangeHeight1}";
            secondFlangeHeightTextBox.Text = $"{m_flangeHeight2}";
            flangeLengthTextBox.Text = $"{m_flangeLength}";
            flangeWidthtextBox.Text = $"{m_flangeWidth}";

        }

        /// <summary>
        /// Рассчитать болтовое сонединение
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void calculateToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// ТОлщина фланца изменилась
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void flangeHeightChanged(object sender, EventArgs e)
        {
            double val = 0.0, val1 = 0.0;
            try
            {
                val = Convert.ToDouble(firstFlangeHeightTextBox.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Неверно задано значение толщины первого фланца");
                return;
            }

            try
            {
                val1 = Convert.ToDouble(firstFlangeHeightTextBox.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Неверно задано значение толщины второго фланца");
                return;
            }

            if(val+ val1 > (m_bolt.l - m_nut.m - m_washer.s - 3.0))
            {
                MessageBox.Show("Толщина фланцев не соответствует размерам болтового соединения");
                return;
            }

            m_flangeHeight1 = val; m_flangeHeight2 = val1;
        }
        /// <summary>
        /// Ширина фланца изменилась
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void flangeWidthChanged(object sender, EventArgs e)
        {
            double val = 0.0;
            try
            {
                val = Convert.ToDouble(flangeWidthtextBox.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Неверно задано значение ширины фланца");
                return;
            }
            if(val < m_bolt.S)
            {
                MessageBox.Show("Ширина фланцев не соответствует размерам болтового соединения");
                return;
            }
            m_flangeWidth = val;
        }
        /// <summary>
        ///  Длина фланца изменилась
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void flangeLenghtChanged(object sender, EventArgs e)
        {
            double val = 0.0;
            try
            {
                val = Convert.ToDouble(flangeWidthtextBox.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Неверно задано значение длины фланца");
                return;
            }
            if (val < m_bolt.e)
            {
                MessageBox.Show("Длина фланцев не соответствует размерам болтового соединения");
                return;
            }
            m_flangeLength= val;
        }
    }
}
