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

        private List<Nut> m_nutList;
        private List<Washer> m_washerList;
        private List<Bolt> m_boltList;

        public MainForm()
        {
            InitializeComponent();
        }

        private async void OnLoad(object sender, EventArgs e)
        {
            Icon = Properties.Resources.boltnut32;
           
            m_nutList = await Program.m_helper.GetNuts();

            m_washerList = await Program.m_helper.GetWashers();

            m_boltList = await Program.m_helper.GetBolts();

            List<double> lst = await Program.m_helper.GetBoltDiams();
            diamComboBox.DataSource = lst;
            diamComboBox.SelectedIndex = 0;
            

            variantLabel.Visible = false;
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
        /// Рассчитать болтовое сонединение
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void calculateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double[] flangePars = { m_flangeHeight1, m_flangeHeight2, m_flangeWidth, m_flangeLength };
            CalcForm dlg = new CalcForm(flangePars, m_bolt, m_nut , m_washer);
            dlg.ShowDialog();
        }
        
        private void variantButton_Click(object sender, EventArgs e)
        {
            variantButton.Visible = false;
            variantLabel.Visible = true;
        }

        private void calcJunctionButton_Click(object sender, EventArgs e)
        {
            try
            {
                m_flangeHeight1 = Convert.ToDouble(firstFlangeHeightTextBox.Text);

            }   
            catch(Exception)
            {
                MessageBox.Show("Неверное задана высота первого фланца");
            }

            try
            {
                m_flangeHeight2 = Convert.ToDouble(secondFlangeHeightTextBox.Text);

            }
            catch (Exception)
            {
                MessageBox.Show("Неверное задана высота второго фланца");
                return;
            }

            try
            {
                m_flangeLength = Convert.ToDouble(flangeLengthTextBox.Text);

            }
            catch (Exception)
            {
                MessageBox.Show("Неверное задана длина фланца");
                return;
            }
            try
            {
                m_flangeWidth = Convert.ToDouble(flangeWidthtextBox.Text);

            }
            catch (Exception)
            {
                MessageBox.Show("Неверное задана ширина фланца");
                return;
            }
            if (diamComboBox.SelectedIndex < 0) return;
            double d = Convert.ToDouble(diamComboBox.SelectedItem);
            if(m_flangeLength < d + 1.0 && m_flangeWidth < d + 1.0)
            {
                MessageBox.Show("Длина и (или) ширина фланцев не подходят по выбранному болту. Измените длину и (или) ширину фланцев");
                return;
            }
            m_nut = m_nutList.Where(n => n.d == d).FirstOrDefault();
            if(m_nut == null)
            {
                MessageBox.Show("Не найдена подходящая по диаметру гайка в БД");
                return;
            }
            m_washer = m_washerList.Where(w => w.d == d).FirstOrDefault();
            if (m_nut == null)
            {
                MessageBox.Show("Не найдена подходящая по диаметру шайба в БД");
                return;
            }
            m_bolt = m_boltList.OrderBy(b=> b.l).Where(b => b.d == d && b.l > m_flangeHeight1 + m_flangeHeight2 + m_nut.m + m_washer.s + 3.0).FirstOrDefault();
            if(m_bolt == null)
            {
                MessageBox.Show("Не найден болт подходящей длины в БД");
                return;
            }

            // уточнение размеров фланца после выбора болта
            if(m_flangeLength < m_nut.e + 10.0)
            {
                m_flangeLength = m_nut.e + 10.0;
                flangeLengthTextBox.Text = $"{m_flangeLength}";
            }
            if(m_flangeWidth < m_nut.S + 10.0)
            {
                m_flangeWidth = m_nut.S + 10.0;
                flangeWidthtextBox.Text = $"{m_flangeWidth}";
            }
            if(Math.Abs(m_bolt.l - (m_flangeHeight1 + m_flangeHeight2 + m_nut.m + m_washer.s + 3.0)) > 2.0)
            {
                m_flangeHeight1 = (m_bolt.l - (m_nut.m + m_washer.s + 3.0)) * 0.5;
                m_flangeHeight2 = m_flangeHeight1;
                firstFlangeHeightTextBox.Text = $"{m_flangeHeight1}";
                secondFlangeHeightTextBox.Text = $"{m_flangeHeight2}";
            }

            string text = $"{m_bolt.name}\r\n\r\n" +
                $"Длина болта l (мм): {m_bolt.l}\r\n" +
                $"Размер под ключ S (мм):{m_bolt.S}\r\n" +
                $"Диаметр болта d (мм): {m_bolt.d}\r\n" +
                $"Диаметр окружности D (мм): {m_bolt.e}\r\n\r\n" +
                $"{m_nut.name}\r\n" +
                $"Высота гайки m (мм): {m_nut.m}\r\n\r\n" +
                $"{m_washer.name}\r\n" +
                $"Высота шайбы s (мм): {m_washer.s}";
            junctionTextBox.Text = text;
            
        }
    }
}
