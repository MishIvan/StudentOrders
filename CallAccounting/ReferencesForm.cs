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
    public partial class ReferencesForm : Form
    {
        private List<Worker> m_wrkList;
        private List<Phone> m_phoneList;
        private List<Department> m_depList;
        public ReferencesForm()
        {
            InitializeComponent();
            m_wrkList = null;
            m_phoneList = null;
            m_depList = null;
        }

        private async void OnLoad(object sender, EventArgs e)
        {
            int idx = referenceTabControl.SelectedIndex;
            deleteButton.Enabled = idx == 0;
            m_wrkList = await Program.m_helper.GetWorkersList();
            workerNameComboBox.DataSource = m_wrkList.Select(w => w.name).ToList();

            m_phoneList = await Program.m_helper.GetPhonesList();
            numberComboBox.DataSource = m_phoneList.Select(ph=> ph.number).ToList();

            m_depList = await Program.m_helper.GetDepartmentsList();
            depNameComboBox.DataSource = m_depList.Select(d=> d.name).ToList();


        }
        /// <summary>
        /// Нажата кнопка Добавить
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async  void OnAddRecord(object sender, EventArgs e)
        {
            int idx = referenceTabControl.SelectedIndex;
            // сотрудники
            if (idx == 0)
            {

                string wname = workerNameComboBox.Text;
                Worker wrk = m_wrkList.Where(w => w.name == wname).FirstOrDefault();
                if (wrk != null)
                {
                    MessageBox.Show($"Сотрудник {wrk.name} уже существует в базе данных");
                    return;
                }

                idx = departmentComboBox.SelectedIndex;
                if (idx >= 0)
                {
                    string dname = departmentComboBox.Items[idx].ToString();
                    long? iddept = m_depList.Where(d => d.name == dname).Select(d => d.id).FirstOrDefault();
                    if (iddept.HasValue)
                    {
                        if (Program.m_helper.AddWorker(wname, iddept.Value, adminCheckBox.Checked, closedCheckBox.Checked) < 1)
                        {
                            MessageBox.Show($"Ошибка: {Program.m_helper.errorText}");
                        }
                        else 
                        {
                            m_wrkList = await Program.m_helper.GetWorkersList();
                            workerNameComboBox.DataSource = m_wrkList.Select(w => w.name).ToList();
                            idx = workerNameComboBox.FindString(wname);
                            if (idx >= 0)
                                workerNameComboBox.SelectedIndex = idx;
                        }
                    }
                }

                
            }

            // отделы
            else if(idx == 1)
            { 

            }

            // номера телефонов
            else if (idx == 2)
            {

            }
        }
        /// <summary>
        /// Нажата кнопка Править
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnEditRecord(object sender, EventArgs e)
        {
            int idx = referenceTabControl.SelectedIndex;
            if (idx == 0)
            {
                idx = workerNameComboBox.SelectedIndex;
                if (idx >= 0)
                {
                    string wname = workerNameComboBox.Items[idx].ToString();
                    Worker wrk = m_wrkList.Where(w => w.name == wname).FirstOrDefault();
                    if(wrk != null)
                    {
                        MessageBox.Show($"Сотрудник {wrk.name} уже есть а базе данных");
                        return;
                    }
                }
                closedCheckBox.Checked = false;
            }
            else if (idx == 1)
            {

            }
            else if (idx == 2)
            {

            }

        }
        /// <summary>
        /// Нжата кнопка удалить
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnDeleteRecord(object sender, EventArgs e)
        {
            int idx = referenceTabControl.SelectedIndex;
            if (idx == 0)
            {

            }
            else if (idx == 1)
            {

            }
            else if (idx == 2)
            {

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
            if(idx >=0)
            {
                string wname = workerNameComboBox.Items[idx].ToString();
                Worker wrk = m_wrkList.Where(w => w.name == wname).FirstOrDefault();
                if (wrk != null)
                {
                    Department dept = m_depList.Where(d => d.id == wrk.iddept).FirstOrDefault();
                    if(dept != null)
                    {
                        idx = departmentComboBox.FindString(dept.name);
                        if(idx >= 0)
                        {
                            departmentComboBox.SelectedIndex = idx;
                        }
                    }

                    adminCheckBox.Checked = wrk.admin;
                    closedCheckBox.Checked = wrk.closed;
                }
            }
        }
    }
}
