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
    public partial class AddressForm : Form
    {
        private long m_id;
        private AddressBook m_record; 

        public AddressForm(long id = 0)
        {
            InitializeComponent();
            m_id = id;
            m_record = null;
        }

        private void OnLoad(object sender, EventArgs e)
        {
            Icon = Properties.Resources.edit_icon32;
            if(m_id > 0)
            {
                m_record = Program.m_helper.GetAddressDataRecord(m_id);
                if(m_record != null) 
                {
                    nameTextBox.Text = m_record.name;
                    birth_dateTimePicker.Value = m_record.birth_date;
                    phoneTextBox.Text = m_record.phone;
                    addressTextBox.Text = m_record.address;
                    notesTextBox.Text = m_record.comments;

                }
            }
        }
        /// <summary>
        /// Добавить или править запись
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OK_Button_Click(object sender, EventArgs e)
        {
            if(m_id > 0) // update
            {
                if(m_record != null) 
                {
                    m_record.id = m_id;
                    m_record.name = nameTextBox.Text;
                    m_record.birth_date = birth_dateTimePicker.Value;
                    m_record.phone = phoneTextBox.Text;
                    m_record.address = addressTextBox.Text;
                    m_record.comments = notesTextBox.Text;

                    int recs = Program.m_helper.UpdateAdressRecord(m_record);
                    if(recs < 1) 
                    {
                        MessageBox.Show(Program.m_helper.errorText, "Неудача изменения записи");
                        m_record = null;
                        DialogResult = DialogResult.Cancel; 
                        return;
                    }
                    else 
                        DialogResult = DialogResult.OK;
                }
            }
            else // insert
            {
                m_record = new AddressBook
                {
                    id = 0,
                    name = nameTextBox.Text,
                    birth_date = birth_dateTimePicker.Value,
                    phone = phoneTextBox.Text,
                    address = addressTextBox.Text,
                    comments = notesTextBox.Text

                };
                int recs = Program.m_helper.AddAddressRecord(m_record);
                if (recs < 1)
                {
                    MessageBox.Show(Program.m_helper.errorText, "Неудача добавления записи записи");
                    m_record = null;
                    DialogResult = DialogResult.Cancel;
                    return;
                }
                else
                    DialogResult = DialogResult.OK;

            }
        }
    }
}
