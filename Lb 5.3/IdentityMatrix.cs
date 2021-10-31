using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lb_5._3
{
    class IdentityMatrix : Matrix
    {
        public override void Create()
        {
            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                myArray[i, i] = 1;
            }
        }
        public override void Print()
        {
            Console.WriteLine("Единичная матрица: ");
            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    Console.Write(String.Format("{0,3}", myArray[i, j]));
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
