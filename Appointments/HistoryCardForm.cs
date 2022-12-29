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
    public partial class HistoryCardForm : Form
    {
        long m_id;
        int m_istr;
        long m_managerid;
        long m_candidateid;
        int m_userRole;
        List<Event> m_eventList;
        public HistoryCardForm(long idv, int istr = 0, long managerid = 0)
        {
            InitializeComponent();
            m_id = idv;
            m_istr = istr;
            m_managerid = managerid;
            m_candidateid = 0;
            m_userRole = 0;
        }

        private void onLoad(object sender, EventArgs e)
        {
            string rolename = Program.m_currentUser.rolename;
            // отображать или нет кнопку выбора менеджера 
            if (rolename == "Администратор")
                m_userRole |= 1;
            else if (rolename == "Руководитель проекта")
                m_userRole |= 4;
            else if (rolename == "Менеджер по подбору персонала")
                m_userRole |= 2;
            m_eventList = Program.m_pgConnection.getEventsList();
            eventsComboBox.DataSource = m_eventList.Select(u => u.name).ToList();

            if (m_istr > 0) // режим правки
            {
                History hst = Program.m_pgConnection.getEvents(m_id).Where(u => u.nstr == m_istr).FirstOrDefault();
                eventDateTimePicker.Value = hst.eventdate;

                m_managerid = hst.managerid;
                managerTextBox.Text = hst.mname;

                int idx = eventsComboBox.FindStringExact(hst.ename);
                if(idx >= 0)
                    eventsComboBox.SelectedIndex = idx;
 
                m_candidateid = hst.candidateid;
                candidateTextBox.Text = hst.cname;
                if ((m_userRole & 1) == 0 || Program.m_currentUser.id == m_managerid)
                    managerChoiceButton.Enabled = false;

            }
        }


        private void OKButton_Click(object sender, EventArgs e)
        {
            string _ename = string.Empty;
            long eid = 0;
            if(eventsComboBox.Items.Count > 0)
            {
                _ename = eventsComboBox.SelectedItem.ToString();
                eid = m_eventList.Where(u => u.name == _ename)
                    .Select(u => u.id).FirstOrDefault();
            }
            History hst = new History
            {
                vacationid = m_id,
                eventdate = eventDateTimePicker.Value,
                ename = _ename,
                eventid = eid,
                managerid = m_managerid,
                mname = managerTextBox.Text,
                candidateid = m_candidateid,
                cname = candidateTextBox.Text,
                nstr = m_istr
            };

            if (m_istr > 0)
            {
                int res = Program.m_pgConnection.updateHistory(hst);
                DialogResult = res > 0 ? DialogResult.OK : DialogResult.Abort;
            }
            else
            {
                int res = Program.m_pgConnection.insertHisory(hst);
                DialogResult = res > 0 ? DialogResult.OK : DialogResult.Abort;               
            }
            Close();
        }

        private void RejectButton_Click(object sender, EventArgs e)
        {
            Close();
        }
        /// <summary>
        /// Выбор менеджера
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void managerChoiceButton_Click(object sender, EventArgs e)
        {
            UsersForm frm = new UsersForm(true);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                User u = Program.m_pgConnection.getUserById(frm.userId);
                if (u != null)
                {
                    managerTextBox.Text = u.name;
                    m_managerid = frm.userId;
                }
            }
        }
        /// <summary>
        /// Выбор соискателя
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void candidateChoiceButton_Click(object sender, EventArgs e)
        {
            CandidatesForm frm = new CandidatesForm(true);
            if(frm.ShowDialog() == DialogResult.OK)
            {
                Candidate cnd = Program.m_pgConnection.getCandidateById(frm.candidateId);
                if (cnd != null)
                {
                    candidateTextBox.Text = cnd.name;
                    m_candidateid = frm.candidateId;
                }
            }
        }
    }
}
