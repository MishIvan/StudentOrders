using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DisabilityList
{
    public partial class CodesForm : Form
    {
        int m_type;
        string m_code;
        public string code { get { return m_code; } }
        public CodesForm(int type = 1)
        {
            InitializeComponent();
            m_type = type;
            m_code = string.Empty;
        }

        private async void OnLoad(object sender, EventArgs e)
        {
            Icon = Properties.Resources.list32;
            var lst = await Program.m_helper.GetCodes(m_type);
            if (m_type == 3)
                lst.Insert(0, new Code { code = "00", name ="(Нет родственника)" });
            codes_listBox.DataSource = lst;
        }

        private void ok_button_Click(object sender, EventArgs e)
        {
            int idx = codes_listBox.SelectedIndex;
            if(idx < 0 )
            {
                DialogResult = DialogResult.Cancel;
                return;
            }
            
            Code cd = codes_listBox.SelectedItem as Code;
            if(cd == null )
            {
                DialogResult = DialogResult.Cancel;
                return;
            }
            m_code = cd.code;
            DialogResult = DialogResult.OK;
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
