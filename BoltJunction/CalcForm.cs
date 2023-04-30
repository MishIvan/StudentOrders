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
    public partial class CalcForm : Form
    {
        private double m_flangeHeight1;
        private double m_flangeHeight2;
        private double m_flangeWidth;
        private double m_flangeLength;

        private Bolt m_bolt;
        private Washer m_washer;
        private Nut m_nut;
        public CalcForm(double [] flangeSize, Bolt bolt, Nut nut, Washer washer)
        {
            InitializeComponent();

            m_flangeHeight1 = flangeSize[0];
            m_flangeHeight2 = flangeSize[1];
            m_flangeWidth = flangeSize[2];
            m_flangeLength = flangeSize[3];

            m_bolt = bolt;
            m_nut = nut;
            m_washer = washer;
        }

        private async void OnLoad(object sender, EventArgs e)
        {
            calcMessageLabel.Text = string.Empty;
            Icon = Properties.Resources.calculate32;
            List<Material> lstm = await Program.m_helper.GetMaterials();
            materialComboBox.DataSource = lstm;

        }
        /// <summary>
        /// Запустить расчёт
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void calculateButton_Click(object sender, EventArgs e)
        {
            calcMessageLabel.Text = "Ждите...";
            double sigm = 0.0, tau = 0.0, sigme = 0.0,  F, Q;
            try
            {
                F = Convert.ToDouble(tensionTextBox.Text);
            }
            catch(Exception)
            {
                MessageBox.Show("Неверно задана нагрука на растяжение");
                return;
            }

            try
            {
                Q = Convert.ToDouble(shearTextBox.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Неверно задана нагрука на растяжение");
                return;
            }
            await Task.Run(() => {
                double dcalc = m_bolt.d - 0.938 * m_bolt.p;
                double pi = Math.PI;
                double S = pi * dcalc * dcalc * 0.25;
                sigm = F / S;
                tau = Q / S;
                sigme = Math.Sqrt(sigm * sigm + 3.0 * tau * tau);
            }
            );

            int idx = materialComboBox.SelectedIndex;
            if(idx >= 0)
            {
                Material mt = materialComboBox.Items[idx] as Material;
                if(mt != null)
                {
                    calcMessageLabel.ForeColor = sigme <= mt.sigmt / 1.2 ?  Color.FromArgb(115, 207, 47) : Color.FromArgb(255, 0, 0);
                    calcMessageLabel.Text = sigme <= mt.sigmt / 1.2 ? "Болтовое соединенине выдерживает заданную нагрузку" 
                        : "Болтовое соединение не выдерживает заданной нагрузки\nЗадайте больший диаметр болта";
                }
            }

        }
        /// <summary>
        /// При нажатии ESC закрыть форму
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnFormKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
                Close();
        }
    }
}
