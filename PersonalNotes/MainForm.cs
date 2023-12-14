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
            addressTabPage.TabIndex = 0;
            int idx = 0;

            abcTabControl.SelectedIndex = idx;
            m_letter = abcTabControl.TabPages[idx].Text;
            m_address_book = await Program.m_helper.GetAddressData(m_letter);
            addressDataGridView.DataSource = m_address_book;

            var lst = await Program.m_helper.GetNotes();
            notesDataGridView.DataSource = lst;
        }
        /// <summary>
        /// выбрана буква алфавита
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void OnABCSelectedIndexChanged(object sender, EventArgs e)
        {
            if (addressTabPage.TabIndex != 0) return;
            int idx = abcTabControl.SelectedIndex;

            if(idx > -1)
            {
                m_letter = abcTabControl.TabPages[idx].Text;
                m_address_book = await Program.m_helper.GetAddressData(m_letter);
                addressDataGridView.DataSource = m_address_book;

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
        private async void addButton_Click(object sender, EventArgs e)
        {
            int itab = MainTabControl.SelectedIndex;
            if (itab == 0)
            {
                AddressForm form = new AddressForm();
                if (form.ShowDialog() == DialogResult.OK)
                {
                    m_letter = abcTabControl.TabPages[abcTabControl.SelectedIndex].Text;
                    m_address_book = await Program.m_helper.GetAddressData(m_letter);
                    addressDataGridView.DataSource = m_address_book;
                }
            }
            else if(itab==1)
            {
                NoteForm form = new NoteForm();
                if(form.ShowDialog() == DialogResult.OK) 
                {
                    var lst = await Program.m_helper.GetNotes();
                    notesDataGridView.DataSource = lst; 
                }
            }

        }
        /// <summary>
        /// Изменение записи
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void editButton_Click(object sender, EventArgs e)
        {
            int itab = MainTabControl.SelectedIndex;
            if(itab == 0)
            {
                var row = addressDataGridView.CurrentRow;
                if (row == null) return;
                long id = Convert.ToInt64(row.Cells[0].Value);
                AddressForm form = new AddressForm(id);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    m_letter = abcTabControl.TabPages[abcTabControl.SelectedIndex].Text;
                    m_address_book = await Program.m_helper.GetAddressData(m_letter);
                    addressDataGridView.DataSource = m_address_book;

                }

            }
            else if(itab ==1)
            {
                var row = notesDataGridView.CurrentRow;
                if(row == null) return;
                long id = Convert.ToInt64(row.Cells[0].Value);
                NoteForm form = new NoteForm(id);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    var lst = await Program.m_helper.GetNotes();
                    notesDataGridView.DataSource = lst;
                }

            }

        }
        /// <summary>
        /// Удаление записи
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void deleteButton_Click(object sender, EventArgs e)
        {
            int itab = MainTabControl.SelectedIndex;
            if (itab == 0)
            {
                var row = addressDataGridView.CurrentRow;
                if (row == null) return;    
                long id = Convert.ToInt64(row.Cells[0].Value);
                int nrec = Program.m_helper.DeleteAddressRecord(id);   
                if (nrec > 0)
                {
                    m_letter = abcTabControl.TabPages[abcTabControl.SelectedIndex].Text;
                    m_address_book = await Program.m_helper.GetAddressData(m_letter);
                    addressDataGridView.DataSource = m_address_book;

                }

            }
            else if (itab == 1)
            {
                var row = notesDataGridView.CurrentRow;
                if (row == null) return;
                long id = Convert.ToInt64(row.Cells[0].Value);
                int recs = Program.m_helper.DeleteNotesRecord(id);
                if (recs > 0)
                {
                    var lst = await Program.m_helper.GetNotes();
                    notesDataGridView.DataSource = lst;
                }
            }

        }
        /// <summary>
        /// Обработчики контекстного меню
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void add_toolStripMenuItem_Click(object sender, EventArgs e)
        {
            addButton_Click(sender, e);
        }

        private void edit_toolStripMenuItem_Click(object sender, EventArgs e)
        {
            editButton_Click(sender, e);
        }

        private void delete_toolStripMenuItem_Click(object sender, EventArgs e)
        {
            deleteButton_Click(sender, e);
        }
    }
}
