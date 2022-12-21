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
        }
    }
}
