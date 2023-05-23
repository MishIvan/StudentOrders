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
        private bool m_close;
        public PersonsForm()
        {
            InitializeComponent();
            m_close = true;
        }

        private async void OnLoad(object sender, EventArgs e)
        {
            Icon = Properties.Resources.person32;
            m_persons = await Program.m_helper.GetPersons();
            FilterData();
        }
        private void FilterData()
        {
            string flt = filterTextBox.Text;
            if (string.IsNullOrEmpty(flt) || string.IsNullOrWhiteSpace(flt))
                personsDataGridView.DataSource = m_persons;
            else
                personsDataGridView.DataSource = m_persons.Where(p => p.name.ToLower().Contains(flt.ToLower())).ToList();

        }
        /// <summary>
        /// Добавить запись
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void addButton_Click(object sender, EventArgs e)
        {
            PersonCardForm frm = new PersonCardForm();
            if(frm.ShowDialog() == DialogResult.OK)
            {
                m_persons = await Program.m_helper.GetPersons();
                FilterData();
            }
        }
        /// <summary>
        /// Удалить запись 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void editButton_Click(object sender, EventArgs e)
        {
            var row = personsDataGridView.CurrentRow;
            if(row != null)
            {
                long id = Convert.ToInt64(row.Cells["id"].Value);
                PersonCardForm frm = new PersonCardForm(id);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    m_persons = await Program.m_helper.GetPersons();
                    FilterData();
                }
            }
        }
        /// <summary>
        /// Зарыть запись
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void closeRecButton_Click(object sender, EventArgs e)
        {
            var row = personsDataGridView.CurrentRow;
            if (row != null)
            {
                long id = Convert.ToInt64(row.Cells["id"].Value);
                if (Program.m_helper.ClosePerson(id, m_close) > 0)
                {
                    m_persons = await Program.m_helper.GetPersons();
                    FilterData();
                }
                else
                {
                    Program.DBErrorMessage();
                    DialogResult = DialogResult.Cancel;
                }
            }
        }

        private void OnRowChanged(object sender, EventArgs e)
        {
            var row = personsDataGridView.CurrentRow;
            if(row != null)
            {
                bool cl = Convert.ToBoolean(row.Cells["closed"].Value);
                closeRecButton.Text = !cl ? "Закрыть запись" : "Сделать запись действующей";
                m_close = !cl;
            }
        }
        /// <summary>
        /// Применить фильтр по ФИО
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnApplyFilter(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                FilterData();
        }
    }
}
