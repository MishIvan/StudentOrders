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
    public partial class UserCardForm : Form
    {
        long m_userId;
        List<Role> m_roleList;
        public UserCardForm(long userId = 0)
        {
            InitializeComponent();
            m_userId = userId;
        }

        private void onLoad(object sender, EventArgs e)
        {
            m_roleList = Program.m_pgConnection.getRoles();
            roleComboBox.DataSource = m_roleList.Select(u => u.name).ToList();
            if (m_userId > 0)
            {
                User usr = Program.m_pgConnection.getUserById(m_userId);
                int idx = 0;
                if (usr != null) // правка карточки пользователя
                {
                    nameTextBox.Text = usr.name;
                    passTextBox.Text = usr.password;
                    idx = roleComboBox.Items.IndexOf(usr.rolename);
                    if (idx >= 0)
                        roleComboBox.SelectedIndex = idx;
                    closedCheckBox.Checked = usr.closed;
                }
                else
                {
                    if (roleComboBox.Items.Count > 0)
                        roleComboBox.SelectedIndex = idx;
                    closedCheckBox.Checked = false;
                }
            }
            else
                closedCheckBox.Visible = false;
        }

        private void OnOK(object sender, EventArgs e)
        {
            long rid = m_roleList.Where(u => u.name == roleComboBox.SelectedItem.ToString())
                .Select(u => u.id).FirstOrDefault();

            if (m_userId > 0) // правка
            {
                Program.m_pgConnection.updateUser(m_userId, nameTextBox.Text, rid, passTextBox.Text, closedCheckBox.Checked);
            }
            else // добавление
            {
                Program.m_pgConnection.insertUser(nameTextBox.Text, rid, passTextBox.Text, closedCheckBox.Checked);
            }
            this.Close();
        }

        private void onCancel(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
