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
    public partial class PhoneChoiceForm : Form
    {
        private List<Phone> m_phoneList;
        private long m_PhoneID;
        private bool m_toLink;
        private DateTime m_dateLink;
        public long PhoneID { get { return m_PhoneID; } }
        public DateTime dateLink { get { return m_dateLink; } }
        public PhoneChoiceForm(bool link = true)
        {
            InitializeComponent();
            m_phoneList = null;
            Icon = Properties.Resources.Phone32;
            m_PhoneID = 0;
            m_toLink = link;
        }

        private async void OnLoad(object sender, EventArgs e)
        {
            
            m_phoneList = await Program.m_helper.GetPhonesList();
            numberComboBox.DataSource = m_phoneList;
            dateLabel.Visible = m_toLink;
            linkDateTimePicker.Visible = m_toLink;
        }
        
        /// <summary>
        /// Нажатие кнопки Выбрать
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnChoiceMade(object sender, EventArgs e)
        {
            int idx = numberComboBox.SelectedIndex;
            if (idx >= 0)
            {
                Phone phone = numberComboBox.Items[idx] as Phone;
                if (phone != null)
                {
                    m_PhoneID = phone.id;
                }
            }
            m_dateLink = linkDateTimePicker.Value;
        }
    }
}
