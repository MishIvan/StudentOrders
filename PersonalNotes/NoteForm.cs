using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalNotes
{
    public partial class NoteForm : Form
    {
        private long m_id;
        private Note m_note;

        public NoteForm(long id = 0)
        {
            InitializeComponent();
            m_id = id;
            m_note = null;
        }

        private void NoteForm_Load(object sender, EventArgs e)
        {
            Icon = Properties.Resources.notes32;
            if (m_id > 0 ) 
            { 
                m_note = Program.m_helper.GetNotesDataRecord(m_id);
                if (m_note != null) 
                {
                    noteDateTimePicker.Value = m_note.note_datetime;
                    notesTextBox.Text = m_note.comments;
                }
            }
        }
        /// <summary>
        /// Нажато ОК
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OK_Button_Click(object sender, EventArgs e)
        {
            if(m_id > 0) 
            { 
                if(m_note != null) 
                { 
                    m_note.id = m_id;
                    m_note.note_datetime = noteDateTimePicker.Value;
                    m_note.comments = notesTextBox.Text;

                    int recs = Program.m_helper.UpdateNotesRecord(m_note);
                    if (recs < 1)
                    {
                        MessageBox.Show(Program.m_helper.errorText, "Ошибка изменения записи");
                        DialogResult = DialogResult.Cancel;
                    }
                    else
                        DialogResult = DialogResult.OK;

                }
            }
            else 
            {
                m_note = new Note()
                {
                    id = 0,
                    note_datetime = noteDateTimePicker.Value,
                    comments = notesTextBox.Text
                };
                int recs = Program.m_helper.AddNoteRecord(m_note);
                if (recs < 1)
                {
                    MessageBox.Show(Program.m_helper.errorText, "Ошибка добавления записи");
                    DialogResult = DialogResult.Cancel;
                }
                else
                    DialogResult = DialogResult.OK;
                
            }
        }
    }
}
