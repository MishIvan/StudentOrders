using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunExtremum
{
    public delegate float fun(float x, float y);
    public delegate float[] gradient(float x, float y);
    internal class Functions
    {
        // параболическая функция и её градиент
        public static float Quad(float x, float y)
        {
            return -2.0f * x * x - x * y - y * y + 3.0f * x;
        }

        public static float [] GradientQuad(float x, float y)
        {
            float[] grad = new float[2];
            grad[0] = -4.0f * x - y + 3.0f;
            grad[1] = -x - 2.0f * y;
            return grad;
        }

        // функция Бута и её градиент
        public static float Boot(float x, float y)
        {
            return (x + 2.0f * y - 7.0f) * (x + 2.0f * y - 7.0f) +
                (2.0f * x + y - 5.0f) * (2.0f * x + y - 5.0f);
        }
        public static float[] GradientBoot(float x, float y)
        {
            float[] grad = new float[2];
            grad[0] = 2.0f * (x + 2 * y - 7.0f) + 4.0f * (2.0f * x + y - 5.0f);
            grad[1] = 4.0f * (x + 2 * y - 7.0f) + 2.0f * (2.0f * x + y - 5.0f);
            return grad;
        }
        // функция Била и её градиент
        public static float Bil(float x, float y)
        {
            return (1.5f - x + x * y) * (1.5f - x + x * y) + (2.25f - x + x * y * y) * (2.25f - x + x * y * y) +
                (2.625f - x + x * y * y * y) * (2.625f - x + x * y * y * y);
        }
        public static float[] GradientBil(float x, float y)
        {
            float[] grad = new float[2];
            grad[0] = 2.0f* (1.5f - x + x * y)*(y - 1.0f) + 2.0f*(2.25f - x + x * y * y)*(1.0f - y*y) +
                2.0f*(2.625f - x + x * y * y * y)*(y*y*y - 1.0f);
            grad[1] = 2.0f * (1.5f - x + x * y) * x + 4.0f * (2.25f - x + x * y * y) * x * y +
                2.0f * (2.625f - x + x * y * y * y) * x * y * y;
            return grad;
        }

        public static float Schvefel(float x, float y)
        {
            return -Math.Abs(x) - Math.Abs(y) - Math.Abs(x) * Math.Abs(y);
        }
        public static float Threehump(float x, float y)
        {
            return -2.0f * x * x + 1.05f * (float)Math.Pow((double)x, 4.0) - (float)Math.Pow((double)x, 6.0) / 6.0f -
                x * y - y * y;
        }
        public static float[] GradientThreehump(float x, float y)
        {
            float[] grad = new float[2];
            grad[0] = -4.0f*x + 4.2f*x*x*x - x*x*x*x*x - y;
            grad[1] = -x - 2.0f*y;
            return grad;
        }

        public static float Levy(float x, float y)
        {
            return (float)(Math.Sin(3.0 * Math.PI * (double)x) * Math.Sin(3.0 * Math.PI * (double)x)) +
                (1.0f - x) * (1.0f - x) * (1.0f - (float)(Math.Sin(3.0 * Math.PI * (double)y) * Math.Sin(3.0 * Math.PI * (double)y))) +
                (1.0f - y) * (1.0f - y) * (1.0f + (float)(Math.Sin(2.0 * Math.PI * (double)y) * Math.Sin(2.0 * Math.PI * (double)y)));
        }
        public static float[] GradientVevy(float x, float y)
        {
            float[] grad = new float[2];
            grad[0] = (float)(
                6.0*Math.PI*Math.Sin(3.0*Math.PI*x) + 2.0*(x- 1.0)*(1.0 +Math.Pow(Math.Sin(3.0*Math.PI*y),2.0))
                );
            grad[1] = (float)(
                (x - 1.0)*(x -1.0)*6.0*Math.PI* Math.Sin(3.0 * Math.PI * y) + 2.0*(y-1.0)*
                (1.0 + Math.Pow(Math.Sin(2.0 * Math.PI * y), 2.0)) + (y - 1.0)*(y - 1.0)*4.0*Math.PI* Math.Sin(2.0 * Math.PI * y)
                );
            return grad;
        }


    }
}
