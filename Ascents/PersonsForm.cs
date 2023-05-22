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
    public partial class PersonsForm : Form
    {
        private List<Person> m_persons;
        public PersonsForm()
        {
            InitializeComponent();
        }

        private async void OnLoad(object sender, EventArgs e)
        {
            Icon = Properties.Resources.person32;
            m_persons = await Program.m_helper.GetPersons();
            personsDataGridView.DataSource = m_persons;
        }
        private void FilterData()
        {
            string flt = filterTextBox.Text;
            if (string.IsNullOrEmpty(flt) || string.IsNullOrWhiteSpace(flt))
                personsDataGridView.DataSource = m_persons;
            else
                personsDataGridView.DataSource = m_persons.Where(p => p.name.ToLower().Contains(flt.ToLower())).ToList();

        }
    }
}
