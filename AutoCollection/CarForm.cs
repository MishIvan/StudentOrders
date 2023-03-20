using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoCollection
{
    /// <summary>
    /// Форма для добавления или правки записи об авто
    /// </summary>
    public partial class CarForm : Form
    {
        private long m_id; // идентификатор записи авто
        public CarForm(long id = 0)
        {
            InitializeComponent();
            m_id = id;
        }

        /// <summary>
        /// Первоначальняа загрузка формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnLoad(object sender, EventArgs e)
        {
            if(m_id > 0)
            {
                Auto car = Program.m_helper.GetAutoByID(m_id);
                if(car != null)
                {
                    nameTextBox.Text = car.name;
                    kmTextBox.Text = car.kilometrage.ToString();
                    priceTextBox.Text = car.price.ToString();
                    yearTextBox.Text = car.relyear.ToString();
                }
            }
        }
        /// <summary>
        /// Добавление записи (внесение исправлений в параметры записи)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnOKClick(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;
            
            if(string.IsNullOrEmpty(name) || string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Наименование авто не должно быть пустым"); return;
            }
            double km = 0.0;
            try
            {
                km = Convert.ToDouble(kmTextBox.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Ошибка задания пробега: {ex.Message}"); return;
            }

;           if(m_id > 0)
            {

            }
        }
        /// <summary>
        /// Не добавлять (не править параметры) записи
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnCancelClick(object sender, EventArgs e)
        {

        }
    }
}
