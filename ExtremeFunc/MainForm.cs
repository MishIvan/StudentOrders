using FunExtremum.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FunExtremum
{
    delegate void EvtHandler(int i, float x, float y, float fxy);
    delegate void EvtText(float xe, float ye, float fe, float left, float right, bool converge);
    public partial class MainForm : Form
    {
        private float eps, kmin;
        private float lambda;
        public static fun Func;
        private static gradient Grad;
        private BindingList<Iterations> iterData;
        private int funIdx;
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

        private async void RunExec(object sender, EventArgs e)
        {
            if (Grad == null)
            {
                float xa, ya, fa;
                if(funIdx != 5)
                {
                    xa = 0.0f; ya = 0.0f;
                }
                else
                {
                    xa = 1.0f; ya = 1.0f;

                }
                fa = Func(xa, ya);
                ExtremumPoint.Text = String.Format("({0:F5};{1:F5})", xa, ya);
                ExtremeValue.Text = String.Format("{0:F5}", fa);
                Iterations.Text = "Аналитическое решение. Метод не реализован в программе для этой функции.";
                return;
            }
            Find.Enabled = false;
            Iterations.Text = " Итерационный процесс начат. Ждите...";
            int i = 0;
            int n = 321999;
            float x0 = 1.0f;
            float y0 = 1.0f;
            float x = x0;
            float y = y0;
            float f = 0.0f;
            float f0 = f;
            await Task.Run(() =>
            {
                
                while (true)
                {
                    float[] vgrad = Grad(x0, y0);
                    x = x0 - lambda * vgrad[0] * kmin;
                    y = y0 - lambda * vgrad[1] * kmin;
                    f = kmin * Func(x, y);
                    f0 = kmin * Func(x0, y0);
                    //if (kmin == 1.0 && f0 > f) lambda *= 0.5f;
                    i++;
                    x0 = x;
                    y0 = y;
                    float mg = ModGradient(x, y);
                    if (mg < eps || i > n) break;
                }
            });

            if (i < n)
            {
                ExtremumPoint.Text = String.Format("({0:F5};{1:F5})", x, y);
                ExtremeValue.Text = String.Format("{0:F5}", kmin * f);
                Iterations.Text = $"Итерационный процесс завершён. Число итераций {i}";
            }
            else
            {
                Iterations.Text = $"Итерационный процесс не сходится";
                ExtremumPoint.Text = String.Empty;
                ExtremeValue.Text = String.Empty;
            }
            Find.Enabled = true;
        }
        // выбрать функцию
        private void OnFunctionChanged(object sender, EventArgs e)
        {
            if (FuncListView.Items[0].Selected)
            {
                Func = new fun(Functions.Quad);
                Grad = new gradient(Functions.GradientQuad);
                kmin = -1.0f;
                graphBox.Image = Image.FromHbitmap(Resources.QuadGraph.GetHbitmap());
                funIdx = 0;

            }
            else if (FuncListView.Items[1].Selected)
            {
                Func = new fun(Functions.Boot);
                Grad = new gradient(Functions.GradientBoot);
                graphBox.Image = Image.FromHbitmap(Resources.BootGraph.GetHbitmap());
                kmin = 1.0f;
                funIdx = 1;

            }
            else if (FuncListView.Items[2].Selected)
            {
                Func = new fun(Functions.Bil);
                Grad = new gradient(Functions.GradientBil);
                graphBox.Image = Image.FromHbitmap(Resources.BilGraph.GetHbitmap());
                kmin = 1.0f;
                funIdx = 2;

            }
            else if (FuncListView.Items[3].Selected)
            {
                Func = new fun(Functions.Schvefel);
                graphBox.Image = Image.FromHbitmap(Resources.SchvefelGraph.GetHbitmap());
                Grad = null;
                funIdx = 3;
            }
            else if (FuncListView.Items[4].Selected)
            {
                Func = new fun(Functions.Threehump);
                Grad = new gradient(Functions.GradientThreehump);
                graphBox.Image = Image.FromHbitmap(Resources.ThreeHumpedGraph.GetHbitmap());
                funIdx = 4;
            }

            else if (FuncListView.Items[5].Selected)
            {
                Func = new fun(Functions.Levy);
                graphBox.Image = Image.FromHbitmap(Resources.LeviGraph.GetHbitmap());
                Grad = new gradient(Functions.GradientVevy);
                funIdx = 5;
            }

        }

        private void OnLoad(object sender, EventArgs e)
        {
            FuncListView.Items[0].Selected = true;
            iterationsGridView.DataSource = iterData;
        }
        private void AddRow(int i, float x, float y, float fxy)
        {
            iterData.Add(new FunExtremum.Iterations { istep = i, xv = x, yv = y, fv = fxy });
            iterationsGridView.CurrentCell = iterationsGridView[0, iterData.Count - 1];
            iterationsGridView.Refresh();
        }
        private void ShowText(float xe, float ye, float fe, float left, float right, bool converge)
        {
            if (!converge)
            {
                FexTextBox.Text = String.Empty;
                XexTextBox.Text = String.Empty;
                YexTextBox.Text = String.Empty;
                LeftOperTextBox.Text = String.Empty;
                RightOperTextBox.Text = String.Empty;
                ErrorText.Text = "Итерационный процесс не сошёлся";

            }
            else
            {
                FexTextBox.Text = String.Format("{0:F5}", fe);
                XexTextBox.Text = String.Format("{0:F5}", xe);
                YexTextBox.Text = String.Format("{0:F5}", ye);
                LeftOperTextBox.Text = String.Format("{0:F5}", left);
                RightOperTextBox.Text = String.Format("{0:F5}", right);
                ErrorText.Text = String.Empty;
            }
            if (!newStepButton.Enabled) newStepButton.Enabled = true;
            if (!FuncListView.Enabled) FuncListView.Enabled = true;
            if (!graphButton.Enabled) graphButton.Enabled = true;


        }

        // новый шаг итераций
        private void OnNewStep(object sender, EventArgs e)
        {
            if (!ValidateInput(xTextBox) || !ValidateInput(yTextBox) ||
                !ValidateInput(stepxTextBox) || !ValidateInput(ystepTextBox) ||
                !ValidateInput(XnTextBox) || !ValidateInput(YnTextBox)
                || !ValidateInput(epsTextBox)
                )
            {
                ErrorText.Text = "Heверный формат числа";
                return;
            }
            else
                ErrorText.Text = String.Empty;

            if (newStepButton.Enabled) newStepButton.Enabled = false;            
            if (FuncListView.Enabled) FuncListView.Enabled = false;
            if (graphButton.Enabled) graphButton.Enabled = false;
            iterData.Clear();
            iterationsGridView.Refresh();

            float x = (float)Convert.ToDouble(xTextBox.Text);
            float y = (float)Convert.ToDouble(yTextBox.Text);
            float px = (float)Convert.ToDouble(stepxTextBox.Text);
            float py = (float)Convert.ToDouble(ystepTextBox.Text);
            float xn = (float)Convert.ToDouble(XnTextBox.Text);
            float yn = (float)Convert.ToDouble(YnTextBox.Text);
            float eps = (float)Convert.ToDouble(epsTextBox.Text);

            EvtHandler evt = new EvtHandler(AddRow);
            EvtText evt1 = new EvtText(ShowText);
            int i = 0;
            int n = 3000;

            Thread th = new Thread(() =>
            {
                float xe = x;
                float ye = y;
                float fe = Func(x, y);
                float yleft = 0.0f;
                float yright = 0.0f;
                bool found = false;
                int ifound = 0;
                float x0 = xe;
                float y0 = ye;
                float f0 = fe;
            while (true)
            {
                float fxy = Func(x, y);
                Invoke(evt, i, x, y, fxy);

                // найти локальный минимум или максимум
                if (iterData.Count >= 3 && !found)
                {
                    if ((iterData[i - 2].fv > iterData[i - 1].fv && iterData[i].fv > iterData[i - 1].fv) ||
                        (iterData[i - 2].fv < iterData[i - 1].fv && iterData[i].fv < iterData[i - 1].fv)
                        )
                    { xe = iterData[i - 1].xv; ye = iterData[i - 1].yv; fe = iterData[i - 1].fv; found = true; ifound = i - 1; }

                }

                if (found) // экстремум найден, проверка условий прерывания итерации
                {
                    yleft = 0.0f;
                    for (int j = 0; j < ifound; j++)
                        yleft += (fe - iterData[j].fv) * (fe - iterData[j].fv);
                    yleft = (float)Math.Sqrt((double)yleft);

                    yright = 0.0f;
                    int nn = iterData.Count;
                    for (int j = 0; j < nn; j++)
                        yright += (f0 - iterData[j].fv) * (f0 - iterData[j].fv);
                    yright = (float)Math.Sqrt((double)yright)*eps;

                    if (yleft <= yright) break;
                }
                    // условие остановки несходящихся итераций
                    if ((xn < x && xn > x0 && px > 0.0) || (xn > x && xn < x0 && px < 0.0)
                    || (yn < y && yn > y0 && py > 0.0) || (yn > y && yn < y0 && py < 0.0)
                    )
                    {
                        break;
                    }
                    i++;
                    x += px;
                    y += py;
                }
                Invoke(evt1, xe, ye, fe, yleft, yright, !(i > n));

            });
            th.Start();

        }

        // построить график кривой
        private void OnShowGraph(object sender, EventArgs e)
        {
            if (iterData.Count < 1) return;
            int n = iterData.Count;
            float[] x = new float[n];
            float[] y = new float[n];
            float[] z = new float[n];
            for (int i = 0; i < n; i++)
            {
                x[i] = iterData[i].xv;
                y[i] = iterData[i].yv;
                z[i] = iterData[i].fv;
            }
            Graph gr = new Graph(x, y, z);
            gr.Start();

        }

        private bool ValidateInput(TextBox elem)
        {
            string s1 = elem.Text;
            elem.Text = s1 = s1.Replace('.', ',');
            try
            {
                Convert.ToDouble(s1);
            }
            catch (FormatException)
            {                
                return false;
            }
            return true;


        }


    }

}

