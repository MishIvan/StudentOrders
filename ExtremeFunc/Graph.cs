using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace FunExtremum
{    
    internal class Graph
    {
        private float[] xray;
        private float[] yray;
        private float[] zray;
        public Graph(float [] xcoord, float[] ycoord, float [] zcoord)
        {
            xray = xcoord;
            yray = ycoord;
            zray = zcoord;
        }
        private void Plot()
        {

            float xa, xe, xor, xstep,
                ya, ye, yor, ystep,
                za, ze, zor, zstep;
            int n = xray.Length;

            za = ze = 0.0f;
            xa = xe = 0.0f;
            ya = ye = 0.0f;
            for (int i = 0; i < n; i++)
            {
                if (xa < xray[i]) xa = xray[i];
                if (xe > xray[i]) xe = xray[i];
                if (ya < yray[i]) ya = yray[i];
                if (ye > yray[i]) ye = yray[i];
                if (za < zray[i]) za = zray[i];
                if (ze > zray[i]) ze = zray[i];
            }
            zor = za - 0.5f; zstep = (ze - za) / 5.0f;
            xor = xa - 0.5f; xstep = (xe - xa) / 5.0f;
            yor = ya - 0.5f; ystep = (ye - ya) / 5.0f;

            dislin.scrmod("auto");
            dislin.metafl("cons");
            dislin.setpag("da4p");
            dislin.disini();
            dislin.pagera();
            dislin.hwfont();
            dislin.pagorg("BOTTOM");

            dislin.titlin("Line 3D Plot", 2);
            dislin.titlin("Iteration plot", 4);

            dislin.name("X Axis", "X");
            dislin.name("Y Axis", "Y");
            dislin.name("Z Axis", "Z");

            float r = (float)Math.Sqrt((double)((xe - xa) * (xe - xa) + (ye - ya) * (ye - ya) + (ze - za) * (ze - za)));
            dislin.view3d(45.0f, 30.0f, r*0.0005f, "ANGLE");
            dislin.graf3d(xa, xe, xor, xstep, 
                          ya, ye, yor, ystep,
                          za, ze, zor, zstep);
            dislin.height(50);
            dislin.title();

            dislin.shdmod("smooth", "surface");
            //dislin.surfce(xray, n, yray, m, zmat);
            dislin.curv3d(xray, yray, zray, n);
            dislin.disfin();
        }

        public void Start()
        {
            Thread th = new Thread(this.Plot);
            th.Start();
        }

    }

}
