using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RealtyAgency
{
    public partial class PrincipalForm : Form
    {
        private long m_id;
        private Principal m_principal;

        public PrincipalForm(long id = 0)
        {
            InitializeComponent();
            m_id = id;
            m_principal = null;
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
            passportTextBox.Enabled = phis;
        }

        private void OnLoad(object sender, EventArgs e)
        {
            Icon = Properties.Resources.person_32;
            bool phis = true;
            if (m_id > 0)
            {
                m_principal = Program.m_helper.GetPrincipalById(m_id);
                if (m_principal != null)
                {
                    phis = string.IsNullOrEmpty(m_principal.kpp) || string.IsNullOrWhiteSpace(m_principal.kpp);
                    emailTextBox.Text = m_principal.email;
                    phoneMaskedTextBox.Text = m_principal.phone;
                    nameTextBox.Text = m_principal.name;
                    innMaskedTextBox.Text = m_principal.inn;
                    personCheckBox.Checked = phis;

                    if (phis)
                    {
                        passportTextBox.Text = m_principal.passport;
                    }
                    else
                    {
                        addressTextBox.Text = m_principal.address;
                        kppMaskedTextBox.Text = m_principal.kpp;
                        ogrnMaskedTextBox.Text = m_principal.ogrn;
                    }

                }
            }
            personCheckBox.Checked = phis;

            addressTextBox.Enabled = !phis;
            kppMaskedTextBox.Enabled = !phis;
            ogrnMaskedTextBox.Enabled = !phis;
            passportTextBox.Enabled = phis;

        }
        /// <summary>
        /// Нажата ОК
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnOK(object sender, EventArgs e)
        {
            bool phis = personCheckBox.Checked;
            if (m_id < 1)
                m_principal = new Principal();
            if(m_principal != null)
            {
                m_principal.id = m_id;
                m_principal.name = nameTextBox.Text;
                m_principal.phone = phoneMaskedTextBox.Text;
                m_principal.email = emailTextBox.Text;
                m_principal.inn = innMaskedTextBox.Text;
                m_principal.passport = phis ? passportTextBox.Text : string.Empty;
                m_principal.address = phis ? string.Empty : addressTextBox.Text;
                m_principal.kpp =  phis ? string.Empty : kppMaskedTextBox.Text;
                m_principal.ogrn = phis ? string.Empty : ogrnMaskedTextBox.Text;
                long id = 0;
                if (m_id > 0)
                    id = Program.m_helper.UpdatePrincipal(m_principal);
                else
                    id = Program.m_helper.AddPrincipal(m_principal);
                if(id < 1)
                {
                    Program.ErrorMessageDB();
                    DialogResult = DialogResult.Cancel;
                }
                else
                    DialogResult = DialogResult.OK;

            }
        }
    }
}
