using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Appointments
{
    public partial class UsersForm : Form
    {
        bool m_choiceMode; // режим выбора или работы со списком пользователей
        long m_userId;
        public long userId { get {return m_userId;} }
        public UsersForm(bool chice_mode = false)
        {
            InitializeComponent();
            m_choiceMode = chice_mode;
            m_userId = 0;
        }

        private void onLoad(object sender, EventArgs e)
        {
            var lst = Program.m_pgConnection.getUserForGrid();
            usersDataGridView.DataSource = lst;
            // перенастойка кнопок
            if (m_choiceMode) 
            {
                addButton.Text = "Выбор";
                addButton.DialogResult = DialogResult.OK;
                this.AcceptButton = addButton;

                editButton.Text = "Отмена";
                editButton.DialogResult = DialogResult.Cancel;
                this.CancelButton = editButton;

                deleteButton.Visible = false;
            }

        }

        private void onAdded(object sender, EventArgs e)
        {
            if(m_choiceMode)
            {
                var row = usersDataGridView.CurrentRow;
                m_userId = Convert.ToInt64(row.Cells[0].Value);
                Close();
            }
            else 
            {
                UserCardForm ucard = new UserCardForm();
                if(ucard.ShowDialog() == DialogResult.OK)
                    usersDataGridView.DataSource = Program.m_pgConnection.getUserForGrid();
            }
        }

        private void onEdit(object sender, EventArgs e)
        {
            if (m_choiceMode)
                Close();
            else 
            {
                var row = usersDataGridView.CurrentRow;
                m_userId = Convert.ToInt64(row.Cells[0].Value);
                UserCardForm ucard = new UserCardForm(m_userId);
                if (ucard.ShowDialog() == DialogResult.OK)
                    usersDataGridView.DataSource = Program.m_pgConnection.getUserForGrid();
            }
        }

        private void onDelete(object sender, EventArgs e)
        {
            if (!m_choiceMode)
            {
                var row = usersDataGridView.CurrentRow;
                m_userId = Convert.ToInt64(row.Cells[0].Value);
                Program.m_pgConnection.deleteUser(m_userId);
                usersDataGridView.DataSource = Program.m_pgConnection.getUserForGrid();
            }
        }
    }
}
