using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RealtyAgency
{
    public partial class RealtyForm : Form
    {
        private long m_id;
        private RealtyObject m_realty;
        public RealtyForm(long id = 0)
        {
            InitializeComponent();
            m_id = id;
            m_realty = null;
        }

        private void OnLoad(object sender, EventArgs e)
        {
            Icon = Properties.Resources.home_32;
            if(m_id > 0)
            {
                m_realty = Program.m_helper.GetRealtyObjectById(m_id);
                if(m_realty != null)
                {
                    addressTextBox.Text = m_realty.address;
                    squareMaskedTextBox.Text = string.Format("{0:000.###}",m_realty.full_square).Replace('0', ' ');
                    roomsMaskedTextBox.Text = string.Format("{0:00}",m_realty.room_count).Replace('0', ' '); ;
                    costMaskedTextBox.Text = string.Format("{0:0000.0##}", m_realty.rsumma).Replace('0',' ');
                    mortageCheckBox.Checked = m_realty.mortage;
                    secondaryCheckBox.Checked = m_realty.secondary;
                    repairTextBox.Text = m_realty.repair;
                    double fs = Math.Round(m_realty.rsumma * m_realty.full_square / 1000.0, 2);
                    fullCostLabel.Text = $"Полная стоимость, млн. руб.: {fs}";
                }
            }
        }
        /// <summary>
        /// Нажата ОК
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnOK(object sender, EventArgs e)
        {
            if (m_id < 1)
                m_realty = new RealtyObject();
            m_realty.id = m_id;
            m_realty.address = addressTextBox.Text;
            m_realty.full_square = Convert.ToDouble(squareMaskedTextBox.Text);
            m_realty.room_count = Convert.ToInt32(roomsMaskedTextBox.Text);
            m_realty.rsumma = Convert.ToDouble(costMaskedTextBox.Text);
            m_realty.mortage = mortageCheckBox.Checked;
            m_realty.secondary = secondaryCheckBox.Checked;
            m_realty.repair = repairTextBox.Text;
            long id = m_id < 1 ? Program.m_helper.AddRealtyObject(m_realty) : Program.m_helper.UpdateRealtyObject(m_realty);
            if(id < 1)
            {
                Program.ErrorMessageDB();
                DialogResult = DialogResult.Cancel;
            }
            else
                DialogResult = DialogResult.OK;
        }
        /// <summary>
        /// Изменилась площадь или цена за кв. м - пересчитать общую стоимость
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnSquareChanged(object sender, EventArgs e)
        {
            double full_square = 0.0;
            double rsumma = 0.0;
            try
            {
                full_square = Convert.ToDouble(squareMaskedTextBox.Text);
                rsumma = Convert.ToDouble(costMaskedTextBox.Text);
            }
            catch(Exception)
            {
                return;
            }            
            fullCostLabel.Text = "Полная стоимость, млн. руб.: " + Convert.ToString(Math.Round(rsumma * full_square / 1000.0,3));
        }
    }
}
