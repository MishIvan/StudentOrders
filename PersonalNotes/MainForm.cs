using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalNotes
{
    public partial class MainForm : Form
    {
        private List<AddressBook> m_address_book;
        private string m_letter;

        public MainForm()
        {
            InitializeComponent();
            m_address_book = new List<AddressBook>();
            m_letter = string.Empty;
        }
        /// <summary>
        /// Обработчик загрузки формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void OnLoad(object sender, EventArgs e)
        {
            Icon = Properties.Resources.notes32;
            m_address_book = await Program.m_helper.GetAddressData();   
            addressTabPage.TabIndex = 0;
            abcTabControl.SelectedIndex = 0;
            OnABCSelectedIndexChanged(null, null);

        }
        /// <summary>
        /// выбрана буква алфавита
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnABCSelectedIndexChanged(object sender, EventArgs e)
        {
            int idx = abcTabControl.SelectedIndex;

            if(idx > -1)
            {
                m_letter = abcTabControl.TabPages[idx].Text;
                List<AddressBook> list = m_address_book.Where(r => r.name.Substring(0, 1) == m_letter).OrderBy(r => r.name).ToList();
                addressDataGridView.DataSource = list;

            }
        }
        /// <summary>
        /// Пои закрытии формы нужно отсоединиться от БД
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnClosed(object sender, FormClosedEventArgs e)
        {
            Program.m_helper.Dispose();
        }
        /// <summary>
        ///  Добавить запись
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addButton_Click(object sender, EventArgs e)
        {
            int itab = MainTabControl.SelectedIndex;
            if (itab == 0)
            {
                AddressForm form = new AddressForm();
                if (form.ShowDialog() == DialogResult.OK)
                {
                    OnABCSelectedIndexChanged(sender, e);  
                }
            }
            else if(itab==1)
            {
                var row = addressDataGridView.CurrentRow;
                long id = Convert.ToInt64(row.Cells[0].Value);
                AddressForm form = new AddressForm(id);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    OnABCSelectedIndexChanged(sender, e);
                }

            }

        }
        /// <summary>
        /// Изменение записи
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void editButton_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Удаление записи
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void deleteButton_Click(object sender, EventArgs e)
        {

        }
    }
}
