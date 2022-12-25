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
    public partial class ProjectsForm : Form
    {
        private bool m_selMode;
        private long m_id;
        public long projectId { get { return m_id; } }
        public ProjectsForm(bool selmode = false)
        {
            InitializeComponent();
            m_selMode = selmode;
            m_id = 0;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (!m_selMode)
            {
                ProjectCardForm frm = new ProjectCardForm();
                if (frm.ShowDialog() == DialogResult.OK)
                    projectsDataGridView.DataSource = Program.m_pgConnection.getProjects();
            }
            else
            {
                var row = projectsDataGridView.CurrentRow;
                m_id = Convert.ToInt64(row.Cells[0].Value);
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            var row = projectsDataGridView.CurrentRow;
            long id = Convert.ToInt64(row.Cells[0].Value);
            if (!m_selMode)
            {
                ProjectCardForm frm = new ProjectCardForm(id);
                if (frm.ShowDialog() == DialogResult.OK)
                    projectsDataGridView.DataSource = Program.m_pgConnection.getProjects();
            }
            else
                Close();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            var row = projectsDataGridView.CurrentRow;
            long id = Convert.ToInt64(row.Cells[0].Value);
            if(Program.m_pgConnection.deleteProject(id) > 0)
                projectsDataGridView.DataSource = Program.m_pgConnection.getProjects();
        }

        private void onLoad(object sender, EventArgs e)
        {
            projectsDataGridView.DataSource = Program.m_pgConnection.getProjects();
            if(m_selMode)
            {
                addButton.Text = "Выбрать";
                addButton.DialogResult = DialogResult.OK;

                editButton.Text = "Отмена";
                editButton.DialogResult = DialogResult.Cancel;

                deleteButton.Visible = false;
            }
        }
    }
}
