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
    public partial class CandidateCardForm : Form
    {
        private long m_id;
        public CandidateCardForm(long  id = 0)
        {
            InitializeComponent();
            m_id = id;
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            Candidate cnd = new Candidate
            {
                name = nameTextBox.Text,
                email = emailTextBox.Text,
                phone = phoneTextBox.Text,
                id = m_id
            };
            if (m_id < 1)
                Program.m_pgConnection.insertCandidate(cnd.name, cnd.phone, cnd.email);
            else
                Program.m_pgConnection.updateCandidate(cnd);
            Close();
        }

        private void RejectButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void onLoad(object sender, EventArgs e)
        {
            if(m_id > 0)
            {
                Candidate cnd = Program.m_pgConnection.getCandidateById(m_id);
                if (cnd != null)
                {
                    nameTextBox.Text = cnd.name;
                    phoneTextBox.Text = cnd.phone;
                    emailTextBox.Text = cnd.email;
                }
            }
        }
    }
}
