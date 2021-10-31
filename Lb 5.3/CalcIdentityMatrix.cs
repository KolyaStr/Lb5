using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lb_5._3
{
    class CalcIdentityMatrix : IdentityMatrix
    {
        public override void Create()
        {
            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                myArray[i, i] = 1;
            }
        }
        public void Calc()
        {
            int sum = + myArray[0, 0] * myArray[1, 1] * myArray[2, 2] + 
                myArray[2, 0] * myArray[0, 1] * myArray[1, 2] + 
                myArray[1, 0] * myArray[2, 1] * myArray[0, 2] -
                myArray[2, 0] * myArray[1, 1] * myArray[0, 2] -
                myArray[0, 0] * myArray[2, 1] * myArray[1, 2] - 
                myArray[1, 0] * myArray[0, 1] * myArray[2, 2];
            Console.WriteLine($"Определитель единичной матрицы: {sum}");
        }
        

    }
}
