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
        public PersonCardForm(long id)
        {
            InitializeComponent();
            m_id = id;
        }

        private void OnLoad(object sender, EventArgs e)
        {
            Icon = Properties.Resources.person32;
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

        }
    }
}
