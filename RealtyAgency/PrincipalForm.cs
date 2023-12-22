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
    public partial class PrincipalForm : Form
    {
        private long m_id;
        private RealtyObject m_realty;

        public PrincipalForm(long id = 0)
        {
            InitializeComponent();
            m_id = id;
            m_realty = null;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void personCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            bool phis = personCheckBox.Checked;

            addressTextBox.Enabled = !phis;
            kppMaskedTextBox.Enabled = !phis;
            ogrnMaskedTextBox.Enabled = !phis;
        }

        private void OnLoad(object sender, EventArgs e)
        {
            Icon = Properties.Resources.person_32;
            bool phis = true;
            if(m_id > 0)
            {
                m_realty = Program.m_helper.GetRealtyObjectById(m_id);
                if (m_realty != null)
                {
                    phis = !string.IsNullOrEmpty(m_realty.kp);
                    addressTextBox.Text = m_realty.address;

                }

            }
            personCheckBox.Checked = phis;

            addressTextBox.Enabled = !phis;
            kppMaskedTextBox.Enabled = !phis;
            ogrnMaskedTextBox.Enabled = !phis;

        }
        /// <summary>
        /// Нажата ОК
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OK_Button_Click(object sender, EventArgs e)
        {

        }
    }
}
