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
    public partial class AscentStatusForm : Form
    {
        private int m_stаstus;
        public int status { get { return m_stаstus; } } 
        public AscentStatusForm(int status)
        {
            InitializeComponent();
            m_stаstus = status;
        }

        private void OnLoad(object sender, EventArgs e)
        {
            Icon = Properties.Resources.mountain32;
            switch(m_stаstus)
            {
                case 1: doneRadioButton.Checked = true; break;
                case 2: plannedRadioButton.Checked = true; break;
                case 3: cancelRadioButton.Checked = true; break;
            }
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            if (doneRadioButton.Checked) m_stаstus = 1;
            if (plannedRadioButton.Checked) m_stаstus = 2;
            if (cancelRadioButton.Checked) m_stаstus = 3;
        }
    }
}
