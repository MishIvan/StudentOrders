using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace FunExtremum
{
    delegate float fun(float x, float y);
    class Graph
    {
        private int n, m;
        Graph(int n, int m)
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
            float x, y, step;
            fun Func = new fun(MainForm.Function);

            step = 360.0f / (n - 1);
            for (i = 0; i < n; i++)
            {
                x = i * step;
                xray[i] = x;
                for (j = 0; j < m; j++)
                {
                    y = j * step;
                    yray[j] = y;
                    zmat[i, j] = Func(x,y);
                }
            }

            dislin.scrmod("revers");
            dislin.metafl("cons");
            dislin.setpag("da4p");
            dislin.disini();
            dislin.pagera();
            dislin.hwfont();

            dislin.titlin("Shaded Surface Plot", 2);
            dislin.titlin("F(X,Y) = 2 * SIN(X) * SIN (Y)", 4);

            dislin.axspos(200, 2600);
            dislin.axslen(1800, 1800);

            dislin.name("X-axis", "X");
            dislin.name("Y-axis", "Y");
            dislin.name("Z-axis", "Z");

            dislin.view3d(-5.0f, -5.0f, 4.0f, "ABS");
            dislin.graf3d(0.0f, 360.0f, 0.0f, 90.0f, 0.0f, 360.0f, 0.0f, 90.0f,
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
