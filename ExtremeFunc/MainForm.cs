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
    	private float eps;
    	private float lambda;
        public MainForm()
        {
            InitializeComponent();
            eps = 1.0e-6f;
            lambda = 0.05f;
            
        }
        public static float Function(float x, float y)
        {
            return -2.0f * x * x - x * y - y * y + 3.0f * x;
        }
        private float [] Gradient(float x, float y)
        {
            float[] grad = new float[] { 0.0f, 0.0f };
            grad[0] = (-4.0f * x - y + 3.0f)*-1.0f;
            grad[1] = (-x - 2.0f * y)*-1.0f;
            return grad;
        }
        private float ModGradient(float x, float y)
        {
            float[] vgrad = Gradient(x, y);
            return (float)Math.Sqrt((double)(vgrad[0] * vgrad[0]) + (double)(vgrad[1] * vgrad[1]));
        }
		
        private void ShowGraphic(object sender, EventArgs e)
        {
            Graph g = new Graph(50, 50);
            g.Start();

        }
        private void RunExec(object sender, EventArgs e)
        {
        	Find.Enabled = false;
        	int i = 1;
        	float x0 = 1.0f;
        	float y0 = 1.0f;
        	float x = x0;
        	float y = y0;
        	float f = 0.0f;
        	float f0 = f;
        	while(true)
        	{
        		float [] vgrad = Gradient(x0,y0);
        		x = x0 - lambda*vgrad[0];
        		y = y0 - lambda*vgrad[1];
        		f = -MainForm.Function(x,y);
        		f0 = -MainForm.Function(x0,y0);
        		if(f > f0) lambda *= 0.5f;
        		i++;
        		x0 = x;
        		y0 = y;        		
        		Iterations.Text = String.Format("Итерация: {0:d}, x = {1:F5}, y={2:F5}, f(x,y) ={3:F5}",
        		                                i, x, y, -f);
        		if(ModGradient(x,y) < eps) break;
        	}
        	ExtremumPoint.Text = String.Format("({0:F5};{1:F5})", x, y);
        	ExtremeValue.Text = String.Format("{0:F5}", -f);
        }
    }
}
