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
    /// <summary>
    /// диалог выбора принципала, агента или объекта недвижимомти при составлении договора
    /// </summary>
    public partial class ChoiceForm : Form
    {
        long m_id;
        char m_who; // 'p' - принципал, 'a' - агент, 'r' - объект недвижимости 
        public long id { get { return m_id; } }
        public ChoiceForm(char who = 'p')
        {
            InitializeComponent();
            m_who = who;
            m_id = 0;
        }

        private async void OnLoad(object sender, EventArgs e)
        {
            Icon = Properties.Resources.choice_32;
            object lst = null;
            switch(m_who)
            {
                case 'p':
                    lst = await Program.m_helper.GetPrincipals();
                    choice_listBox.DataSource = lst;
                    break;
                case 'a': 
                    List<Agent> m_agents = await Program.m_helper.GetAgents();
                    lst = m_agents.Where(el => el.id > 1).ToList();
                    break;
                case 'r':
                    lst = await Program.m_helper.GetRealtyObjects();
                    break;
                default:
                    Close();
                    return;
            }
            choice_listBox.DataSource = lst;
        }

        private void OnOK(object sender, EventArgs e)
        {
            int idx = choice_listBox.SelectedIndex; 
            if (idx < 0) { DialogResult = DialogResult.Cancel; return; }
            switch (m_who)
            {
                case 'p':
                    Principal pr = choice_listBox.Items[idx] as Principal;
                    if(pr != null)
                    {
                        m_id = pr.id;
                    }
                    else
                    {
                        m_id = 0;
                        DialogResult = DialogResult.Cancel;
                    }
                    break;
                case 'a':
                    Agent ag = choice_listBox.Items[idx] as Agent;
                    if (ag != null)
                    {
                        m_id = ag.id;
                    }
                    else
                    {
                        m_id = 0;
                        DialogResult = DialogResult.Cancel;
                    }
                    break;
                case 'r':
                    RealtyObject ro = choice_listBox.Items[idx] as RealtyObject;
                    if (ro != null)
                    {
                        m_id = ro.id;
                    }
                    else
                    {
                        m_id = 0;
                        DialogResult = DialogResult.Cancel;
                    }
                    break;
                default:
                    m_id = 0;
                    DialogResult = DialogResult.Cancel;
                    return;
            }
        }
    }
}
