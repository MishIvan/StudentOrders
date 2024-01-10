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
        public long id { get { return m_id; } }
        public SimpleRefForm(int numRef, bool selMode = false)
        {
            InitializeComponent();
            m_selectMode = selMode;
            m_numRef = numRef;
        }

        private async void OnLoad(object sender, EventArgs e)
        {
            Icon = Properties.Resources.records_32;
            records_listBox.SelectedIndex = m_numRef;
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
                records_listBox.Enabled = false;
            }

            List<SimpleRef> refs = await Program.m_helper.GetSimpleRefRecords(m_tableName);
            if (!refs.IsNullOrEmpty())
            {
                records_listBox.DataSource = refs;
                records_listBox.SelectedIndex = 0;
                SimpleRef _ref = records_listBox.Items[0] as SimpleRef;
                if (_ref != null)
                    input_textBox.Text = _ref.name;
            }

        }

        private void add_button_Click(object sender, EventArgs e)
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
                
            }
        }

        private void edit_button_Click(object sender, EventArgs e)
        {
            if(m_selectMode)
            {
                DialogResult = DialogResult.Cancel;
            }
            else
            {

            }

        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            if (m_selectMode)
            {
                return;
            }
            else
            {

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
                if(_ref != null)
                    input_textBox.Text = _ref.name; 
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
            SimpleRef _ref = records_listBox.Items[idx] as SimpleRef;
            if (_ref != null)
            {
                input_textBox.Text = _ref.name;
                m_id = _ref.id;
            }

        }
    }
}
