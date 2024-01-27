using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HorseClub
{
    public partial class CalcSummaForm : Form
    {
        long m_id;
        double m_dayprice;
        double m_serviceprice;
        long m_idservice;
        long m_idclient;
        int m_imonth;
        double m_summa = 0.0;

        public CalcSummaForm(long id = 0)
        {
            InitializeComponent();
            m_id = id; 
            m_dayprice = 0.0;
            m_serviceprice = 0.0;
            m_idclient = 0;
            m_idservice = 0;
            m_imonth = 0;

            for (int i = 1; i < 13; i++)
                month_comboBox.Items.Add(new Month(i));

        }

        private async void OnLoad(object sender, EventArgs e)
        {
            Icon = Properties.Resources.money_32;

            var lstc = await Program.m_helper.GetSimpleRefRecords();
            client_comboBox.DataSource = lstc;

            var lsts = await Program.m_helper.GetServices();
            service_comboBox.DataSource = lsts;

            if (m_id > 0)
            {
                Visit vis = Program.m_helper.GetVisitById(m_id);
                if(vis != null) 
                {
                    month_comboBox.SelectedIndex = vis.month - 1;

                    int idx = FindIndexByIdObject(vis.idclient, client_comboBox);
                    if(idx != -1)
                        client_comboBox.SelectedIndex = idx;

                    idx = FindIndexByIdObject(vis.idservice, service_comboBox);
                    if(idx != -1)
                        service_comboBox.SelectedIndex = idx;

                    year_maskedTextBox.Text = vis.year.ToString();
                    days_count_textBox.Text = vis.days.ToString();
                    summa_textBox.Text = vis.summa.ToString();

                }
                else
                    Program.DBErrorMessage();
            }
            else 
            {
                month_comboBox.SelectedIndex = DateTime.Now.Month - 1;
                year_maskedTextBox.Text = DateTime.Now.Year.ToString();
                if (!lstc.IsNullOrEmpty()) client_comboBox.SelectedIndex = 0;
                if(!lsts.IsNullOrEmpty()) service_comboBox.SelectedIndex = 0;

            }
        }
        /// <summary>
        /// установить индекс списков клиентов или служб
        /// </summary>
        /// <param name="id">идентификатор записи объекта</param>
        /// <param name="cb">выпадающий список</param>
        /// <returns>индекс в списке</returns>
        private int FindIndexByIdObject(long id, ComboBox cb)
        {
            int idx = -1;
            int n = cb.Items.Count;
            for(int i = 0; i < n; i++)
            {
                SimpleRef _ref = cb.Items[i] as SimpleRef;
                if(_ref != null)
                {
                    if(_ref.id == id) { idx = i; break; }
                }
            }
            return idx;
        }
        /// <summary>
        /// Изменился месяц: установить оплату за месяц
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void OnMonthChanged(object sender, EventArgs e)
        {
            int idx = month_comboBox.SelectedIndex;
            if (idx < 0) return;
            Month month = month_comboBox.Items[idx] as Month;
            if(month != null) 
            {
                m_dayprice = await Program.m_helper.GetSummaForDay(month.imonth, true);
                m_imonth = month.imonth;
                day_price_textBox.Text = m_dayprice.ToString();
            }
        }
        /// <summary>
        /// Изменилась дополнительня услуга
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnServiceChanged(object sender, EventArgs e)
        {
            int idx = service_comboBox.SelectedIndex;
            if (idx < 0) return;
            Service service = service_comboBox.Items[idx] as Service;
            if (service != null) 
            {
                m_serviceprice = service.summa;
                m_idservice = service.id;
            }
        }

        /// <summary>
        /// Изменился клиент
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnClientChanged(object sender, EventArgs e)
        {
            int idx = client_comboBox.SelectedIndex;
            if (idx < 0) return;
            SimpleRef _ref = client_comboBox.Items[idx] as SimpleRef; 
            if (_ref != null) 
            { 
                m_idclient = _ref.id;
            }
        }

        /// <summary>
        /// Вычислить значение суммы оплаты 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnCalculate(object sender, EventArgs e)
        {
            int days = -1;
            try
            {
                days = Convert.ToInt32(days_count_textBox.Text);
            }
            catch 
            {
                Program.ShowErrorMessage("Неверный формат числа");
                return;
            }
            m_summa = m_dayprice * days + m_serviceprice;
            summa_textBox.Text = m_summa.ToString();

        }

        /// <summary>
        /// Сохранить и выйти
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnSave(object sender, EventArgs e)
        {
            Visit visit = new Visit();
            int year = 0;
            try
            {
                year = Convert.ToInt32(year_maskedTextBox.Text);
            }
            catch 
            {
                Program.ShowErrorMessage("Год задан неверно");
                return;
            }

            int days = 0;
            try
            {
                days = Convert.ToInt32(days_count_textBox.Text);
            }
            catch 
            {
                Program.ShowErrorMessage("Число дней задано неверно");
                return;
            }

            int dm = DateTime.DaysInMonth(year, m_imonth);
            if(days < 0 ||  days > dm)
            {
                Program.ShowErrorMessage("Число дней задано неверно");
                return;
            }

            visit.id = m_id > 0 ? m_id : 0;
            visit.idclient = m_idclient;
            visit.idservice = m_idservice;
            visit.month = m_imonth;
            visit.year = year;
            visit.days = days;
            visit.summa = m_summa;

            int recs = -1;
            if (m_id == 0)
                recs = Program.m_helper.AddVisitRecord(visit);
            else
                recs = Program.m_helper.UpdateVisitRecord(visit);

            if (recs < 1)
            {
                Program.DBErrorMessage();
                DialogResult = DialogResult.Cancel;
            }
            else
                DialogResult = DialogResult.OK;
            Close();
        }

        /// <summary>
        /// В поле ввода ней вводить только числа
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnDaysKeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !((e.KeyChar >= (char)Keys.D0 && e.KeyChar <= (char)Keys.D9)
                || (e.KeyChar == (char)Keys.Back)  || (e.KeyChar == (char)Keys.Delete) );

        }
    }
}
