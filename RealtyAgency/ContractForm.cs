using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RealtyAgency
{
    public partial class ContractForm : Form
    {
        long m_id;
        long m_principalId;
        long m_agentId;
        long m_realtyId;
        byte[] m_content;
        string m_contenttype;
        double m_summa;
        double m_oldPremium;
        List<string> m_tmpFiles;

        public ContractForm(long id = 0)
        {
            InitializeComponent();
            m_id = id;
            m_principalId = 0; 
            m_agentId = 0;
            m_realtyId = 0;
            m_content = new byte[] { 0 };
            m_contenttype = string.Empty;
            m_oldPremium = 0.0;
            m_tmpFiles = new List<string>();
        }

        private async void OnLoad(object sender, EventArgs e)
        {
            Icon = Properties.Resources.contract_32;
            List<Simple> lst = await Program.m_helper.GetContractStalusList();
            dealStatus_comboBox.DataSource = lst;
            if (m_id < 1)
            {
                dealStatus_comboBox.SelectedIndex = 0;
                dealStatus_comboBox.Enabled = false;
                m_agentId = Program.m_userid;
            }
            else
            {
                Contract cnt = Program.m_helper.GetContractByid(m_id);
                if (cnt != null)
                {
                    number_textBox.Text = cnt.number;
                    date_dateTimePicker.Value = cnt.cdate;

                    m_principalId = cnt.idprincipal;
                    Principal principal = Program.m_helper.GetPrincipalById(m_principalId);
                    if (principal != null)
                        principal_textBox.Text = principal.name;

                    m_realtyId = cnt.idrealty;
                    RealtyObject ro = Program.m_helper.GetRealtyObjectById(m_realtyId);
                    if (ro != null)
                        realty_textBox.Text = ro.ToString();

                    m_content = cnt.content;
                    m_contenttype = cnt.contenttype;

                    m_oldPremium = cnt.premium;
                    m_summa = cnt.csumma;

                    premium_maskedTextBox.Text = string.Format("{0:00.#}", cnt.premium).Replace('0', ' ');
                    summa_textBox.Text = string.Format("{0:N3}", m_summa);

                    sail_checkBox.Checked = cnt.sail;
                    m_agentId = cnt.idagent;
                }
            }

            Agent agent = Program.m_helper.GetAgentById(m_agentId);
            if (agent != null)
                agent_textBox.Text = agent.name;
            OK_Button.Visible = m_agentId == Program.m_userid || Program.m_userrole == 1;
        }
        /// <summary>
        /// Выбор принципала
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void principalChoice_button_Click(object sender, EventArgs e)
        {
            ChoiceForm frm = new ChoiceForm('p');
            if(frm.ShowDialog() == DialogResult.OK)
            {
                principal_textBox.Text = frm.name;
                m_principalId = frm.id; 
            }
        }
        /// <summary>
        /// Выбор объекта недвижимости
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void realtyChoice_button_Click(object sender, EventArgs e)
        {
            ChoiceForm frm = new ChoiceForm('r');
            if(frm.ShowDialog() == DialogResult.OK)
            {
                realty_textBox.Text = frm.name;
                m_realtyId = frm.id;
                double summ = frm.summ;
                double premium = 0.0;
                try
                {
                    premium = Convert.ToDouble(premium_maskedTextBox.Text.Trim());
                    m_oldPremium = premium;
                }
                catch 
                {
                    return;
                }
                m_summa = summ*(1.0 +premium*0.01);
                summa_textBox.Text = string.Format("{0:N3}", m_summa);
            }
        }
        /// <summary>
        /// Нажата ОК
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OK_Button_Click(object sender, EventArgs e)
        {            
            string num = number_textBox.Text;
            if(string.IsNullOrEmpty(num) || string.IsNullOrWhiteSpace(num))
            {
                MessageBox.Show("Требуется задать номер договора");
                DialogResult = DialogResult.Cancel;
            }
            double _premium = 0.0;
            try
            {
                _premium = Convert.ToDouble(premium_maskedTextBox.Text.Trim());
            }
            catch
            {
                MessageBox.Show("Неверный формат задания агентского вознаграждения или суммы договора");
                return;
            }

            int idx = dealStatus_comboBox.SelectedIndex;
            long stat = 0;
            if(idx >= 0)
            {
                Simple status = dealStatus_comboBox.Items[idx] as Simple;
                if(status != null)
                {
                    stat = status.id;
                }

            }

            Contract contract = new Contract()
            {
                id = m_id,
                idagent = m_agentId,
                idrealty = m_realtyId,
                idprincipal = m_principalId,
                number = num,
                cdate = date_dateTimePicker.Value,
                sail = sail_checkBox.Checked,
                csumma = m_summa,
                premium = _premium,
                content = m_content,
                contenttype = m_contenttype,
                deal_status_id = stat
            };
            long id  = m_id > 0 ? Program.m_helper.UpdateContract(contract) : Program.m_helper.AddContract(contract);
            if(id < 1)
            {
                Program.ErrorMessageDB();
                DialogResult = DialogResult.Cancel;
            }
            else
                DialogResult = DialogResult.OK;
            

        }
        /// <summary>
        /// Изменился процент агентского вознаграждения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnPremiumChanged(object sender, EventArgs e)
        {
            double premium = 0.0;
            try 
            { 
                premium = Convert.ToDouble(premium_maskedTextBox.Text.Trim());
                m_summa = m_summa*(1.0 + premium*0.01)/(1.0 + m_oldPremium*0.01);
                m_oldPremium = premium;
                summa_textBox.Text = string.Format("{0:N3}", m_summa);

            }
            catch (Exception) 
            {
                return;
            }
        }
        /// <summary>
        /// Загрузить содержание
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void upload_button_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = Environment.CurrentDirectory;
                openFileDialog.Filter = "Документы Word (*.docx)|*.docx|Документы Word (*.doc)|*.doc|Файлы PDF (*.pdf)|*.pdf|Файлы JPEG (*.jpeg)|*.jpeg|Все файлы (*.*)|*.*";
                openFileDialog.FilterIndex = 0;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // полный путь к загружаемому 
                    string filePath = openFileDialog.FileName;

                    m_content = await Task<byte[]>.Run(() => { return System.IO.File.ReadAllBytes(filePath); });
                    m_contenttype = System.IO.Path.GetExtension(filePath).Substring(1).ToLower();

                }
            }

        }
        /// <summary>
        /// Показать содержание
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void show_button_Click(object sender, EventArgs e)
        {
            string tmpPath = System.IO.Path.GetTempPath();
            DateTime now = DateTime.Now;
            string fileName = "RealtyAgencyContract_" + now.ToString("yyyyMMddHHmmss");
            if (m_content[0] != 0)
            {
                if (m_content.Length < 2 && m_content[0] == 0)
                {
                    MessageBox.Show("Текст договора отсутствует");
                }
                fileName = tmpPath + fileName + (string.IsNullOrEmpty(m_contenttype) ? string.Empty : "." + m_contenttype);
                await Task.Run(() => { System.IO.File.WriteAllBytes(fileName, m_content); });
                m_tmpFiles.Add(fileName);
                try
                {
                    System.Diagnostics.Process.Start(fileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка показа текста договора");
                }

            }
            else
                MessageBox.Show("Не найден текст договора");

        }
        /// <summary>
        /// Закрытие формы, удаление временных файлов
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnClosed(object sender, FormClosedEventArgs e)
        {
            foreach (string file in m_tmpFiles) 
            { 
                try
                {
                    System.IO.File.Delete(file);
                }
                catch { }
            }
            m_tmpFiles.Clear();
        }
    }
}
