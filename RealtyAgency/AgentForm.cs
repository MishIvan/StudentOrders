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
        List<Agent> m_agents;
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

        }

        private void OnAgentChanged(object sender, EventArgs e)
        {
            int idx = nameComboBox.SelectedIndex;
            if(idx >= 0)
            {
                Agent agent = nameComboBox.Items[idx] as Agent;
                if(agent != null) 
                {
                    chiefCheckBox.Checked = !agent.idchief.HasValue;
                    chiefComboBox.Enabled = !agent.idchief.HasValue;
                }
            }
        }
    }
}
