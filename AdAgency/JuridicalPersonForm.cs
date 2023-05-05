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
    public partial class JuridicalPersonForm : Form
    {
        private List<JuridicalPerson> m_pdata;
        private bool m_choiceMode; // Режим выбора или управления
        private long m_id;
        public long personID {get {return m_id;} }
        public JuridicalPersonForm(bool choiceMode = false)
        {
            InitializeComponent();
            m_pdata = null;
            m_choiceMode = choiceMode;
            m_id = 0;
        }

        private async void OnLoad(object sender, EventArgs e)
        {
            Icon = Properties.Resources.company32;
            if(m_choiceMode)
            {
                addButton.DialogResult = DialogResult.OK;
                addButton.Text = "OK";

                editButton.DialogResult = DialogResult.Cancel;
                editButton.Text = "Отмена";

                AcceptButton = addButton;
                CancelButton = editButton;
            }
            m_pdata = await Program.m_helper.GetPesons();
            jpDataGridView.DataSource = m_pdata;

        }
        /// <summary>
        /// Применить фильтр
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnAppleFilter(object sender, KeyPressEventArgs e)
        {           
            if (e.KeyChar == (char)Keys.Enter)
                ApplyFilter();   
        }
        /// <summary>
        /// Применить фильтр к списку юрлиц
        /// </summary>        
        private void ApplyFilter()
        {
            List<JuridicalPerson> lst = null;
            string filtername, filterinn;

            filtername = nameFiltertextBox.Text.ToUpper();
            filterinn = innFilterTextBox.Text;

            bool isFilterName = !(string.IsNullOrEmpty(filtername) || string.IsNullOrWhiteSpace(filtername));
            bool isFiltereINN = !(string.IsNullOrEmpty(filterinn) || string.IsNullOrWhiteSpace(filterinn));

            if (isFilterName && isFiltereINN)
                lst = m_pdata.Where(p => p.pname.ToUpper().Contains(filtername) && p.inn.Contains(filterinn)).ToList();
            else if (isFilterName && !isFiltereINN)
                lst = m_pdata.Where(p => p.pname.ToUpper().Contains(filtername)).ToList();
            else if (!isFilterName && isFiltereINN)
                lst = m_pdata.Where(p => p.inn.Contains(filterinn)).ToList();
            else
                lst = m_pdata;

            jpDataGridView.DataSource = lst;
        }

        /// <summary>
        /// Добавить контрагента
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void addButton_Click(object sender, EventArgs e)
        {
            if (!m_choiceMode)
            {
                JuridicalPersonCardForm frm = new JuridicalPersonCardForm(0);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    m_pdata = await Program.m_helper.GetPesons();
                    ApplyFilter();

                }
            }
            else 
            {
                var row = jpDataGridView.CurrentRow;
                if(row != null)
                {
                    m_id = Convert.ToInt64(row.Cells[0].Value);
                }
            }
        }
        /// <summary>
        /// Изменить контрагента
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void editButton_Click(object sender, EventArgs e)
        {
            var row = jpDataGridView.CurrentRow;
            if (row == null) return;
            long id = Convert.ToInt64(row.Cells[0].Value);
            JuridicalPersonCardForm frm = new JuridicalPersonCardForm(id);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                m_pdata = await Program.m_helper.GetPesons();                
                ApplyFilter();
            }
        }
    }
}
