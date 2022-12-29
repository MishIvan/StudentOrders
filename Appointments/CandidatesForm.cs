using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Appointments
{
    public partial class CandidatesForm : Form
    {
        private bool m_choiceMode;
        private long m_id;
        public long candidateId { get { return m_id; } }
        public CandidatesForm(bool chiocemode = false)
        {
            InitializeComponent();
            m_choiceMode = chiocemode;
            m_id = 0;
        }
        /// <summary>
        /// Добавить запись о соискателе
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addButton_Click(object sender, EventArgs e)
        {
            if (m_choiceMode)
            {
                if (candidatesDataGridView.Rows.Count > 0)
                {
                    var row = candidatesDataGridView.CurrentRow;
                    m_id = Convert.ToInt64(row.Cells[0].Value);
                }
                Close();
            }
            else
            {
                CandidateCardForm frm = new CandidateCardForm();
                if (frm.ShowDialog() == DialogResult.OK)
                    candidatesDataGridView.DataSource = Program.m_pgConnection.getCandidates();
            }
        }
        /// <summary>
        /// Изменить параметры записи о кандидате
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void editButton_Click(object sender, EventArgs e)
        {
            if (m_choiceMode)
                Close();
            else 
            {
                if (candidatesDataGridView.Rows.Count > 0)
                {
                    var row = candidatesDataGridView.CurrentRow;
                    m_id = Convert.ToInt64(row.Cells[0].Value);
                    CandidateCardForm frm = new CandidateCardForm(m_id);
                    if (frm.ShowDialog() == DialogResult.OK)
                        candidatesDataGridView.DataSource = Program.m_pgConnection.getCandidates();

                }
            }

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (!m_choiceMode)
            {
                if (candidatesDataGridView.Rows.Count > 0)
                {
                    var row = candidatesDataGridView.CurrentRow;
                    m_id = Convert.ToInt64(row.Cells[0].Value);
                    int recn = Program.m_pgConnection.deleteCandidate(m_id);
                    if (recn > 0)
                    {
                        candidatesDataGridView.DataSource = Program.m_pgConnection.getCandidates();
                        m_id = 0;
                    }
                }                
            }
        }
        /// <summary>
        /// Загрузка резюме
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void resumeButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = Environment.CurrentDirectory;
                openFileDialog.Filter = "Документы Word (*.docx)|*.docx|Документы Word (*.doc)|*.doc|Файлы PDF (*.pdf)|*.pdf|" +
                    "Все файлы (*.*)|*.*";
                openFileDialog.FilterIndex = 0;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    string filePath = openFileDialog.FileName;
                    string ext = string.Empty;
                    if (Path.HasExtension(filePath))
                    {
                        ext = Path.GetExtension(filePath).Substring(1);
                    }
                    byte[] fbytes = File.ReadAllBytes(filePath);
                    if (candidatesDataGridView.Rows.Count > 0)
                    {
                        var row = candidatesDataGridView.CurrentRow;
                        m_id = Convert.ToInt64(row.Cells[0].Value);
                        Program.m_pgConnection.uploadResume(m_id, fbytes, ext);

                    }
                }
            }
        }
        private void onLoad(object sender, EventArgs e)
        {
            var lst = Program.m_pgConnection.getCandidates();
            candidatesDataGridView.DataSource = lst;
            if(m_choiceMode)
            {
                addButton.Text = "Выбрать";
                addButton.DialogResult = DialogResult.OK;
                AcceptButton = addButton;

                editButton.Text = "Отмена";
                editButton.DialogResult = DialogResult.Cancel;
                CancelButton = editButton;

                deleteButton.Visible = false;
                resumeUploadButton.Visible = false;
                resumeShowButton.Visible = false;
                
            }
        }
    }
}
