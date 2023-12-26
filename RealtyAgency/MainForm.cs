using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RealtyAgency
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
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
                lst = lst.Where(el => el.id == Program.m_userid).ToList();
                agentsToolStripMenuItem.Visible = false;
            }
            contractsDataGridView.DataSource = lst;

            var lstr = await Program.m_helper.GetRealtyObjects();            
            realtyDataGridView.DataSource = lstr;

            var lstp = await Program.m_helper.GetPrincipals();
            principalsDataGridView.DataSource = lstp;
        }

        private void OnClose(object sender, FormClosedEventArgs e)
        {
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
                        contractsDataGridView.DataSource= lst;
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
                        string dogName = crow.Cells["Contract"].Value.ToString();
                        if (MessageBox.Show($"Вы удаляете {dogName}.\nЕго невозможно будет восстановить.\nВы действительно хотите удалить договор?","Внимание!",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
                            return;

                        long id = Convert.ToInt64(crow.Cells["id"].Value);
                        if (Program.m_helper.DeleteContract(id) > 0)
                        {
                            var lst = await Program.m_helper.GetContractList();
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
            showContentДоговораToolStripMenuItem.Visible = idx == 0;

        }
    }
}
