using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RealtyAgency
{
    public partial class MainForm : Form
    {
        List<string> m_tmpFiles;
        public MainForm()
        {
            InitializeComponent();
            m_tmpFiles = new List<string>();
        }

        private async void OnLoad(object sender, EventArgs e)
        {
            Icon = Properties.Resources.home_32;

            var lst = await Program.m_helper.GetContractList();
            if(Program.m_userrole == 2) // руководитель видит договоры своих подчинённых
            {
                lst = lst.Where(el => el.idchief== Program.m_userid).ToList();
                agentsToolStripMenuItem.Visible = false;
            }
            else if(Program.m_userrole == 3) // агент работает только со своими договорами
            {
                lst = lst.Where(el => el.idagent == Program.m_userid).ToList();
                agentsToolStripMenuItem.Visible = false;
            }
            contractsDataGridView.DataSource = lst;

            var lstr = await Program.m_helper.GetRealtyObjects();            
            realtyDataGridView.DataSource = lstr;

            var lstp = await Program.m_helper.GetPrincipals();
            principalsDataGridView.DataSource = lstp;
        }
        /// <summary>
        /// При закрытии формы: очистка временных файлов,
        /// закрытие соединения с БД, завершение работы приложения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnClose(object sender, FormClosedEventArgs e)
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

            Program.m_helper.Dispose();
            Application.Exit();
        }
        /// <summary>
        /// Добавить запись
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int idx = contractTabControl.SelectedIndex;
            switch(idx)
            {
                case 0:
                    ContractForm contractForm = new ContractForm();
                    if(contractForm.ShowDialog() == DialogResult.OK)
                    {
                        var lst = await Program.m_helper.GetContractList();
                        if (Program.m_userrole == 2) // руководитель видит договоры своих подчинённых
                        {
                            lst = lst.Where(el => el.idchief == Program.m_userid).ToList();
                            agentsToolStripMenuItem.Visible = false;
                        }
                        else if (Program.m_userrole == 3) // агент работает только со своими договорами
                        {
                            lst = lst.Where(el => el.idagent == Program.m_userid).ToList();
                            agentsToolStripMenuItem.Visible = false;
                        }
                        contractsDataGridView.DataSource = lst;
                    }
                    break; 
                case 1:  
                    RealtyForm rfrm = new RealtyForm();
                    if(rfrm.ShowDialog() == DialogResult.OK)
                    {
                        var lst = await Program.m_helper.GetRealtyObjects();
                        realtyDataGridView.DataSource = lst;
                    }
                    break; 
                case 2: 
                    PrincipalForm pfrm = new PrincipalForm();
                    if(pfrm.ShowDialog() == DialogResult.OK)
                    {
                        var lst = await Program.m_helper.GetPrincipals();
                        principalsDataGridView.DataSource = lst;
                    }
                    break;
                default:
                    return;
            }
        }
        /// <summary>
        /// Изменить запись
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int idx = contractTabControl.SelectedIndex;
            switch (idx)
            {
                case 0:
                    var crow = contractsDataGridView.CurrentRow;
                    if(crow != null)
                    {
                        long id = Convert.ToInt64(crow.Cells["id"].Value);

                        ContractForm frm = new ContractForm(id);
                        if(frm.ShowDialog() == DialogResult.OK)
                        {
                            var lst = await Program.m_helper.GetContractList();
                            if (Program.m_userrole == 2) // руководитель видит договоры своих подчинённых
                            {
                                lst = lst.Where(el => el.idchief == Program.m_userid).ToList();
                                agentsToolStripMenuItem.Visible = false;
                            }
                            else if (Program.m_userrole == 3) // агент работает только со своими договорами
                            {
                                lst = lst.Where(el => el.idagent == Program.m_userid).ToList();
                                agentsToolStripMenuItem.Visible = false;
                            }
                            contractsDataGridView.DataSource = lst;
                        }

                    }
                    break;
                case 1:
                    var rrow = realtyDataGridView.CurrentRow;
                    if(rrow != null)
                    {
                        long id = Convert.ToInt64(rrow.Cells["id_r"].Value);
                        RealtyForm rfrm = new RealtyForm(id);
                        if (rfrm.ShowDialog() == DialogResult.OK)
                        {
                            var lst = await Program.m_helper.GetRealtyObjects();
                            realtyDataGridView.DataSource = lst;
                        }

                    }
                    break;
                case 2:
                    var prow = principalsDataGridView.CurrentRow;
                    if (prow != null)
                    {
                        long id = Convert.ToInt64(prow.Cells["id_p"].Value);
                        PrincipalForm rfrm = new PrincipalForm(id);
                        if (rfrm.ShowDialog() == DialogResult.OK)
                        {
                            var lst = await Program.m_helper.GetPrincipals();
                            principalsDataGridView.DataSource = lst;
                        }

                    }

                    break;
                default:
                    return;
            }

        }
        /// <summary>
        /// Удалить запись
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int idx = contractTabControl.SelectedIndex;
            switch (idx)
            {
                case 0:
                    var crow = contractsDataGridView.CurrentRow;
                    if (crow != null)
                    {

                        long id = Convert.ToInt64(crow.Cells["id"].Value);
                       
                        long idagent = Convert.ToInt64(crow.Cells["id"].Value);
                        if (idagent != Program.m_userid && Program.m_userrole != 1)
                        {
                            MessageBox.Show("Можно удалять только свои договоры");
                            return;
                        }

                        string dogName = crow.Cells["Contract"].Value.ToString();
                        if (MessageBox.Show($"Вы удаляете {dogName}.\nЕго невозможно будет восстановить.\nВы действительно хотите удалить договор?", "Внимание!",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
                            return;

                        if (Program.m_helper.DeleteContract(id) > 0)
                        {
                            var lst = await Program.m_helper.GetContractList();
                            if (Program.m_userrole == 2) // руководитель видит договоры своих подчинённых
                            {
                                lst = lst.Where(el => el.idchief == Program.m_userid).ToList();
                                agentsToolStripMenuItem.Visible = false;
                            }
                            else if (Program.m_userrole == 3) // агент работает только со своими договорами
                            {
                                lst = lst.Where(el => el.idagent == Program.m_userid).ToList();
                                agentsToolStripMenuItem.Visible = false;
                            }
                            contractsDataGridView.DataSource = lst;
                        }
                        else
                            Program.ErrorMessageDB();

                    }
                    break;
                case 1:
                    var rrow = realtyDataGridView.CurrentRow;
                    if (rrow != null)
                    {
                        long id = Convert.ToInt64(rrow.Cells["id_r"].Value);
                        if (Program.m_helper.DeleteRealtyObject(id) > 0)
                        {
                            var lst = await Program.m_helper.GetRealtyObjects();
                            realtyDataGridView.DataSource = lst;
                        }
                        else
                            Program.ErrorMessageDB();
                    }
                    break;
                case 2:
                    var prow = principalsDataGridView.CurrentRow;
                    if (prow != null)
                    {
                        long id = Convert.ToInt64(prow.Cells["id_p"].Value);
                        if (Program.m_helper.DeletePrincipal(id) > 0)
                        {
                            var lst = await Program.m_helper.GetPrincipals();
                            principalsDataGridView.DataSource = lst;
                        }
                        else
                            Program.ErrorMessageDB();

                    }
                    break;
                default:
                    return;
            }

        }
        /// <summary>
        /// Управление списком агентов, они же пользоват ели системы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void agentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgentForm agfrm = new AgentForm();
            agfrm.ShowDialog();
        }
        /// <summary>
        /// Изменить свой пароль
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PasswordForm pwdform = new PasswordForm();
            pwdform.ShowDialog();
        }
        /// <summary>
        /// Переход на другую закладку
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnTabDealChanged(object sender, EventArgs e)
        {
            int idx = contractTabControl.SelectedIndex;
            changeStatusToolStripMenuItem.Visible = idx == 0;
            showContentToolStripMenuItem.Visible = idx == 0;
            dealtoolStripSeparator.Visible = idx == 0;

            main_toolStripSeparator.Visible = idx == 0;
            changeStatusContextToolStripMenuItem.Visible = idx == 0;
            showContextToolStripMenuItem.Visible = idx == 0;

        }
        /// <summary>
        /// Изменить статус договора
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void changeStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var crow = contractsDataGridView.CurrentRow;
            if (crow == null)
            {
                MessageBox.Show("Не выбран договор");
                return;
            }
            long id = Convert.ToInt64(crow.Cells["id"].Value);

            ChoiceForm chform = new ChoiceForm('s');
            if(chform.ShowDialog() == DialogResult.OK)
            {
                if(Program.m_helper.SetContractStatus(id, chform.id) < 1)
                    Program.ErrorMessageDB();
                else
                {
                    var lst = await Program.m_helper.GetContractList();
                    if (Program.m_userrole == 2) // руководитель видит договоры своих подчинённых
                    {
                        lst = lst.Where(el => el.idchief == Program.m_userid).ToList();
                        agentsToolStripMenuItem.Visible = false;
                    }
                    else if (Program.m_userrole == 3) // агент работает только со своими договорами
                    {
                        lst = lst.Where(el => el.idagent == Program.m_userid).ToList();
                        agentsToolStripMenuItem.Visible = false;
                    }
                    contractsDataGridView.DataSource = lst;

                }
            }
        }
        /// <summary>
        /// Показать содержимое договора
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void showContentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var crow = contractsDataGridView.CurrentRow;
            if (crow == null)
            {
                MessageBox.Show("Не выбран договор");
                return;
            }
            long id = Convert.ToInt64(crow.Cells["id"].Value);
            Content m_content = await Program.m_helper.DownLoadContractContent(id);
            if(m_content == null) 
            {
                MessageBox.Show("Неудача отображения содержания договора\nлибо содержание не было загружено");
                return;
            }

            string tmpPath = System.IO.Path.GetTempPath();
            DateTime now = DateTime.Now;
            string fileName = "RealtyAgencyContract_" + now.ToString("yyyyMMddHHmmss");
            if (m_content.content[0] != 0)
            {
                if (m_content.content.Length < 2 && m_content.content[0] == 0)
                {
                    MessageBox.Show("Текст договора отсутствует");
                }
                fileName = tmpPath + fileName + (string.IsNullOrEmpty(m_content.contenttype) ? string.Empty : "." + m_content.contenttype);
                await Task.Run(() => { System.IO.File.WriteAllBytes(fileName, m_content.content); });
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
    }
}
