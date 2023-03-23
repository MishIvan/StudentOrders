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
    /// Форма отображения совершённых действий для выбранного авто
    /// </summary>
    public partial class ActionViewForm : Form
    {
        private long m_idauto; // идентификатор авто
        List<Actions> m_actionList;
        bool m_showClosed;
        public ActionViewForm(long idauto, bool showClosed = false)
        {
            InitializeComponent();
            m_idauto = idauto;
            m_actionList = null;
            m_showClosed = showClosed;
        }
        /// <summary>
        /// Инициализация формы, присвоение значений элементам управления, заполнение списка действий 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnLoad(object sender, EventArgs e)
        {
            Auto car = Program.m_helper.GetAutoByID(m_idauto);
            if(car != null)
             autoNameLabel.Text = (string.IsNullOrEmpty(car.govnum) || string.IsNullOrWhiteSpace(car.govnum) ? "" : car.govnum + " ") + car.name;

            m_actionList = Program.m_helper.GetActionsListForAuto(m_idauto);
            actionDataGridView.DataSource = m_actionList;

            delButton.Enabled = !m_showClosed;

        }
        /// <summary>
        /// Показать документ-основание выбранного события
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnShowContent(object sender, EventArgs e)
        {
            var row = actionDataGridView.CurrentRow;
            if (row == null) return;
            long idaction = Convert.ToInt32(row.Cells[0].Value);
            Actions car = m_actionList.Where(a => a.id == idaction).FirstOrDefault();
            if (car != null)
            {
                byte[] bts = car.doc;
                if (bts == null) return;
                if (bts.Length < 2) return;
                ContentForm frm = new ContentForm(bts);
                frm.ShowDialog();
            }

        }
        /// <summary>
        /// Удалить выбранное действие
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnDeleteAction(object sender, EventArgs e)
        {
            var row = actionDataGridView.CurrentRow;
            if (row == null) return;
            long idaction = Convert.ToInt32(row.Cells[0].Value);

            if (Program.m_helper.DeleteAction(idaction, m_idauto) < 1)
            {
                string msg = $"Ошибка.\nНе удалолось удалить действие: {Program.m_helper.errorText}";
            }
            else
            {
                m_actionList = Program.m_helper.GetActionsListForAuto(m_idauto);
                actionDataGridView.DataSource = m_actionList;
            }
        }
        /// <summary>
        /// Закрыть форму по ESC
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
                Close();
        }
        /// <summary>
        /// Отобразить комментарии и получить идентификатор действия
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnCangedRow(object sender, EventArgs e)
        {
            if (actionDataGridView.Rows.Count > 0)
            {
                var row = actionDataGridView.CurrentRow;
                if (row == null) return;
                long idaction = Convert.ToInt32(row.Cells[0].Value);
                Actions car = m_actionList.Where(a => a.id == idaction).FirstOrDefault();
                if (car != null)
                {
                    commentsTextBox.Text = car.comments;
                }
            }

        }
    }
}
