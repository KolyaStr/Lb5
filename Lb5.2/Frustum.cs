using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lb5._2
{
    class Frustum : Cone
    {

        public double r { get; set; }

        public override void Calc()
        {
            volume = Math.PI * H * (Math.Pow(R, 2) + r * R + Math.Pow(r, 2)) / 3;
            square = 3.14 * Math.Pow(R, 2);
        }

        public override void Print()
        {
            Console.WriteLine("Выбран усеченный конус");
            Console.WriteLine($"Радиус основания: {R}");
            Console.WriteLine($"Высота конуса: {H}");
            Console.WriteLine($"Объем конуса: {volume}");
            Console.WriteLine($"Площадь основания: {square}");
        }
    }
}
