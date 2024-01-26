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
    public partial class DayVisitPriceForm : Form
    {
        public DayVisitPriceForm()
        {
            InitializeComponent();
        }

        private async void OnSeasonChanged(object sender, EventArgs e)
        {
            int idx = season_comboBox.SelectedIndex;
            if (idx < 0) return;
            double sum = await Program.m_helper.GetSummaForDay(idx + 1);
            if(sum != double.NaN) price_textBox.Text = sum.ToString();    
        }

        private void OnLoad(object sender, EventArgs e)
        {
            Icon = Properties.Resources.list_23;
            season_comboBox.SelectedIndex = 0;
        }

        private void change_price_button_Click(object sender, EventArgs e)
        {
            int idx = season_comboBox.SelectedIndex;
            if (idx < 0) return;
            double s = 0.0;
            try
            {
                s = Convert.ToDouble(price_textBox.Text);
            }
            catch(Exception)
            {
                Program.ShowErrorMessage("Неверный формат числа");
            }
            int recs = Program.m_helper.UpdateSummaForDay(idx + 1, s);
            if (recs < 1)
                Program.DBErrorMessage();
        }

        private void OnKeyPressPrice(object sender, KeyPressEventArgs e)
        {
            e.Handled = !((e.KeyChar >= (char)Keys.D0 && e.KeyChar <= (char)Keys.D9)
                || (e.KeyChar == (char)Keys.Back)
                || (e.KeyChar == (char)Keys.Oemcomma));

        }
    }
}
