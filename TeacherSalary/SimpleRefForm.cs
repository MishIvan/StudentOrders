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

namespace TeacherSalary
{
    public partial class SimpleRefForm : Form
    {
        bool m_selectMode;
        int m_numRef;
        long m_id;
        string m_tableName;
        bool m_deptChanged;
        public long id { get { return m_id; } }
        public bool deptChanged { get { return m_deptChanged; } }
        /// <summary>
        ///  Конструктор формы
        /// </summary>
        /// <param name="numRef">Порядок справочника в списке: 0 - должности преподавателей, 1 - кафедры, 2 - учебный дисциплины, 3 - виды занятий</param>
        /// <param name="selMode">true - режим выбора, false - режим управления</param>
        public SimpleRefForm(int numRef, bool selMode = false)
        {
            InitializeComponent();
            m_selectMode = selMode;
            m_numRef = numRef;
            m_deptChanged = false;  
        }

        private async void OnLoad(object sender, EventArgs e)
        {
            Icon = Properties.Resources.records_32;
            ref_comboBox.SelectedIndex = m_numRef;
            switch(m_numRef)
            {
                case 0:
                    m_tableName = "post";
                    break;  
                case 1:
                    m_tableName = "department";
                    break;
                case 2:
                    m_tableName = "discipline";
                    break;
                case 3:
                    m_tableName = "classtype";
                    break;
                default:
                    return;
            }
            // в режиме выбора изменить роли кнопок
            if (m_selectMode) 
            {
                add_button.Text = "Выбор";
                edit_button.Text = "Отмена";
                delete_button.Visible = false;
                ref_comboBox.Enabled = false;
                input_textBox.Enabled = false;
            }

            List<SimpleRef> refs = await Program.m_helper.GetSimpleRefRecords(m_tableName);
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
            if (m_selectMode)
            {
                int idx = records_listBox.SelectedIndex;
                SimpleRef _ref = records_listBox.Items[idx] as SimpleRef;
                if (_ref != null)
                {
                    m_id = _ref.id;
                    DialogResult = DialogResult.OK;
                }
                else
                    DialogResult = DialogResult.Cancel;
            }
            else
            {
                string name = input_textBox.Text;
                int recs = Program.m_helper.AddSimpleRefRecord(m_tableName, name);
                if (recs < 1)
                    Program.DBErrorMessage();
                else
                {
                    m_deptChanged = true;
                    List<SimpleRef> refs = await Program.m_helper.GetSimpleRefRecords(m_tableName);
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
        }
        /// <summary>
        /// Нажата кнопка Изменить (в режиме выбора Отмена)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void edit_button_Click(object sender, EventArgs e)
        {
            if(m_selectMode)
            {
                DialogResult = DialogResult.Cancel;
            }
            else
            {
                int idx = records_listBox.SelectedIndex;
                if (idx < 0) return;  
                SimpleRef _ref = records_listBox.Items[idx] as SimpleRef;
                if (_ref != null)
                {
                    m_id = _ref.id;  
                    string name = input_textBox.Text;
                    int recs = Program.m_helper.UpdateSimpleRefRecord(m_tableName, name, m_id);
                    if (recs < 1)
                        Program.DBErrorMessage();
                    else
                    {
                        m_deptChanged = true;
                        List<SimpleRef> refs = await Program.m_helper.GetSimpleRefRecords(m_tableName);
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

        }
        /// <summary>
        /// Нажата кнопка Удалить (в режиме выбора скрыта)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void delete_button_Click(object sender, EventArgs e)
        {
            if (m_selectMode) return;
            int idx = records_listBox.SelectedIndex;
            if (idx < 0) return;
            SimpleRef _ref = records_listBox.Items[idx] as SimpleRef;
            if (_ref != null)
            {
                m_id = _ref.id;
                int recs = Program.m_helper.DeleteSimpleRefRecord(m_tableName, m_id);
                if (recs < 1)
                    Program.DBErrorMessage();
                else
                {
                    List<SimpleRef> refs = await Program.m_helper.GetSimpleRefRecords(m_tableName);
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
        /// Изменили выбор справочника
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void OnReferenceChanged(object sender, EventArgs e)
        {
            m_numRef = ref_comboBox.SelectedIndex;
            switch (m_numRef)
            {
                case 0:
                    m_tableName = "post";
                    break;
                case 1:
                    m_tableName = "department";
                    break;
                case 2:
                    m_tableName = "discipline";
                    break;
                case 3:
                    m_tableName = "classtype";
                    break;
                default:
                    return;
            }

            List<SimpleRef> refs = await Program.m_helper.GetSimpleRefRecords(m_tableName);
            if(!refs.IsNullOrEmpty())
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
