using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lb_5._3
{
    class Matrix
    {
        protected int[,] myArray = new int[3, 3];
        
        public virtual void Create()
        {
            Random random = new Random();
            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    myArray[i, j] = random.Next(-5, 10);
                }
            }
        }
        public virtual void Print()
        {
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
