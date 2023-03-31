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
    /// <summary>
    /// Форма управления справочником телефонов
    /// </summary>
    public partial class PhonesForm : Form
    {
        private List<Phone> m_phoneList;
        private long m_PhoneID;
        private bool m_changed;

        public bool changed { get { return m_changed; } }
        public PhonesForm()
        {
            InitializeComponent();
            m_phoneList = null;
            m_changed = false;
            Icon = Properties.Resources.Phone32;
        }

        private async void OnLoad(object sender, EventArgs e)
        {
            m_phoneList = await Program.m_helper.GetPhonesList();
            numberComboBox.DataSource = m_phoneList;            
        }
        /// <summary>
        /// Нажата кнопка Добавить
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnAddRecord(object sender, EventArgs e)
        {
            string num = numberComboBox.Text;
            Phone ph = m_phoneList.Where(p => p.number == num).FirstOrDefault();
            if(ph != null)
            {
                MessageBox.Show($"Номер {ph.number} уже существует в базе данных");
                return;
            }

            double charge = 0.0;
            try
            {
                charge = Convert.ToDouble(chargeTextBox.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
                return;
            }
            if(Program.m_helper.AddPhone(num, charge) < 1)
            {
                MessageBox.Show($"Ошибка: {Program.m_helper.errorText}");
            }
            else
            {
                OnLoad(sender, e);
            }
        }
        /// <summary>
        /// Нажата кнопка Править
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnEditRecord(object sender, EventArgs e)
        {
            
        }
        /// <summary>
        /// Нжата кнопка удалить
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnDeleteRecord(object sender, EventArgs e)
        {
           

        }
        /// <summary>
        /// Изменился номер телефона
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnNumberChanged(object sender, EventArgs e)
        {
            int idx = numberComboBox.SelectedIndex;
            if(idx >= 0)
            {
                Phone phone = numberComboBox.Items[idx] as Phone;
                if(phone != null)
                {
                    chargeTextBox.Text = phone.charge.ToString();
                    m_PhoneID = phone.id;
                }
            }
        }
    }
}
