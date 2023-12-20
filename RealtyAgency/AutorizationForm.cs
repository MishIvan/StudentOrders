using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RealtyAgency
{
    public partial class AutorizationForm : Form
    {
        private int m_counter;
        public AutorizationForm()
        {
            InitializeComponent();
            m_counter = 0;
        }

        private async void OnLoad(object sender, EventArgs e)
        {
            Icon = Properties.Resources.password_32;
            List<Agent> agents = await Program.m_helper.GetAgents();
            agentsComboBox.DataSource = agents;
            agentsComboBox.SelectedIndex = 0;
        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            Program.m_helper.Dispose();
            Application.Exit();
        }

        private void OK_Button_Click(object sender, EventArgs e)
        {
            int idx = agentsComboBox.SelectedIndex;
            if (idx >= 0)
            {
                Agent agent = agentsComboBox.Items[idx] as Agent;
                if (agent != null) 
                { 
                    string pwd = passwordTextBox.Text;
                    if (pwd != agent.password && !string.IsNullOrEmpty(agent.password)) 
                    {
                        m_counter++;
                        MessageBox.Show("Неверный пароль", "Ошибка");
                        if(m_counter==3)
                        {
                            Close();
                            Program.m_helper.Dispose();
                            Application.Exit();
                        }
                    }
                    else
                    {
                        Program.m_username = agent.name;
                        Program.m_userid = agent.id;
                        if (Program.m_username == "Администратор")
                            Program.m_userrole = 1;
                        else 
                        {
                            Program.m_userrole = agent.idchief.HasValue ? 2 : 3;
                        }
                       
                        MainForm frm = new MainForm();
                        frm.Text = $"Риэлторское агентство - {Program.m_username}";
                        frm.Show();
                        Hide();
                    }
                }
            }
        }
    }
}
