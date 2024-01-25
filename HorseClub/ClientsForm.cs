using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HorseClub
{
    public partial class ClientsForm : Form
    {
        long m_id;
        public long id { get { return m_id; } }
        /// <summary>
        ///  Конструктор формы
        /// </summary>
        public ClientsForm()
        {
            InitializeComponent();
            m_id = 0;
        }

        private async void OnLoad(object sender, EventArgs e)
        {
            Icon = Properties.Resources.client_32;

            List<SimpleRef> refs = await Program.m_helper.GetSimpleRefRecords();
            if (!refs.IsNullOrEmpty())
            {
                records_listBox.DataSource = refs;
                records_listBox.SelectedIndex = 0;
                SimpleRef _ref = records_listBox.Items[0] as SimpleRef;
                if (_ref != null)
                {
                    input_textBox.Text = _ref.name;
                    m_id = _ref.id;
                }
            }
            else
            {
                records_listBox.DataSource=null;
                input_textBox.Text = string.Empty; 
            }

        }
        /// <summary>
        /// Кнопка Добавить (в режиме выбора 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void add_button_Click(object sender, EventArgs e)
        {
            string name = input_textBox.Text;
            int recs = Program.m_helper.AddSimpleRefRecord(name);
            if (recs < 1)
                Program.DBErrorMessage();
            else
            {
                List<SimpleRef> refs = await Program.m_helper.GetSimpleRefRecords();
                if (!refs.IsNullOrEmpty())
                {
                    records_listBox.DataSource = refs;
                    records_listBox.SelectedIndex = 0;
                    SimpleRef _ref = records_listBox.Items[0] as SimpleRef;
                    if (_ref != null)
                    {
                        input_textBox.Text = _ref.name;
                        m_id = _ref.id;
                    }
                }

            }

        }
        /// <summary>
        /// Нажата кнопка Изменить (в режиме выбора Отмена)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void edit_button_Click(object sender, EventArgs e)
        {
                int idx = records_listBox.SelectedIndex;
                if (idx < 0) return;  
                SimpleRef _ref = records_listBox.Items[idx] as SimpleRef;
                if (_ref != null)
                {
                    m_id = _ref.id;  
                    string name = input_textBox.Text;
                    int recs = Program.m_helper.UpdateSimpleRefRecord(name, m_id);
                    if (recs < 1)
                        Program.DBErrorMessage();
                    else
                    {
                        List<SimpleRef> refs = await Program.m_helper.GetSimpleRefRecords();
                        if (!refs.IsNullOrEmpty())
                        {
                            records_listBox.DataSource = refs;
                            records_listBox.SelectedIndex = 0;
                            _ref = records_listBox.Items[0] as SimpleRef;
                            if (_ref != null)
                            {
                                input_textBox.Text = _ref.name;
                                m_id = _ref.id;
                            }
                        }

                    }

                }

        }
        /// <summary>
        /// Нажата кнопка Удалить (в режиме выбора скрыта)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void delete_button_Click(object sender, EventArgs e)
        {
            int idx = records_listBox.SelectedIndex;
            if (idx < 0) return;
            SimpleRef _ref = records_listBox.Items[idx] as SimpleRef;
            if (_ref != null)
            {
                m_id = _ref.id;
                int recs = Program.m_helper.DeleteSimpleRefRecord(m_id);
                if (recs < 1)
                    Program.DBErrorMessage();
                else
                {
                    List<SimpleRef> refs = await Program.m_helper.GetSimpleRefRecords();
                    if (!refs.IsNullOrEmpty())
                    {
                        records_listBox.DataSource = refs;
                        records_listBox.SelectedIndex = 0;
                        _ref = records_listBox.Items[0] as SimpleRef;
                        if (_ref != null)
                        {
                            input_textBox.Text = _ref.name;
                            m_id = _ref.id;
                        }
                    }

                }

            }


        }

        /// <summary>
        /// Переход по записям справочника: изменить значение в поле ввода
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnRecordIndexChanged(object sender, EventArgs e)
        {
            int idx = records_listBox.SelectedIndex;
            if (idx < 0) return;
            SimpleRef _ref = records_listBox.Items[idx] as SimpleRef;
            if (_ref != null)
            {
                input_textBox.Text = _ref.name;
                m_id = _ref.id;
            }

        }
    }
}
