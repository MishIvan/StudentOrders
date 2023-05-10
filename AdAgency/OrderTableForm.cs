using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdAgency
{
    public partial class OrderTableForm : Form
    {
        private string m_service_name;
        public string service_name { get { return m_service_name; } }
        private int m_service_id;
        public int service_id { get { return m_service_id; } }
        private double m_count;
        public double count { get { return m_count; } }
        private double m_price;
        public double price { get { return m_price; } }
        private string m_ordernum;
        public OrderTableForm(string orderNum)
        {
            InitializeComponent();
            m_ordernum = orderNum;
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            int idx = serviceComboBox.SelectedIndex;
            if(idx >=0)
            {
                AdService svc = serviceComboBox.Items[idx] as AdService;
                if(svc != null)
                {
                    m_service_name = svc.sname;
                    m_service_id = svc.id;
                }
            }

            try 
            {
                m_count = Convert.ToDouble(countTextBox.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Неверно задано значение количества");
                DialogResult = DialogResult.Cancel;
                return;
            }

            try
            {
                m_price = Convert.ToDouble(priceTextBox.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Неверно задано значение суммы");
                DialogResult = DialogResult.Cancel;
                return;
            }
        }

        private async void OnLoad(object sender, EventArgs e)
        {
            List<AdService> lst = await Program.m_helper.GetAdServices();
            serviceComboBox.DataSource = lst;
        }
    }
}
