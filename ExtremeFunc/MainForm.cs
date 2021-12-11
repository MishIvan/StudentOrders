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
        private static fun Func;
        private static gradient Grad;
        BindingList<Iterations> iterData;
        public MainForm()
        {
            InitializeComponent();
            eps = 1.0e-6f;
            lambda = 0.05f;
            Func = new fun(Functions.Quad);
            iterData = new BindingList<Iterations>();
            Grad = new gradient(Functions.GradientQuad);
            
        }
        public static float Function(float x, float y)
        {
            return Func(x,y);
        }
        private static float [] Gradient(float x, float y)
        {
            float[] grad = Grad(x, y);
            return grad;
        }
        private float ModGradient(float x, float y)
        {
            float[] vgrad = Gradient(x, y);
            return (float)Math.Sqrt((double)(vgrad[0] * vgrad[0]) + (double)(vgrad[1] * vgrad[1]));
        }
		
        private void ShowGraphic(object sender, EventArgs e)
        {
            Graph g = new Graph(50, 50, FuncListView.SelectedItems[0].Index);
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
        // выбрать функцию
        private void OnFunctionChanged(object sender, EventArgs e)
        {
            switch(FuncListView.SelectedItems[0].Index)
            {
                case 0:
                    Func = new fun(Functions.Quad);
                    Grad = new gradient(Functions.GradientQuad);
                    break;
                case 1:
                    Func = new fun(Functions.Boot);
                    Grad = new gradient(Functions.GradientBoot);
                    break;
                case 2:
                    Func = new fun(Functions.Bil);
                    break;
                case 3:
                    Func = new fun(Functions.Schvefel);
                    Grad = null;
                    break;
                case 4:
                    Func = new fun(Functions.Threehump);
                    break;
                case 5:
                    Func = new fun(Functions.Levy);
                    break;

            }
        }

        private void OnLoad(object sender, EventArgs e)
        {
            FuncListView.Items[0].Selected = true;
            iterateButton.Enabled = false;
            iterationsGridView.DataSource = iterData;
        }

        // начать решать итерациями вручную
        private void OnStartIterations(object sender, EventArgs e)
        {
            if (!iterateButton.Enabled) iterateButton.Enabled = true;
        }
        // завершить решать итерациями вручную
        private void OnStopIterations(object sender, EventArgs e)
        {
            if (iterateButton.Enabled) iterateButton.Enabled = false;
        }
        // сделать шаг итерации
        private void OnIterate(object sender, EventArgs e)
        {
            if(ValidateInput(xTextBox) && ValidateInput(yTextBox) && 
                ValidateInput(stepxTextBox) && ValidateInput(ystepTextBox))
            {
                float x = (float)Convert.ToDouble(xTextBox.Text);
                float y = (float)Convert.ToDouble(yTextBox.Text);
                float px = (float)Convert.ToDouble(stepxTextBox.Text);
                float py = (float)Convert.ToDouble(ystepTextBox.Text);
                float fxy = Func(x + px, y + py);
                iterData.Add(new FunExtremum.Iterations { xv = x, yv = y, fv = fxy });
            }

        }
        private bool ValidateInput(TextBox elem)
        {
            string s1 = elem.Text;
            try
            {
                Convert.ToDouble(s1);
            }
            catch(FormatException)
            {
                ErrorText.Text = "Heверный формат числа";
                return false;
            }
            ErrorText.Text = "";
            return true;


        }
    }
}
