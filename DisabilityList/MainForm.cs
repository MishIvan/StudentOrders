using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DisabilityList
{
    public partial class MainForm : Form
    {
        string m_patientFilter;
        public MainForm()
        {
            InitializeComponent();
            m_patientFilter = string.Empty;
        }

        private async void OnLoad(object sender, EventArgs e)
        {
            Icon = Properties.Resources.illness32;
            var lst = await Program.m_helper.GetDiasabilityListsForView();
            list_dataGridView.DataSource = lst;

        }

        private void справочникиToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Работа со справочником лечебных учреждений
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void hospitals_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HospitalForm frm = new HospitalForm();
            frm.ShowDialog();
        }
        /// <summary>
        /// Работа со справочником врачей
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void doctors_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DoctorForm frm = new DoctorForm();
            frm.ShowDialog();
        }
        /// <summary>
        /// Управление справочником пациентов и их родственников
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void patients_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PatientForm frm = new PatientForm();
            frm.ShowDialog();
        }
        /// <summary>
        /// Добавить листок нетрудоспособности
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void addList_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisabilityListForm frm = new DisabilityListForm();
            if(frm.ShowDialog() == DialogResult.OK)
            {
                var lst = await Program.m_helper.GetDiasabilityListsForView();
                if(!string.IsNullOrEmpty(m_patientFilter.Trim()))
                    list_dataGridView.DataSource = lst.Where(el => el.patient.Contains(m_patientFilter)).ToList();
                else
                    list_dataGridView.DataSource = lst;
            }
        }

        /// <summary>
        /// Главная форма закрыта, закрыть соединение и удалить временные файлы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnClose(object sender, FormClosedEventArgs e)
        {
            Program.m_helper.Dispose();
            foreach (string fname in Program.m_tmpFiles)
            {
                try
                {
                    System.IO.File.Delete(fname);
                }
                catch (Exception) { }
            }
            Program.m_tmpFiles.Clear();
        }

        private async void editList_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var row = list_dataGridView.CurrentRow;
            if(row == null ) return;
            long id = Convert.ToInt64(row.Cells["id"].Value);
            DisabilityListForm frm = new DisabilityListForm(id);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                var lst = await Program.m_helper.GetDiasabilityListsForView();
                if (!string.IsNullOrEmpty(m_patientFilter.Trim()))
                    list_dataGridView.DataSource = lst.Where(el => el.patient.Contains(m_patientFilter)).ToList();
                else
                    list_dataGridView.DataSource = lst;
            }

        }

        /// <summary>
        /// Удалить запись
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void deleteList_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var row = list_dataGridView.CurrentRow;
            if (row == null) return;
            long id = Convert.ToInt64(row.Cells["id"].Value);
            int recs = Program.m_helper.DeleteDisabilityList(id);
            if (recs > 0)
            {
                var lst = await Program.m_helper.GetDiasabilityListsForView();
                if (!string.IsNullOrEmpty(m_patientFilter.Trim()))
                    list_dataGridView.DataSource = lst.Where(el => el.patient.Contains(m_patientFilter)).ToList();
                else
                    list_dataGridView.DataSource = lst;

            }
            else
                Program.DBErrorMessage();
        }

        /// <summary>
        /// Применить фильтр по работникам на виде отображения списка листков нетрудоспособности
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void filterApply_button_Click(object sender, EventArgs e)
        {
            if(sender == filterApply_button)
            {
                m_patientFilter = filterPatient_textBox.Text;
            }
            else if(sender == filterReset_button)
            {
                filterPatient_textBox.Text = string.Empty;
                m_patientFilter = string.Empty;
            }
            var lst = await Program.m_helper.GetDiasabilityListsForView();
            if (!string.IsNullOrEmpty(m_patientFilter.Trim()))
                list_dataGridView.DataSource = lst.Where(el => el.patient.Contains(m_patientFilter)).ToList();
            else
                list_dataGridView.DataSource = lst;


        }

        /// <summary>
        /// Показать содержимое листка нетрудоспособности
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void showContent_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var row = list_dataGridView.CurrentRow;
            if (row == null) return;
            long id = Convert.ToInt64(row.Cells["id"].Value);

            DisabilityListWithContent m_dlist = Program.m_helper.GetDisalbilityListByID(id);
            if (m_dlist == null) return;    

            string tmpPath = System.IO.Path.GetTempPath();
            DateTime now = DateTime.Now;
            string fileName = "DisabilityList_" + now.ToString("yyyyMMddHHmmss");

            if (m_dlist.list_content != null)
            {
                if (m_dlist.list_content.Length < 2 && m_dlist.list_content[0] == 0)
                {
                    MessageBox.Show("Отсутсвует содержимое листка нетрудоспособности");
                }
                fileName = tmpPath + fileName + (string.IsNullOrEmpty(m_dlist.content_type) ? string.Empty : "." + m_dlist.content_type);
                await Task.Run(() => { System.IO.File.WriteAllBytes(fileName, m_dlist.list_content); });

                Program.m_tmpFiles.Add(fileName);
                try
                {
                    System.Diagnostics.Process.Start(fileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка показа содержимого листка нетрудоспособности");
                }

            }
            else
                MessageBox.Show("Не найден документ листка нетрудоспособности");

        }
        /// <summary>
        /// Выдача отчётной формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void info_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportForm reportForm = new ReportForm();
            reportForm.ShowDialog();
        }

        private void help_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string helpFileName = "DisabilityListHelp.html";
            string path = System.IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\" + helpFileName;
            if(System.IO.File.Exists(path)) 
            {
                try
                {
                    System.Diagnostics.Process.Start(path);
                }
                catch (Exception)
                {
                    Program.ShowErrorMessage("Не удаётся отобразить файл помощи");
                }

            }
            else
                Program.ShowErrorMessage("Не найден файл помощи");

        }

    }
}
