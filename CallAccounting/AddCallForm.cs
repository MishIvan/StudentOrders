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
    public partial class AddCallForm : Form
    {
        private long m_workerID;
        private long m_phoneID;
        public AddCallForm(long idworker, long idphone)
        {
            InitializeComponent();
            Icon = Properties.Resources.Phone32;
            m_workerID = idworker;
            m_phoneID = idphone;
        }

        private void OnLoad(object sender, EventArgs e)
        {
            string worker = Program.m_helper.GetWorkerNameByID(m_workerID);
            string num = Program.m_helper.GetPhoneNumberByID(m_phoneID);
            workerLabel.Text = $"{workerLabel.Text} {worker}";
            phoneLabel.Text = $"{phoneLabel.Text} {num}";
        }
        /// <summary>
        /// Добавить вызов
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnAddCall(object sender, EventArgs e)
        {
            double calltime = 0.0;
            try
            {
                calltime = Convert.ToDouble(callTimeTextBox.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Неправильный формат времени разговора");
                return;
            }
            DateTime dtcall = callDateTimePicker.Value;
            bool inp = outputCheckBox.Checked;
            if(Program.m_helper.AddCall(m_phoneID, dtcall, !inp, calltime) < 1)
            {
                MessageBox.Show($"Ошибка: {Program.m_helper.errorText}");
            }


        }
    }
}
