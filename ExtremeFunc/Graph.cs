using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace FunExtremum
{
    delegate float fun(float x, float y);
    internal class Graph
    {
        private int n, m;
        public Graph(int n, int m)
        {
            this.n = n;
            this.m = m;            
        }
        private void Plot()
        {
            int n = 50, m = 50;
            float[,] zmat = new float[n, m];
            float[] xray = new float[n];
            float[] yray = new float[m];
            int i, j;
            float x, y, stepx, stepy;
            fun Func = new fun(MainForm.Function);

            stepx = 10.0f / (n - 1);
            stepy = 10.0f / (n - 1);
            for (i = 0; i < n; i++)
            {
                x = i * stepx;
                xray[i] = x;
                for (j = 0; j < m; j++)
                {
                    y = j * stepy;
                    yray[j] = y;
                    zmat[i, j] = Func(x,y);
                }
            }
            dislin.scrmod("auto");
            dislin.metafl("cons");
            dislin.setpag("da4p");
            dislin.disini();
            dislin.pagera();
            dislin.hwfont();

            dislin.titlin("Shaded Surface Plot", 2);
            dislin.titlin("F(X,Y) = -2 *x *x  - x*y - y*y +3*x", 4);

            dislin.page(2000,2000);
            dislin.axspos(300, 1800);
            dislin.axslen(2000, 2000);

            dislin.name("Ось X", "X");
            dislin.name("Ось Y", "Y");
            dislin.name("Ось Z", "Z");

            dislin.view3d(-7.0f, -7.0f, 4.0f, "ABS");
            dislin.graf3d(0.0f, 3.0f, 0.0f, 1.0f, 
                          0.0f, 3.0f, 0.0f, 2.0f,
                           -3.0f, 3.0f, -3.0f, 1.0f);
            dislin.height(50);
            dislin.title();

            dislin.shdmod("smooth", "surface");
            dislin.surshd(xray, n, yray, m, zmat);
            dislin.disfin();
        }

        public void Start()
        {
            Thread th = new Thread(this.Plot);
            th.Start();
        }

    }

}
