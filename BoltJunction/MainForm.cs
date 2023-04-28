using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoltJunction
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private async void OnLoad(object sender, EventArgs e)
        {
            Icon = Properties.Resources.boltnut32;
            List<Bolt> blst = await Program.m_helper.GetBolts();
            boltComboBox.DataSource = blst;

            List<Nut> nlst = await Program.m_helper.GetNuts();
            nutComboBox.DataSource = nlst;

            List<Washer> wlst = await Program.m_helper.GetWashers();
            washerComboBox.DataSource = wlst;

        }

        private void OnClosed(object sender, FormClosedEventArgs e)
        {
            Program.m_helper.Dispose();
        }
    }
}
