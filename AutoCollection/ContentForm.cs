using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoCollection
{
    /// <summary>
    /// Форма показа контента
    /// </summary>
    public partial class ContentForm : Form
    {
        private byte[] m_content;
        private string m_fileName;
        public ContentForm(byte [] content)
        {
            InitializeComponent();
            m_content = content;
        }
        /// <summary>
        /// Загрузка контента
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnLoad(object sender, EventArgs e)
        {
            string tempPath = System.IO.Path.GetTempPath();
            m_fileName = tempPath + "docContent " + DateTime.Now.ToString("_yyyyMMdd_hh_mm_ss") + ".png";
            System.IO.File.WriteAllBytes(m_fileName, m_content);
            contentPictureBox.Image = Image.FromFile(m_fileName);

        }
        // При закрытии формы удалить временный файл
        private void OnClose(object sender, FormClosedEventArgs e)
        {
            System.IO.File.Delete(m_fileName);
        }
    }
}
 