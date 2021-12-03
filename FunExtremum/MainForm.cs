using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FunExtremum
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        public static float Function(float x, float y)
        {
            return -2.0f * x * x - x * y - y * y + 3.0f * x;
        }
        private float [] Gradient(float x, float y)
        {
            float[] grad = new float[] { 0.0f, 0.0f };
            grad[0] = -4 * x - y + 3.0f;
            grad[1] = -1.0f * x - 2.0f * y;
            return grad;
        }
        private float ModGradient(float x, float y)
        {
            float[] vgrad = Gradient(x, y);
            return (float)Math.Pow((double)(vgrad[0] * vgrad[0]) + (double)(vgrad[1] * vgrad[1]), 0.5);
        }

        private void ShowGraph(object sender, EventArgs e)
        {
            
        }
    }
}
