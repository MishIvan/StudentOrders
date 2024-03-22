using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DisabilityList
{
    public partial class DisabilityListForm : Form
    {
        long m_id;
        DisabilityListWithContent m_dlist;
        BindingList<FreeRecordView> m_fwlist;
        public DisabilityListForm(long id = 0)
        {
            InitializeComponent();
            m_id = id;
            m_dlist = null;
        }

        private async void OnLoad(object sender, EventArgs e)
        {
            Icon = Properties.Resources.illness32; 
            if(m_id < 1)
                m_dlist = new DisabilityListWithContent();

            var lsth = await Program.m_helper.GetHospitals();
            hospital_comboBox.DataSource = lsth;

            var lstp = await Program.m_helper.GetPatients();
            patient_comboBox.DataSource = lstp;

            if(m_id > 0)
            {
                m_dlist = Program.m_helper.GetDisalbilityListByID(m_id);
                if(m_dlist != null) 
                { 
                    var lsf = await Program.m_helper.GetFreeFromWorkList(m_dlist.id);
                    m_fwlist = !lsf.IsNullOrEmpty() ? new BindingList<FreeRecordView>(lsf) 
                        : new BindingList<FreeRecordView>();
                    deliveryDate_dateTimePicker.Value = m_dlist.delivery_date;
                    free_dataGridView.DataSource = m_fwlist;

                    int idx = GetIndexByID(hospital_comboBox, m_dlist.idhospital);
                    if(idx >= 0 )
                        hospital_comboBox.SelectedIndex = idx;

                    idx = GetIndexByID(patient_comboBox, m_dlist.idpatient);
                    if(idx >= 0 )
                        patient_comboBox.SelectedIndex = idx;

                    code_textBox.Text = m_dlist.reason_code;
                    addcode_textBox.Text += m_dlist.add_reason_code;

                    regnum_maskedTextBox.Text = m_dlist.regnum;
                    submitCode_maskedTextBox.Text = m_dlist.code_sub;

                    int year = 0, month = 0;
                    ConvertToYearMonth(m_dlist.time_service, ref year, ref month);
                    yearService_textBox.Text = year.ToString();
                    monthService_textBox.Text = month.ToString();

                    salary_textBox.Text = m_dlist.salary.ToString();

                }
            }
            else
            {
                m_fwlist = new BindingList<FreeRecordView>();
                m_dlist.id = m_id;
                m_dlist.list_content = new byte[1];
                m_dlist.list_content[0] = 0;
                m_dlist.content_type = string.Empty;
            }

            free_dataGridView.DataSource = m_fwlist;
        }

        private void ConvertToYearMonth(double dblYears,ref int year,ref int month)
        {
            year = (int)Math.Floor(dblYears);
            month = (int)Math.Floor((dblYears - year) * 12.0);
        }

        private double ConvertToDoubleYears(int year, int month)
        {
            return (double)year + (double)month/12.0;
        }
        /// <summary>
        /// Найти индекс в списке по идентификатору в БД
        /// </summary>
        /// <param name="cmb">Выпвдвющий список</param>
        /// <returns>индекс в списке, -1 е найден</returns>
        private int GetIndexByID(ComboBox cmb, long id)
        {
            int idx = -1;
            if (cmb == patient_comboBox)
            {
                foreach (var el in patient_comboBox.Items)
                {
                    Patient patient = el as Patient;
                    if (patient != null)
                    {
                        if (patient.id == id) return ++idx;
                    }
                    idx++;
                }
            }
            else if (cmb == hospital_comboBox)
            {
                foreach (var el in hospital_comboBox.Items)
                {
                    Hospital hosp = el as Hospital;
                    if (hosp != null)
                    {
                        if (hosp.id == id) return ++idx;
                    }
                    idx++;
                }

            }
            return -1;
        }
        /// <summary>
        /// выбор лечебного учреждения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnHospitalChanged(object sender, EventArgs e)
        {
            if (hospital_comboBox.Items.Count < 1) return;
            int idx = hospital_comboBox.SelectedIndex;
            if (idx < 0) return;
            Hospital hosp = hospital_comboBox.Items[idx] as Hospital;
            if (hosp != null && m_dlist != null) 
            { 
                m_dlist.idhospital = hosp.id;   
            }
        }
        /// <summary>
        /// Выбор получателя листка нетрудоспособности (на себя или по уходу за родственником)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnPatientChanged(object sender, EventArgs e)
        {
            if (patient_comboBox.Items.Count < 1) return;
            int idx = patient_comboBox.SelectedIndex;
            if (idx < 0) return;
            Patient p = patient_comboBox.Items[idx] as Patient;
            if (p != null && m_dlist != null)
            {
                m_dlist.idpatient = p.id;
            }

        }
        /// <summary>
        /// Выбор кода причины нетрудоспособности
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void code_button_Click(object sender, EventArgs e)
        {
            CodesForm code_frm = new CodesForm(1);
            if(code_frm.ShowDialog() == DialogResult.OK)
            {
                code_textBox.Text = code_frm.code;
                m_dlist.reason_code = code_frm.code;
            }
        }
        /// <summary>
        /// Выбор дополнительного кода причины нетрудоспособности
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void add_code_button_Click(object sender, EventArgs e)
        {
            CodesForm code_frm = new CodesForm(2);
            if (code_frm.ShowDialog() == DialogResult.OK)
            {
                addcode_textBox.Text = code_frm.code;
                m_dlist.add_reason_code = code_frm.code;
            }

        }
        /// <summary>
        /// Добавить в список освобождений от работы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void add_button_Click(object sender, EventArgs e)
        {
            FreeRecordView recordView = new FreeRecordView
            {
                idlist = m_dlist.id > 0 ? m_dlist.id : 0,
                relative_code = string.Empty,
                iddoctor = 0,
                doct_name = string.Empty,
                idpatient = m_dlist.idpatient,
                patient = string.Empty,
                idhospital = m_dlist.idhospital,
                speciality = string.Empty,
                datefrom = DateTime.Now,
                dateto = DateTime.Now
            };
            FreeFromWorkForm frm = new FreeFromWorkForm(recordView);
            if(frm.ShowDialog() == DialogResult.OK)
            {
                if(!ValidateDateIntervals(frm.recordView.datefrom, frm.recordView.dateto))
                {
                    Program.ShowErrorMessage("Интервалы дат в списке освобождения от работы не должны совпадать и должны быть смежными");
                    return;
                }
                else
                    m_fwlist.Add(frm.recordView);
            }
        }
        /// <summary>
        /// Изменить элемент списка освобождений от работы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void edit_button_Click(object sender, EventArgs e)
        {
            var row = free_dataGridView.CurrentRow; 
            if (row == null) return;
            FreeRecordView recordView = new FreeRecordView
            {
                idlist = Convert.ToInt64(row.Cells["idlist"].Value),
                relative_code = row.Cells["relative_code"].Value.ToString(),
                iddoctor = Convert.ToInt64(row.Cells["iddoctor"].Value),
                doct_name = row.Cells["doct_name"].Value.ToString(),
                idpatient = Convert.ToInt64(row.Cells["idpatient"].Value),
                patient = row.Cells["patient"].Value.ToString(),
                idhospital = Convert.ToInt64(row.Cells["idhospital"].Value),
                speciality = row.Cells["speciality"].Value.ToString(),
                datefrom = Convert.ToDateTime(row.Cells["datefrom"].Value),
                dateto = Convert.ToDateTime(row.Cells["dateto"].Value)
            };
            FreeFromWorkForm frm = new FreeFromWorkForm(recordView);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                if (!ValidateDateIntervals(frm.recordView.datefrom, frm.recordView.dateto))
                {
                    Program.ShowErrorMessage("Интервалы дат в списке освобождения от работы не должны совпадать и должны быть смежными");
                    return;
                }
                else 
                {
                    int idx = row.Index;
                    m_fwlist.Insert(idx, frm.recordView); 
                    m_fwlist.RemoveAt(idx + 1);
                }
            }

        }
        /// <summary>
        /// Удалить элемент списка освобождений от работы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void delete_button_Click(object sender, EventArgs e)
        {
            var row = free_dataGridView.CurrentRow;
            if (row == null) return;
            m_fwlist.RemoveAt(row.Index);

        }
        /// <summary>
        /// Определить, являются ли интервал даты смежным с интевалами дат освобождения от работы
        /// или сопадает с одним из интервалов
        /// </summary>
        /// <param name="dfrom">Начало интервала</param>
        /// <param name="dto">Окончание интервала</param>
        /// <returns></returns>
        private bool ValidateDateIntervals(DateTime dfrom, DateTime dto)
        {
            foreach(var el in m_fwlist) 
            {
                if (el.datefrom.AddDays(1) == dto ||
                    el.dateto.AddDays(1) == dfrom ||
                   !(el.datefrom == dfrom && el.dateto == dto)) continue;
                else
                    return false;
            }
            return true;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="recordView"></param>
        /// <returns></returns>
        private int FindIndexInFreeList(FreeRecordView recordView)
        {

            int n = m_fwlist.Count;
            for(int i = 0; i < n; i++)
            {
                if (m_fwlist[i].idlist == recordView.idlist && 
                    m_fwlist[i].datefrom == recordView.datefrom && 
                    m_fwlist[i].dateto == recordView.dateto) return i;
            }    
            return -1;
        }

        /// <summary>
        /// Загрузка содержимого больничного листа
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void loadDoc_button_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = Environment.CurrentDirectory;
                openFileDialog.Filter = "Файлы PDF|*.pdf|" +
                    "Сканы документов|*.jpeg;*.jpg;*.png;*.gif;*.tif;*.tiff|Все файлы|*.*";
                openFileDialog.FilterIndex = 3;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    string filePath = openFileDialog.FileName;

                    await Task.Run( () => 
                    { 
                            m_dlist.list_content = System.IO.File.ReadAllBytes(filePath); 
                            m_dlist.content_type = System.IO.Path.GetExtension(filePath).Substring(1).ToLower();
                    });
                }
            }
        }
        /// <summary>
        /// Смотреть содержимое документа
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void viewDoc_button_Click(object sender, EventArgs e)
        {
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
                await Task.Run( () => { System.IO.File.WriteAllBytes(fileName, m_dlist.list_content); } );
                
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
        /// Нажали ОК
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ok_button_Click(object sender, EventArgs e)
        {
            m_dlist.delivery_date = deliveryDate_dateTimePicker.Value;
          
            if (m_fwlist.IsNullOrEmpty())
            {
                Program.ShowErrorMessage("Не заполнен список освобождений от работы");
                DialogResult = DialogResult.Cancel;
                return;
            }

            string rc = code_textBox.Text;
            if (string.IsNullOrEmpty(rc) || rc.Length < 2)
            {
                Program.ShowErrorMessage("Не задан код причины нетрудоспособности");
                DialogResult = DialogResult.Cancel;
                return;
            }
            m_dlist.reason_code = rc;
            m_dlist.add_reason_code = addcode_textBox.Text;

            string rn = regnum_maskedTextBox.Text;
            if (string.IsNullOrEmpty(rn) || rn.Length < 10)
            {
                Program.ShowErrorMessage("Не задан регистрационный номер или задан неверно");
                DialogResult = DialogResult.Cancel;
                return;
            }
            m_dlist.regnum = rn;

            string csub = submitCode_maskedTextBox.Text;
            if (string.IsNullOrEmpty(csub) || csub.Length < 5)
            {
                Program.ShowErrorMessage("Не задан код подчинённости или задан неверно");
                DialogResult = DialogResult.Cancel;
                return;
            }
            m_dlist.code_sub = csub;

            double tserv = 0.0;
            try
            {
                tserv = ConvertToDoubleYears(Convert.ToInt32(yearService_textBox.Text), Convert.ToInt32(monthService_textBox.Text));
            }
            catch (Exception)
            {
                Program.ShowErrorMessage("Неверно задан стаж");
                DialogResult = DialogResult.Cancel;
                return;
            }
            m_dlist.time_service = tserv;

            double salary = 0.0;
            try
            {
                salary = Convert.ToDouble(salary_textBox.Text);
            }
            catch(Exception) 
            {
                Program.ShowErrorMessage("Неверно задан средний заработок для исчисления пособия");
                DialogResult = DialogResult.Cancel;
                return;
            }
            m_dlist.salary = salary;

            var lst = m_fwlist.ToList();
            int nrec = m_id > 0 ? Program.m_helper.UpdateDisabilityList(m_dlist, lst) : 
                Program.m_helper.AddDisabilityList(m_dlist, lst);
            if(nrec < 1)
            {
                Program.DBErrorMessage();
                DialogResult = DialogResult.Cancel;
            }
            else
            {
                DialogResult = DialogResult.OK;
            }

        }

        /// <summary>
        /// Нажали Отмена
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cancel_button_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void calcwelfare_button_Click(object sender, EventArgs e)
        {
            DateTime deliveryDate = deliveryDate_dateTimePicker.Value;
            if (m_fwlist.IsNullOrEmpty())
            {
                Program.ShowErrorMessage("Не заполнен список освобождений от работы");
                return;
            }
            DateTime minDate = m_fwlist.Min(d => d.datefrom);
            DateTime maxDate = m_fwlist.Max(d => d.dateto); 
            //foreach (var fw in m_fwlist) 
            //{ 
            //    if(fw.datefrom < minDate) { minDate = fw.datefrom;}
            //    if(fw.dateto > maxDate) {  maxDate = fw.dateto;}
            //}

            double tserv = 0.0;
            try
            {
                tserv = ConvertToDoubleYears(Convert.ToInt32(yearService_textBox.Text), Convert.ToInt32(monthService_textBox.Text));
            }
            catch (Exception)
            {
                Program.ShowErrorMessage("Неверно задан стаж");
                DialogResult = DialogResult.Cancel;
                return;
            }

            double salary = 0.0;
            try
            {
                salary = Convert.ToDouble(salary_textBox.Text);
            }
            catch (Exception)
            {
                Program.ShowErrorMessage("Неверно задан средний заработок для исчисления пособия");
                DialogResult = DialogResult.Cancel;
                return;
            }

            double wfpay = Program.CalculateWelfare(deliveryDate, minDate, maxDate, salary, tserv);
            welfare_textBox.Text = wfpay.ToString();

        }
    }
}
