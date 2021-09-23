using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class MatrixChecker
    {

        public static float[,] CheckAddition(float[,] e, float[,] m)
        {
            float[,] emA = new float[2, 2];
            for (int y = 0; y < 2; y++)
            {
                for (int x = 0; x < 2; x++)
                {
                    emA[y, x] = e[y, x] + m[y, x];
                }
            }
            return emA;
        }
        public static float[,] CheckMultiplication(float[,] e, float[,] m)
        {
            float[,] emM = new float[2, 2];

                emM[0, 0] = (e[0, 0] * m[0, 0]) + (e[0, 1] * m[1, 0]);
                emM[0, 1] = (e[0, 0] * m[0, 1]) + (e[0, 1] * m[1, 1]);

                emM[1, 0] = (e[1, 0] * m[0, 0]) + (e[1, 1] * m[1, 0]);
                emM[1, 1] = (e[1, 0] * m[0, 1]) + (e[1, 1] * m[1, 1]);

            return emM;
        }
        public static float[,] CheckRotationMatrix()
        {
            float[,] emR = new float[2, 2];

            double degrees;
            Console.WriteLine("Angle?");
            degrees = Convert.ToDouble(Console.ReadLine());
            double rad = degrees * (Math.PI / 180);

            emR[0, 0] = (float)Math.Cos(rad);
            emR[0, 1] = (float)Math.Sin(rad);
            emR[1, 0] = -(float)Math.Sin(rad);
            emR[1, 1] = (float)Math.Cos(rad);

            return emR;
        }
    }
}
