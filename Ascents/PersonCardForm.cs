using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ascents
{
    public partial class PersonCardForm : Form
    {
        private long m_id;
        public PersonCardForm(long id = 0)
        {
            InitializeComponent();
            m_id = id;
        }

        private void OnLoad(object sender, EventArgs e)
        {
            Icon = Properties.Resources.person32;
            rankComboBox.SelectedIndex = 5;
            if(m_id > 0)
            {
                Person prc = Program.m_helper.GetPersonByID(m_id);
                nameTextBox.Text = prc.name;
                rankComboBox.SelectedIndex = prc.rank - 1;
                birthdateTimePicker.Value = prc.birthdate;
                addInfoTextBox.Text = prc.comments;
            }
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            Person prc = new Person();
            string pname = nameTextBox.Text;
            if (string.IsNullOrEmpty(pname) || string.IsNullOrWhiteSpace(pname))
            {
                MessageBox.Show("Не задани ФИО альпиниста");
                DialogResult = DialogResult.Cancel;
                return;
            }
            prc.name = pname;
            prc.id = m_id > 0 ? m_id : 0;
            prc.birthdate = birthdateTimePicker.Value;
            prc.rank = rankComboBox.SelectedIndex + 1;
            prc.closed = false;
            prc.comments = addInfoTextBox.Text;
            int nrec = m_id < 1 ? Program.m_helper.AddPerson(prc) : Program.m_helper.UpdatePerson(prc);
            if(nrec < 1)
            {
                Program.DBErrorMessage();
                DialogResult = DialogResult.Cancel;
            }
        }
    }
}
