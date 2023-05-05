using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdAgency
{
    public partial class ContractCardForm : Form
    {
        private long m_id;
        private Contract m_contract;
        private Content m_currentContent;
        private bool m_jpChoiced;
        public ContractCardForm(long ID = 0)
        {
            InitializeComponent();
            m_id = ID;
            m_contract = null;
            m_currentContent = null;
            m_jpChoiced = true;
        }

        private void OnLoad(object sender, EventArgs e)
        {
            Icon = Properties.Resources.contract32;
            clientNameTextBox.Tag = null;
            if(m_id > 0) // заполнить поля формы
            {
                m_contract = Program.m_helper.GetContractByID(m_id);
                if(m_contract != null)
                {
                    numberTextBox.Text = m_contract.number;
                    cdateTimePicker.Value = m_contract.сdate;
                    nameTextBox.Text = m_contract.name;
                    datefromTimePicker.Value = m_contract.datefrom;
                    datetoTimePicker.Value = m_contract.dateto;

                    if(m_contract.idjuridical.HasValue && m_contract.idjuridical.Value > 0)
                    {
                        JuridicalPerson jp = Program.m_helper.GetJuridicalPersonByID(m_contract.idjuridical.Value);
                        if(jp != null)
                        {
                            clientNameTextBox.Text = jp.pname;
                            clientNameTextBox.Tag = jp.id;
                            clientTypeCheckBox.Checked = false;
                        }
                    }

                    if (m_contract.idphis.HasValue && m_contract.idphis.Value > 0)
                    {
                        PhisicalPerson pp = Program.m_helper.GetPhisicalPersonByID(m_contract.idphis.Value);
                        if (pp != null)
                        {
                            clientNameTextBox.Text = pp.pname;
                            clientNameTextBox.Tag = pp.id;
                            clientTypeCheckBox.Checked = true;
                        }
                    }

                    commentsTextBox.Text = m_contract.comments;

                }

            }
        }
        /// <summary>
        /// Загрузить текст договора из файла
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uploadButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = Environment.CurrentDirectory;
                openFileDialog.Filter = "Документы Word (*.docx)|*.docx|Документы Word (*.doc)|*.doc|Файлы PDF (*.pdf)|*.pdf|" +
                    "Все файлы (*.*)|*.*";
                openFileDialog.FilterIndex = 0;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    string filePath = openFileDialog.FileName;

                    m_currentContent = new Content();
                    m_currentContent.content = System.IO.File.ReadAllBytes(filePath);
                    m_currentContent.contenttype = System.IO.Path.GetExtension(filePath).Substring(1).ToLower();
                    //if (Program.m_helper.UploadContractContent(m_id, m_currentContent) < 1)
                    //{
                    //    Program.ErrorMessageDB();
                    //    m_currentContent = null;

                    //}
                    
                }
            }
        }
        /// <summary>
        /// Скачать и показать текст договора
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void downloadButton_Click(object sender, EventArgs e)
        {
            string tmpPath = System.IO.Path.GetTempPath();
            DateTime now = DateTime.Now;
            string fileName = "ADContract_" + now.ToString("yyyyMMddHHmmss");
            if(m_id > 0)
                m_currentContent = Program.m_helper.DownloadContractContent(m_id);
           
            if (m_currentContent != null)
            {
                if(m_currentContent.content.Length < 2 && m_currentContent.content[0] == 0)
                {
                    MessageBox.Show("Текст договора отсутствует");
                }
                fileName = tmpPath + fileName + (string.IsNullOrEmpty(m_currentContent.contenttype) ? string.Empty : "." + m_currentContent.contenttype);
                System.IO.File.WriteAllBytes(fileName, m_currentContent.content);
                Program.m_tmpFiles.Add(fileName);
                try
                {
                    System.Diagnostics.Process.Start(fileName);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка показа текста договора");
                }
                
            }
            else
                MessageBox.Show("Не найден текст договора");

            
        }
        /// <summary>
        /// Выбрать контрагента
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void choiceClientButton_Click(object sender, EventArgs e)
        {
            if(clientTypeCheckBox.Checked)
            {
                MessageBox.Show("В разработке...");                
            }
            else
            {
                JuridicalPersonForm frm = new JuridicalPersonForm(true);
                if(frm.ShowDialog() == DialogResult.OK)
                {
                    JuridicalPerson jp = Program.m_helper.GetJuridicalPersonByID(frm.personID);
                    if(jp != null)
                    {
                        clientNameTextBox.Text = jp.pname;
                        clientNameTextBox.Tag = jp.id;
                        m_jpChoiced = true;
                    }
                }
            }
        }
        /// <summary>
        /// Добавить договор или изменить реквизиты договора
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void acceptButton_Click(object sender, EventArgs e)
        {
            if (m_id < 1)
                m_contract = new Contract();

            m_contract.name = nameTextBox.Text;
            m_contract.number = numberTextBox.Text;
            m_contract.сdate = cdateTimePicker.Value;
            m_contract.datefrom = datefromTimePicker.Value;
            m_contract.dateto = datetoTimePicker.Value;
            m_contract.comments = commentsTextBox.Text;
            if (m_jpChoiced)
            {
                m_contract.idjuridical = Convert.ToInt64(clientNameTextBox.Tag);
                m_contract.idphis = null;
            }
            else
            {
                m_contract.idjuridical = null;
                m_contract.idphis = Convert.ToInt64(clientNameTextBox.Tag);
            }
            

            if(m_currentContent == null)
            {
                m_contract.content = new byte[] { 0 };
                m_contract.contenttype = string.Empty; 
            }
            else
            {
                m_contract.content = m_currentContent.content;
                m_contract.contenttype = m_currentContent.contenttype;
            }
            int nrec = -1;
            if (m_id < 1)
                nrec = Program.m_helper.AddContract(m_contract);
            else
            {
                nrec = Program.m_helper.UpdateContract(m_contract);
                if(nrec < 1)
                    Program.ErrorMessageDB();
                else
                    nrec = Program.m_helper.UploadContractContent(m_contract.id, m_currentContent);
                
            }

            if(nrec < 1)
            {
                Program.ErrorMessageDB();
                DialogResult = DialogResult.Cancel;
            }
        }
        /// <summary>
        /// Установка наименования договора
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnTextChanged(object sender, EventArgs e)
        {
            string number = numberTextBox.Text;
            string scdate = cdateTimePicker.Value.ToString("dd.MM.yyyy");
            nameTextBox.Text = $"Договор №{number} от {scdate} {topicTextBox.Text} {clientNameTextBox.Text}";
        }
    }
}
