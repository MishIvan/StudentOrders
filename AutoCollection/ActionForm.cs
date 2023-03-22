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

        }
        /// <summary>
        /// Загрузка скана документа
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
                    //Get the path of specified file
                    string filePath = openFileDialog.FileName;
                    string ext = string.Empty;
                    if (Path.HasExtension(filePath))
                    {
                        ext = Path.GetExtension(filePath).Substring(1).ToLower();
                    }
                    byte[] m_docContent = File.ReadAllBytes(filePath);
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
        }
    }
}
