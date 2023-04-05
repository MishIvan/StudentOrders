using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CallAccounting
{
    public partial class CallListForm : Form
    {
        private long m_idworker;
        private bool m_filled;
        public CallListForm(long idwrk)
        {
            InitializeComponent();
            Icon = Properties.Resources.callslist32;
            m_idworker = idwrk;
            m_filled = false;
        }

        private async void OnLoad(object sender, EventArgs e)
        {
            string wrkname = Program.m_helper.GetWorkerNameByID(m_idworker);
            Text = $"Журнал звонков ({wrkname})";
            delCallButton.Enabled = !Program.m_helper.IsUserRecordClosed(m_idworker);
            beginDateTimePicker.Value = new DateTime(2000, 1, 1, 0, 0, 0);
            m_filled = true;
            endDateTimePicker.Value = DateTime.Now;
            m_filled = false;
 
        }
        /// <summary>
        /// Изменилась дата
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void OnBeginDateChanged(object sender, EventArgs e)
        {
            if (m_filled) return;
            var lst = await Program.m_helper.GetCallsByWorkerID(m_idworker);
            List<CallsView> lstf = lst.Where(c => c.calldate >= beginDateTimePicker.Value && c.calldate <= endDateTimePicker.Value).ToList();
            callsDataGridView.DataSource = lstf;
        }
        /// <summary>
        /// Удалить звонок
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnDeleteCall(object sender, EventArgs e)
        {
            var row = callsDataGridView.CurrentRow;
            if (row == null) return;
            long idcall = Convert.ToInt64(row.Cells["idcall"].Value);
            if(MessageBox.Show("Вы действительно хотите удалить информацию о вызове? Она будет безвозвратно удалена.", 
                "Внимание!", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if(Program.m_helper.DeleteCall(idcall) < 1)
                {
                    MessageBox.Show($"Ошибка: {Program.m_helper.errorText}");
                }
                else
                {
                    OnBeginDateChanged(sender, e);
                }
            }
        }
    }
}
