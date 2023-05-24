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
    public partial class AscentGroupForm : Form
    {
        private long m_idasc;
        public AscentGroupForm(long id)
        {
            InitializeComponent();
            m_idasc = id;
        }

        private async void OnLoad(object sender, EventArgs e)
        {
            Icon = Properties.Resources.person32;
            List<Group> lst = await Program.m_helper.GetAscentGroup(m_idasc);
            groupDataGridView.DataSource = lst;

        }

        private void OnKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
                Close();
        }
    }
}
