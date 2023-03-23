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
    public partial class MainForm : Form
    {
        private bool m_showClosed;
        public MainForm()
        {
            InitializeComponent();
            m_showClosed = false;

        }

        /// <summary>
        /// Первоначальная загрузка формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void MainForm_Load(object sender, EventArgs e)
        {
            var alst =
            await Program.m_helper.GetAutoList();
            autoDataGridView.DataSource = alst;
        }
        /// <summary>
        /// Добавление записи об авто в коллекцию
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void addAutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CarForm frm = new CarForm();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                var alst =
                await Program.m_helper.GetAutoList(filterTextBox.Text, m_showClosed);
                autoDataGridView.DataSource = alst;
            }
        }
        // При закрытии приложения закрыть соединение с БД
        private void OnClose(object sender, FormClosedEventArgs e)
        {
            Program.m_helper.Dispose(); // закрыть соединение с БД
        }
        /// <summary>
        /// Править параметры записи об авто
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void editAutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var row = autoDataGridView.CurrentRow;
            if (row == null) return;
            long id = Convert.ToInt64(row.Cells[0].Value);
            if (id > 0)
            {
                CarForm frm = new CarForm(id);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    var alst =
                    await Program.m_helper.GetAutoList(filterTextBox.Text, m_showClosed);
                    autoDataGridView.DataSource = alst;
                }

            }
        }
        /// <summary>
        /// Применть фильтр выборки по наименованию
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void OnSetFilter(object sender, EventArgs e)
        {
            var alst =
            await Program.m_helper.GetAutoList(filterTextBox.Text, m_showClosed);
            autoDataGridView.DataSource = alst;

        }
        /// <summary>
        /// Применение фильтра по наименованию выборки коллекции авто при нажатии ENTER
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void filterTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                OnSetFilter(sender, e);
        }
        /// <summary>
        /// Удалить запись об авто
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void delAutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var row = autoDataGridView.CurrentRow;
            if (row == null) return;
            long id = Convert.ToInt64(row.Cells[0].Value);
            if (id > 0)
            {
                if (Program.m_helper.DeleteAuto(id) < 1)
                {
                    MessageBox.Show($"Ошибка: {Program.m_helper.errorText}");
                }
                else
                {
                    OnSetFilter(sender, e);
                }
            }
        }
        /// <summary>
        /// Выдача доверенности на авто
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void giveproxyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var row = autoDataGridView.CurrentRow;
            if (row == null) return;
            long id = Convert.ToInt64(row.Cells[0].Value);
            if (id > 0)
            {
                ActionForm frm = new ActionForm(id, 1);
                if (frm.ShowDialog() == DialogResult.Abort)
                {
                    MessageBox.Show($"Ошибка: {Program.m_helper.errorText}");
                }
            }

        }
        /// <summary>
        /// Показать все действия для выбранного авто
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void showActionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var row = autoDataGridView.CurrentRow;
            if (row == null) return;
            long id = Convert.ToInt64(row.Cells[0].Value);
            if (id > 0)
            {
                ActionViewForm frm = new ActionViewForm(id, m_showClosed);
                frm.ShowDialog();
            }
        }
        /// <summary>
        /// Отзыв доверенности на авто
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void takeproxyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var row = autoDataGridView.CurrentRow;
            if (row == null) return;
            long id = Convert.ToInt64(row.Cells[0].Value);
            if (id > 0)
            {
                ActionForm frm = new ActionForm(id, 2);
                if (frm.ShowDialog() == DialogResult.Abort)
                {
                    MessageBox.Show($"Ошибка: {Program.m_helper.errorText}");
                }
            }

        }
        /// <summary>
        /// Ремонт авто
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void repairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var row = autoDataGridView.CurrentRow;
            if (row == null) return;
            long id = Convert.ToInt64(row.Cells[0].Value);
            if (id > 0)
            {
                ActionForm frm = new ActionForm(id, 3);
                DialogResult res = frm.ShowDialog();
                if (res == DialogResult.Abort)
                {
                    MessageBox.Show($"Ошибка: {Program.m_helper.errorText}");
                }
                else if (res == DialogResult.OK)
                {
                    var alst =
                    await Program.m_helper.GetAutoList(filterTextBox.Text);
                    autoDataGridView.DataSource = alst;

                }
            }

        }
        /// <summary>
        /// Продажа ато
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void sailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var row = autoDataGridView.CurrentRow;
            if (row == null) return;
            long id = Convert.ToInt64(row.Cells[0].Value);
            if (id > 0)
            {
                ActionForm frm = new ActionForm(id, 4);
                DialogResult res = frm.ShowDialog();
                if (res == DialogResult.Abort)
                {
                    MessageBox.Show($"Ошибка: {Program.m_helper.errorText}");
                }
                else if(res == DialogResult.OK)
                {
                    var alst =
                    await Program.m_helper.GetAutoList(filterTextBox.Text);
                    autoDataGridView.DataSource = alst;

                }

            }

        }
        /// <summary>
        /// Дарение авто
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void giftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var row = autoDataGridView.CurrentRow;
            if (row == null) return;
            long id = Convert.ToInt64(row.Cells[0].Value);
            if (id > 0)
            {
                ActionForm frm = new ActionForm(id, 5);
                DialogResult res = frm.ShowDialog();
                if (res == DialogResult.Abort)
                {
                    MessageBox.Show($"Ошибка: {Program.m_helper.errorText}");
                }
                else if (res == DialogResult.OK)
                {
                    var alst =
                    await Program.m_helper.GetAutoList(filterTextBox.Text);
                    autoDataGridView.DataSource = alst;

                }
            }

        }
        /// <summary>
        /// Показ закрытых записей
        /// Запись закрывается при продаже или дарении авто
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void showRecsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            actionToolStripMenuItem.Visible = m_showClosed;
            addAutoToolStripMenuItem.Visible = m_showClosed;
            editAutoToolStripMenuItem.Visible = m_showClosed;
            delAutoToolStripMenuItem.Visible = m_showClosed;
            showRecsToolStripMenuItem.Text = !m_showClosed ? "Показать действующие записи" : "Показать скрытые записи";
            m_showClosed = !m_showClosed;
            var alst =
            await Program.m_helper.GetAutoList(filterTextBox.Text, m_showClosed);
            autoDataGridView.DataSource = alst;

        }
    }
}
