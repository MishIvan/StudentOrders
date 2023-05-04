using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdAgency
{
    public partial class JuridicalPersonCardForm : Form
    {
        private long m_id;
        private JuridicalPerson m_person;
        public JuridicalPersonCardForm(long id = 0)
        {
            InitializeComponent();
            m_id = id;
            m_person = null;
        }

        private void OnLoad(object sender, EventArgs e)
        {
            Icon = Properties.Resources.company32;
            if(m_id > 0)
            {
                m_person = Program.m_helper.GetJuridicalPersonByID(m_id);
                if(m_person != null)
                {
                    nameTextBox.Text = m_person.pname;
                    innMaskedTextBox.Text = m_person.inn;
                    kppMaskedTextBox.Text = m_person.kpp;
                    addressTextBox.Text = m_person.address;
                }
            }
        }
        /// <summary>
        /// Внести изменения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void acceptButton_Click(object sender, EventArgs e)
        {
            string inn = innMaskedTextBox.Text;
            string name = nameTextBox.Text;

            if(string.IsNullOrEmpty(name) || string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Необходимо задать наименование юридического лица");
                DialogResult = DialogResult.Cancel;
                return;
            }
            if (string.IsNullOrEmpty(inn) || string.IsNullOrWhiteSpace(inn))
            {
                MessageBox.Show("Необходимо задать ИНН юридического лица");
                DialogResult = DialogResult.Cancel;
                return;
            }

            if (m_id < 1) m_person = new JuridicalPerson();

            m_person.id = m_id;
            m_person.pname = name;
            m_person.inn = inn;
            m_person.kpp = kppMaskedTextBox.Text;
            m_person.address = addressTextBox.Text;

            int res = -1;
            if (m_id < 1)
                res = Program.m_helper.AddJuridicalPerson(m_person);
            else
                res = Program.m_helper.UpdateJuridicalPerson(m_person);

            if(res < 1)
            {
                Program.ErrorMessageDB();
                DialogResult = DialogResult.Cancel;
            }
        }
    }
}
