using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DisabilityList
{
    public partial class DisabilityListForm : Form
    {
        public DisabilityListForm()
        {
            InitializeComponent();
        }

        private void OnLoad(object sender, EventArgs e)
        {
            Icon = Properties.Resources.illness32;
        }

        private void ConvertToYearMonth(double dblYears,ref int year,ref int month)
        {
            year = (int)Math.Floor(dblYears);
            month = (int)Math.Floor((dblYears - year) * 12.0);
        }

        private double ConvertToDoubleYears(int year, int month)
        {
            return (double)year + (double)month/12.0;
        }
    }
}
