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
        private Image m_img;
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
            m_fileName = tempPath + "docContent " + DateTime.Now.ToString("_yyyyMMdd_hh_mm_ss_fff") + ".png";
            System.IO.File.WriteAllBytes(m_fileName, m_content);
            m_img = Image.FromFile(m_fileName);
            contentPictureBox.Image = m_img;
        }
        /// <summary>
        /// закрывать просмотр по ESC
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
                Close();
        }

        private void OnClose(object sender, FormClosedEventArgs e)
        {
            m_img.Dispose();
            System.IO.File.Delete(m_fileName);
        }
    }
}
 