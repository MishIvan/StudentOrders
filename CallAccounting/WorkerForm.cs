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
    /// Форма управления справочником  работников
    /// </summary>
    public partial class WorkerForm : Form
    {
        private List<Worker> m_wrkList;
        private List<Department> m_depList;
        private long m_currentId;
        private bool m_changed;

        public bool changed { get { return m_changed; } }
        public WorkerForm()
        {
            InitializeComponent();
            m_wrkList = null;
            m_depList = null;
            m_currentId = 0;
            m_changed = false;
        }

        private async void OnLoad(object sender, EventArgs e)
        {
            m_depList = await Program.m_helper.GetDepartmentsList();
            departmentComboBox.DataSource = m_depList;

            m_wrkList = await Program.m_helper.GetWorkersList();
            workerNameComboBox.DataSource = m_wrkList;

            Icon = Properties.Resources.worker32;

        }
        /// <summary>
        /// Нажата кнопка Добавить
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void OnAddRecord(object sender, EventArgs e)
        {

            string wname = workerNameComboBox.Text;
            Worker wrk = m_wrkList.Where(w => w.name == wname).FirstOrDefault();
            if (wrk != null)
            {
                MessageBox.Show($"Сотрудник {wrk.name} уже существует в базе данных");
                return;
            }

            int idx = departmentComboBox.SelectedIndex;
            if (idx >= 0)
            {
                Department dept = departmentComboBox.Items[idx] as Department;
                if (dept != null)
                {
                    if (Program.m_helper.AddWorker(wname, dept.id , adminCheckBox.Checked) < 1)
                    {
                        MessageBox.Show($"Ошибка: {Program.m_helper.errorText}");
                    }
                    else 
                    {
                        m_wrkList = await Program.m_helper.GetWorkersList();
                        workerNameComboBox.DataSource = m_wrkList;
                        idx = workerNameComboBox.FindString(wname);
                        if (idx >= 0)
                            workerNameComboBox.SelectedIndex = idx;
                        m_changed = true;
                    }
                }
            }   
          
        }
        /// <summary>
        /// Нажата кнопка Править
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void OnEditRecord(object sender, EventArgs e)
        {
            string wname = workerNameComboBox.Text;
            int idx = departmentComboBox.SelectedIndex;
            if (idx >= 0)
            {
                Department dept = departmentComboBox.Items[idx] as Department;
                if (dept != null)
                {
                    if (Program.m_helper.UpdateWorker(m_currentId, wname, dept.id , adminCheckBox.Checked) < 1)
                    {
                        MessageBox.Show($"Ошибка:  {Program.m_helper.errorText}");
                    }
                    else
                    {
                        m_wrkList = await Program.m_helper.GetWorkersList();
                        workerNameComboBox.DataSource = m_wrkList;
                        idx = workerNameComboBox.FindString(wname);
                        if (idx >= 0)
                            workerNameComboBox.SelectedIndex = idx;
                        m_changed = true;

                    }
                }
            }
            

        }
        /// <summary>
        /// Изменился индекс работника на закладке Сотрудники
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnWorkerNameIndexChanged(object sender, EventArgs e)
        {
            int idx = workerNameComboBox.SelectedIndex;
            if(idx >=0) {
                Worker wrk = workerNameComboBox.Items[idx] as Worker;
                if (wrk != null)
                {
                    m_currentId = wrk.id;
                    Department dept = m_depList.Where(d => d.id == wrk.iddept).FirstOrDefault();
                    if(dept != null)
                    {
                        idx = departmentComboBox.FindString(dept.name);
                        if(idx >= 0)
                        {
                            departmentComboBox.SelectedIndex = idx;
                        }
                    }

                }
            }
        }
    }
}
