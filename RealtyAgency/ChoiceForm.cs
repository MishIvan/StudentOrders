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
        char m_who; // 'p' - принципал, 'r' - объект недвижимости, 's' - статус сделки
        string m_name;
        double m_summ;

        public long id { get { return m_id; } }
        public string name { get { return m_name; } }
        public double summ { get { return m_summ; } }

        public ChoiceForm(char who = 'p')
        {
            InitializeComponent();
            m_who = who;
            m_id = 0;
            m_name = string.Empty;
        }

        private async void OnLoad(object sender, EventArgs e)
        {
            Icon = Properties.Resources.choice_32;
            object lst = null;
            switch(m_who)
            {
                case 'p':
                    Text = "Выбор принципала";
                    lst = await Program.m_helper.GetPrincipals();
                    choice_listBox.DataSource = lst;
                    break;
                case 's':
                    Text = "Выбор статуса сделки";
                    lst = await Program.m_helper.GetContractStalusList();
                    choice_listBox.DataSource = lst;
                    break;
                case 'r':
                    Text = "Выбор объекта недвижимости";
                    List<RealtyObject> m_realty = await Program.m_helper.GetRealtyObjects();
                    lst = m_realty.Where(el => !el.deal).ToList();
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
                        m_name = pr.name;
                    }
                    else
                    {
                        m_id = 0;
                        DialogResult = DialogResult.Cancel;
                    }
                    break;
                case 's':
                    Simple status = choice_listBox.Items[idx] as Simple;
                    if(status != null)
                    {
                        m_id = status.id;
                        m_name = status.name;

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
                        m_name = ro.ToString();
                        m_summ = ro.rsumma * ro.full_square;
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
