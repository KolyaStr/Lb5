using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lb_5._3
{
    class CalcTriangularMatrix : TriangularMatrix
    {
        int num = 0;
        public override void Create()
        {
            Random random = new Random();
            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j = num; j < myArray.GetLength(1); j++)
                {
                    myArray[i, j] = random.Next(-5, 10);
                }
                num++;
            }
        }
        public void Calc()
        {
            int sum = myArray[0, 0] * myArray[1, 1] * myArray[2, 2] +
                myArray[2, 0] * myArray[0, 1] * myArray[1, 2] +
                myArray[0, 1] * myArray[2, 1] * myArray[0, 2] -
                myArray[2, 0] * myArray[1, 1] * myArray[1, 2] * myArray[0, 2] -
                myArray[0, 0] * myArray[2, 1] * myArray[1, 2] -
                myArray[1, 0] * myArray[0, 1] * myArray[2, 2];
            Console.WriteLine($"Определитель треугольной матрицы: {sum}");
        }
        
    }
}
