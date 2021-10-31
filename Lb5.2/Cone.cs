using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lb5._2
{
    class Cone
    {
        public double R { get; set; }
        public double H { get; set; }

        protected double volume = 0;
        protected double square = 0;

        public virtual void Calc()
        {
            volume = Math.PI * Math.Pow(R, 2) * H/3;
            square = 3.14 * Math.Pow(R, 2);
        }

        public virtual void Print()
        {
            Console.WriteLine($"Радиус основания: {R}");
            Console.WriteLine($"Высота конуса: {H}");
            Console.WriteLine($"Объем конуса: {volume}");
            Console.WriteLine($"Площадь основания: {square}");
        }

    }
}
