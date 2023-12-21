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
    public partial class AgentForm : Form
    {
        private List<Agent> m_agents;
        public AgentForm()
        {
            InitializeComponent();
        }

        private async void OnLoad(object sender, EventArgs e)
        {
            Icon = Properties.Resources.person_32;
            var lst = await Program.m_helper.GetAgents();
            m_agents = lst.Where( el => el.id > 1).ToList();
            nameComboBox.DataSource = m_agents;

            chiefComboBox.DataSource = m_agents.Where(el => !el.idchief.HasValue).ToList();

        }
        /// <summary>
        /// Изменение выбора агента в списке
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnAgentChanged(object sender, EventArgs e)
        {
            int idx = nameComboBox.SelectedIndex;
            if(idx >= 0)
            {
                Agent agent = nameComboBox.Items[idx] as Agent;
                if(agent != null) 
                {
                    chiefCheckBox.Checked = !agent.idchief.HasValue;
                    chiefComboBox.Visible = agent.idchief.HasValue;
                    chiefHeaderLabel.Visible = agent.idchief.HasValue;

                    phoneMaskedTextBox.Text = agent.phone;
                    emailTextBox.Text = agent.email; 
                    passwordTextBox.Text = agent.password;
                    if(agent.idchief.HasValue) // просто агент
                    {
                        int chief_idx = -1;
                        foreach(var item in chiefComboBox.Items)
                        {
                            Agent chief = item as Agent;
                            chief_idx++;
                            if(chief != null)
                            {
                                if (chief.id == agent.idchief) break;
                            }
                        }

                        if(chief_idx >=0 && chief_idx < chiefComboBox.Items.Count)
                            chiefComboBox.SelectedIndex = chief_idx;
                    }
                }
            }
        }
        /// <summary>
        /// Добавить запись
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void addButton_Click(object sender, EventArgs e)
        {
            long? _idchief = null;
            bool isChief = chiefCheckBox.Checked;
            if (!isChief) // агент - не руководитель
            {
                int idx = chiefComboBox.SelectedIndex;
                if (idx >= 0)
                {
                    Agent chief = chiefComboBox.Items[idx] as Agent;
                    if(chief != null)
                    {
                        _idchief = chief.id;
                    }
                }
            }

            Agent agent = new Agent()
            {
                id = 0,
                name = nameComboBox.Text,
                email = emailTextBox.Text,
                phone = phoneMaskedTextBox.Text,
                password = passwordTextBox.Text,
                idchief = _idchief
            };

            long id = Program.m_helper.AddAgent(agent);
            if (id < 1)
                Program.ErrorMessageDB();
            else // если запись добавлена, обновить списки
            {
                var lst = await Program.m_helper.GetAgents();
                m_agents = lst.Where(el => el.id > 1).ToList();
                nameComboBox.DataSource = m_agents;
                if(isChief)
                    chiefComboBox.DataSource = m_agents.Where(el => !el.idchief.HasValue).ToList();

            }
        }
        /// <summary>
        /// Изменить запись
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void editButton_Click(object sender, EventArgs e)
        {
            long? _idchief = null;
            bool isChief = chiefCheckBox.Checked;
            int idx = nameComboBox.SelectedIndex;
            if (idx < 0) return;
            Agent agent = nameComboBox.Items[idx] as Agent;
            if(agent == null) return;   

            if (!isChief) // агент - не руководитель
            {
                idx = chiefComboBox.SelectedIndex;
                if (idx >= 0)
                {
                    Agent chief = chiefComboBox.Items[idx] as Agent;
                    if (chief != null)
                    {
                        _idchief = chief.id;
                    }
                }
            }

            agent.name = nameComboBox.Text;
            agent.email = emailTextBox.Text;
            agent.phone = phoneMaskedTextBox.Text;
            agent.password = passwordTextBox.Text;
            agent.idchief = _idchief;
            

            long id = Program.m_helper.UpdateAgent(agent);
            if (id < 1)
                Program.ErrorMessageDB(); 
            else // если запись добавлена, обновить списки
            {
                var lst = await Program.m_helper.GetAgents();
                m_agents = lst.Where(el => el.id > 1).ToList();
                nameComboBox.DataSource = m_agents;
                if (isChief)
                    chiefComboBox.DataSource = m_agents.Where(el => !el.idchief.HasValue).ToList();

            }

        }
        /// <summary>
        /// Удалить запись 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void deleteButton_Click(object sender, EventArgs e)
        {
            int idx = nameComboBox.SelectedIndex;
            if (idx < 0) return;
            Agent agent = nameComboBox.Items[idx] as Agent;
            if (agent == null) return;

            long id = Program.m_helper.DeleteAgent(agent.id);
            if (id < 1)
                Program.ErrorMessageDB();
            else // если запись добавлена, обновить списки
            {
                var lst = await Program.m_helper.GetAgents();
                m_agents = lst.Where(el => el.id > 1).ToList();
                nameComboBox.DataSource = m_agents;
                if (chiefCheckBox.Checked)
                    chiefComboBox.DataSource = m_agents.Where(el => !el.idchief.HasValue).ToList();

            }

        }

        private void chiefCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            chiefComboBox.Visible = !chiefCheckBox.Checked;
            chiefHeaderLabel.Visible = !chiefCheckBox.Checked;

        }
    }
}
