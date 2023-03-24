using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace AutoCollection
{
    /// <summary>
    /// Форма добавления действия
    /// </summary>
    public partial class ActionForm : Form
    {
        private int m_idaction; // идентификатор действия
        private long m_idauto; // идентификатор авто
        private byte[] m_docContent;
        public ActionForm(long idauto, int idact)
        {
            InitializeComponent();
            m_idauto = idauto;
            m_idaction = idact;
            m_docContent = null;
        }
        /// <summary>
        /// Инициализация формы действия
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnLoad(object sender, EventArgs e)
        {
            // Задать заголовок формы
            switch(m_idaction)
            {
                case 1:
                    Text = "Выдача доверенности";
                    break;
                case 2:
                    Text = "Отзыв доверенности"; break;
                case 3:
                    Text = "Ремонт (прокачка) авто"; break;
                case 4:
                    Text = "Продажа"; break;
                case 5:
                    Text = "Дарение"; break;

            }

            // Наименование авто
            Auto car = Program.m_helper.GetAutoByID(m_idauto);            
            autoNameLabel.Text = car != null ? 
                (!string.IsNullOrEmpty(car.govnum) && !string.IsNullOrWhiteSpace(car.govnum) ? car.govnum + " " : "") + car.name : "";

            // скрыть ввод даты окончания для отзыва доверенности, ремонта, продажи и дарения
            if(m_idaction > 1)
            {
                endDateLabel.Visible = false;
                endDateTimePicker.Visible = false;
                beginDateLabel.Text = "Дата:";
            }

            // скрыть сумму для выдачи доверенности, отзыва доверенности и дарения
            if(m_idaction !=3 && m_idaction !=4)
            {
                sumLabel.Visible = false;
                sumTextBox.Visible = false;
            }

            // скрыть кнопку выбора немеров действующих неотозванных доверенностей
            if(m_idaction != 2)
            {
                choiceProxyButton.Visible = false;
            }

        }
        /// <summary>
        /// Загрузка скана документа и получение массива бйтов контента
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnLoadDocument(object sender, EventArgs e)
        {            
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = Environment.CurrentDirectory;
                openFileDialog.Filter = "Файлы png (*.png)|*.png|Все файлы (*.*)|*.*";
                openFileDialog.FilterIndex = 0;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // полный путь имени файла
                    string filePath = openFileDialog.FileName;
                    try
                    {
                        m_docContent = File.ReadAllBytes(filePath);
                        MessageBox.Show("Контент документа успешно загружен");
                    }
                    catch(Exception ex)
                    {
                        m_docContent = null;
                        MessageBox.Show($"Ошибка: {ex.Message}"); 
                    }
                }
            }

        }
        /// <summary>
        /// Показать скан документа
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnShowDocument(object sender, EventArgs e)
        {
            if(m_docContent != null)
            {
                ContentForm frm = new ContentForm(m_docContent);
                frm.ShowDialog();
            }
        }
        /// <summary>
        /// Добавление действия для авто
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnOK(object sender, EventArgs e)
        {
            DateTime db = beginDateTimePicker.Value;
            DateTime de = m_idaction > 1 ? db : endDateTimePicker.Value;

            string nomd = nomTextBox.Text;
            if (string.IsNullOrEmpty(nomd) || string.IsNullOrWhiteSpace(nomd))
            {
                MessageBox.Show("Необходимо задать номер документа-основания");
                DialogResult = DialogResult.Cancel;
                return;
            }

            string comments = commentsTextBox.Text;
            double summa = 0.0;
            if(m_idaction == 3 || m_idaction == 4)
            {
                try
                {
                    summa = Convert.ToDouble(sumTextBox.Text);
                }
                catch(Exception)
                {
                    MessageBox.Show("Ошибка задания суммы");
                    DialogResult = DialogResult.Cancel;
                    return;
                }

                string nom = GetNumberActualProxy();
                if (!string.IsNullOrEmpty(nom))
                {
                    MessageBox.Show($"Существует действующая неотозванная доверенность номер {nom}.\nСледует отозвать доверенность.");
                    DialogResult = DialogResult.Cancel;
                    return;
                }

            }
            else if(m_idaction == 1)
            {
                string nom = GetNumberActualProxy();
                if (!string.IsNullOrEmpty(nom))
                {
                    MessageBox.Show($"Существует действующая неотозванная доверенность номер {nom}.\nСледует отозвать доверенность.");
                    DialogResult = DialogResult.Cancel;
                    return;
                }

            }
            else if(m_idaction == 5)
            {
                string nom = GetNumberActualProxy();
                if (!string.IsNullOrEmpty(nom))
                {
                    MessageBox.Show($"Существует действующая неотозванная доверенность номер {nom}.\nСледует отозвать доверенность.");
                    DialogResult = DialogResult.Cancel;
                    return;
                }

            }

            if (Program.m_helper.AddAction(m_idauto, db, de, nomd, m_idaction, comments, summa, m_docContent) < 1)
                DialogResult = DialogResult.Abort;
        }

        /// <summary>
        /// Задать номер неотозванной действующей доверенности в поле ввода номера при отзыве доверенности
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnChoiceProxyNumber(object sender, EventArgs e)
        {
            string nom = GetNumberActualProxy();
            if (string.IsNullOrEmpty(nom))
            {
                MessageBox.Show("Нет неотозванных доверенностей");
            }
            else
                nomTextBox.Text = nom;

        }
        /// <summary>
        /// Получить номер неотозванной действующей доверенности
        /// </summary>
        /// <returns></returns>
        private string GetNumberActualProxy()
        {
            DateTime dt = beginDateTimePicker.Value;
            return Program.m_helper.GetNotTakenProxy(m_idauto, dt);

        }
    }
}
