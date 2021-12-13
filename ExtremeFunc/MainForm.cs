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
    	private float eps, kmin;
    	private float lambda;
        public static fun Func;
        private static gradient Grad;
        BindingList<Iterations> iterData;
        public MainForm()
        {
            InitializeComponent();
            eps = 1.0e-5f;
            lambda = 0.05f;
            Func = new fun(Functions.Quad);
            iterData = new BindingList<Iterations>();
            Grad = new gradient(Functions.GradientQuad);
            kmin = 1.0f;
            
        }
        private float ModGradient(float x, float y)
        {
            float[] vgrad = Grad(x, y);
            return (float)Math.Sqrt((double)(vgrad[0] * vgrad[0]) + (double)(vgrad[1] * vgrad[1]));
        }
		
        private void ShowGraphic(object sender, EventArgs e)
        {
            Graph g = new Graph(100, 100, FuncListView.SelectedItems[0].Index);
            g.Start();

        }
        private void RunExec(object sender, EventArgs e)
        {
            if(Grad == null)
            {
                Iterations.Text = "Метод решения для функции не поддерживается";
                return;
            }
        	Find.Enabled = false;
            Iterations.Text = "Дождитесь завершения итерации...";
        	int i = 0;
            int n = 320000;
        	float x0 = 1.0f;
        	float y0 = 1.0f;
        	float x = x0;
        	float y = y0;
        	float f = 0.0f;
        	float f0 = f;
        	while(true)
        	{
        		float [] vgrad = Grad(x0,y0);
        		x = x0 - lambda*vgrad[0]*kmin;
        		y = y0 - lambda*vgrad[1]*kmin;
        		f = kmin*Func(x,y);
        		f0 = kmin*Func(x0,y0);
                //if (kmin == 1.0 && f0 > f) lambda *= 0.5f;
        		i++;
        		x0 = x;
        		y0 = y;
                float mg = ModGradient(x, y);
                if (mg < eps || i > n) break;
        	}
            if(i < n)
            {
                ExtremumPoint.Text = String.Format("({0:F5};{1:F5})", x, y);
                ExtremeValue.Text = String.Format("{0:F5}", kmin * f);
                Iterations.Text = $"Итерацтонный процесс завершён. Число итераций {i}";
            }
            else
            {
                Iterations.Text = $"Итерацтонный процесс не сходится";
                ExtremumPoint.Text = String.Empty;
                ExtremeValue.Text = String.Empty;
            }
            Find.Enabled = true;
        }
        // выбрать функцию
        private void OnFunctionChanged(object sender, EventArgs e)
        {
            switch(FuncListView.SelectedItems[0].Index)
            {
                case 0:
                    Func = new fun(Functions.Quad);
                    Grad = new gradient(Functions.GradientQuad);
                    kmin = -1.0f;
                    break;
                case 1:
                    Func = new fun(Functions.Boot);
                    Grad = new gradient(Functions.GradientBoot);
                    kmin = 1.0f;
                    break;
                case 2:
                    Func = new fun(Functions.Bil);
                    Grad = new gradient(Functions.GradientBil);
                    kmin = 1.0f;
                    break;
                case 3:
                    Func = new fun(Functions.Schvefel);
                    Grad = null;
                    break;
                case 4:
                    Func = new fun(Functions.Threehump);
                    Grad = null;
                    break;
                case 5:
                    Func = new fun(Functions.Levy);
                    Grad = null;
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
            if (FuncListView.Enabled) FuncListView.Enabled = false;
        }
        // завершить решать итерациями вручную
        private void OnStopIterations(object sender, EventArgs e)
        {
            if (iterateButton.Enabled) iterateButton.Enabled = false;
            if (!FuncListView.Enabled) FuncListView.Enabled = true;
            iterData.Clear();

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
                float fxy = Func(x, y);
                iterData.Add(new FunExtremum.Iterations { xv = x, yv = y, fv = fxy });
                xTextBox.Text = Convert.ToString(x + px);
                yTextBox.Text = Convert.ToString(y + py);
                iterationsGridView.CurrentCell = iterationsGridView[0, iterData.Count - 1];
            }

        }
        private bool ValidateInput(TextBox elem)
        {
            string s1 = elem.Text;            
            elem.Text = s1 = s1.Replace('.', ','); 
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
