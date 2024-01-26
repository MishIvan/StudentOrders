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
    public partial class ServicesForm : Form
    {
        long m_id;
        /// <summary>
        ///  Конструктор формы
        /// </summary>
        public ServicesForm()
        {
            InitializeComponent();
            m_id = 0;
        }

        private async void OnLoad(object sender, EventArgs e)
        {
            Icon = Properties.Resources.list_23;

            List<Service> refs = await Program.m_helper.GetServices();
            if (!refs.IsNullOrEmpty())
            {
                records_listBox.DataSource = refs;
                records_listBox.SelectedIndex = 0;
                /*Service _ref = records_listBox.Items[0] as Service;
                if (_ref != null)
                {
                    name_textBox.Text = _ref.name;
                    cost_textBox.Text = _ref.summa.ToString();
                    m_id = _ref.id;
                }*/
            }
            else
            {
                records_listBox.DataSource=null;
                name_textBox.Text = string.Empty; 
                cost_textBox.Text = string.Empty;
            }

        }
        /// <summary>
        /// Кнопка Добавить (в режиме выбора 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void add_button_Click(object sender, EventArgs e)
        {
            string _name = name_textBox.Text;
            double s = 0.0;
            try
            {
                s = Convert.ToDouble(cost_textBox.Text);
            }
            catch 
            {
                Program.ShowErrorMessage("Неверный формат числа");
                return;
            }
            Service svc = new Service
            {
                name = _name,
                id = 0,
                summa = s
            };
            int recs = Program.m_helper.AddService(svc);
            if (recs < 1)
                Program.DBErrorMessage();
            else
            {
                List<Service> refs = await Program.m_helper.GetServices();
                if (!refs.IsNullOrEmpty())
                {
                    records_listBox.DataSource = refs;
                    int idx = records_listBox.FindString(_name);
                    if (idx < 0) records_listBox.SelectedIndex = idx;
                }

            }

        }
        /// <summary>
        /// Нажата кнопка Изменить (в режиме выбора Отмена)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void edit_button_Click(object sender, EventArgs e)
        {
            string _name = name_textBox.Text;
            double s = 0.0;
            try
            {
                s = Convert.ToDouble(cost_textBox.Text);
            }
            catch
            {
                Program.ShowErrorMessage("Неверный формат числа");
                return;
            }
            Service svc = new Service
            {
                name = _name,
                id = m_id,
                summa = s
            };

            int recs = Program.m_helper.UpdateService(svc);
            if (recs < 1)
                Program.DBErrorMessage();
            else
            {
                List<Service> refs = await Program.m_helper.GetServices();
                if (!refs.IsNullOrEmpty())
                {
                    records_listBox.DataSource = refs;
                    int idx = records_listBox.FindString(_name);
                    if (idx >= 0) records_listBox.SelectedIndex = idx;
                }

            }

        }

        /// <summary>
        /// Нажата кнопка Удалить (в режиме выбора скрыта)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void delete_button_Click(object sender, EventArgs e)
        {
            int idx = records_listBox.SelectedIndex;
            if (idx < 0) return;
            Service _ref = records_listBox.Items[idx] as Service;
            if (_ref != null)
            {
                m_id = _ref.id;
                int recs = Program.m_helper.DeleteService(m_id);
                if (recs < 1)
                    Program.DBErrorMessage();
                else
                {
                    List<Service> refs = await Program.m_helper.GetServices();
                    records_listBox.DataSource = refs;
                    if (!refs.IsNullOrEmpty())
                    {
                        records_listBox.SelectedIndex = 0;
                    }

                }

            }


        }

        /// <summary>
        /// Переход по записям справочника: изменить значение в поле ввода
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnRecordIndexChanged(object sender, EventArgs e)
        {
            int idx = records_listBox.SelectedIndex;
            if (idx < 0) return;
            Service _ref = records_listBox.Items[idx] as Service;
            if (_ref != null)
            {
                name_textBox.Text = _ref.name;
                m_id = _ref.id;
                cost_textBox.Text = _ref.summa.ToString();
            }

        }

        private void OnKeyPressCost(object sender, KeyPressEventArgs e)
        {
            e.Handled = !((e.KeyChar >= (char)Keys.D0 && e.KeyChar <= (char)Keys.D9) 
                || (e.KeyChar == (char)Keys.Back)
                || (e.KeyChar == (char)Keys.Oemcomma));
        }
    }
}
