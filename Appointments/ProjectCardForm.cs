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
    public partial class ProjectCardForm : Form
    {
        private long m_id;
        List<UserBrief> m_chiefs;
        public ProjectCardForm(long id = 0)
        {
            InitializeComponent();
            m_id = id;
        }

        private void onLoad(object sender, EventArgs e)
        {
            m_chiefs = Program.m_pgConnection.getProjectChiefs();
            chiefsComboBox.DataSource = m_chiefs.Select(u => u.name).ToList();
            if(m_id > 0)
            {
                Project prj = Program.m_pgConnection.getProjectById(m_id);
                if (chiefsComboBox.Items.Count > 0)
                {
                    if (prj != null)
                    {
                        int idx = chiefsComboBox.FindStringExact(prj.chiefname);
                        if (idx >= 0) chiefsComboBox.SelectedIndex = idx;
                    }
                }
                nameTextBox.Text = prj.name;
            }
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;
            long chid = 0;
            if (chiefsComboBox.Items.Count > 0)
            {
                var item = chiefsComboBox.SelectedItem;
                if (item != null)
                {
                    string chname = item.ToString();
                    chid = m_chiefs.Where(u => u.name == chname).Select(u => u.id).FirstOrDefault();
                }
            }

            if (!string.IsNullOrEmpty(name) && chid > 1)
            {
                if (m_id > 0)
                    Program.m_pgConnection.updateProject(m_id, name, chid);
                else
                    Program.m_pgConnection.insertProject(name, chid);
            }
            else DialogResult = DialogResult.Cancel;
            Close();
        }

        private void RejectButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
