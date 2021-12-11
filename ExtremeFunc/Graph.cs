using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace FunExtremum
{    
    internal class Graph
    {
        private int n, m; // число точек по x и по y
        private fun Func;
        private float xa, xe, xor, xstep,
            ya, ye, yor, ystep,
            za, ze, zor, zstep;
        public Graph(int n, int m, int nfunc = 0)
        {
            this.n = n;
            this.m = m;
            Func = new fun(MainForm.Function);
            switch (nfunc)
            {
                case 0:
                    xa = -2.0f; xe = 2.0f; xor = xa - 0.5f; xstep = (xe - xa) / 5.0f;
                    ya = -2.0f; ye = 2.0f; yor = ya - 0.5f; ystep = (ye - ya) / 5.0f;                    
                    break;
                case 1:
                case 3:
                case 5:
                    xa = -10.0f; xe = 10.0f; xor = xa - 0.5f; xstep = (xe - xa) / 5.0f;
                    ya = -10.0f; ye = 10.0f; yor = ya - 0.5f; ystep = (ye - ya) / 5.0f;
                    break;
                case 2:
                    xa = -4.5f; xe = 4.5f; xor = xa - 0.5f; xstep = (xe - xa) / 5.0f;
                    ya = -4.5f; ye = 4.5f; yor = ya - 0.5f; ystep = (ye - ya) / 5.0f;
                    break;
                case 4:
                    xa = -5.0f; xe = 5.0f; xor = xa - 0.5f; xstep = (xe - xa) / 5.0f;
                    ya = -5.0f; ye = 5.0f; yor = ya - 0.5f; ystep = (ye - ya) / 5.0f;
                    break;


            }
            za = Func(xa, ya) - 0.5f; ze = Func(xe, ye) + 0.5f; zor = za - 0.5f; zstep = (ze - za) / 5.0f;
        }
        private void Plot()
        {
            int n = 50, m = 50;
            float[,] zmat = new float[n, m];
            float[] xray = new float[n];
            float[] yray = new float[m];
            int i, j;
            float x, y, stepx, stepy;            

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
            dislin.titlin("F(X,Y)", 4);

            dislin.page(2000,2000);
            dislin.axspos(300, 1800);
            dislin.axslen(2000, 2000);

            dislin.name("X Axis", "X");
            dislin.name("Y Axis", "Y");
            dislin.name("Z Axis", "Z");

            dislin.view3d((xe - xa)*0.5f, ya -1.25f*(ye - ya), za + 1.25f*(ze - za), "ABS");
            dislin.graf3d(xa, xe, xor, xstep, 
                          ya, ye, yor, ystep,
                          za, ze, zor, zstep);
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
