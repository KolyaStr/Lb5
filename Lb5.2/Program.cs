using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lb5._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выберите конус(ввести словами):");
            Console.WriteLine("Целый");
            Console.WriteLine("Усеченный");
            string figure = Console.ReadLine();
            if (figure == "Целый" || figure == "целый")
            {
                int a = 0;
                Cone cone = new Cone();

                while (a == 0)
                {
                    Console.WriteLine("Введите радиус основания:");
                    string radius = Console.ReadLine();
                    if (radius.Any(q => char.IsLetter(q)) || string.IsNullOrWhiteSpace(radius))
                    {
                        Console.WriteLine("Ошибка, вы ввели не число!");
                        continue;
                    }
                    else
                    {
                        cone.R = double.Parse(radius);
                    }

                    int b = 0;
                    while (b == 0)
                    {
                        Console.WriteLine("Введите высоту конуса:");
                        string height = Console.ReadLine();
                        if (height.Any(q => char.IsLetter(q)) || string.IsNullOrWhiteSpace(height))
                        {
                            Console.WriteLine("Ошибка, вы ввели не число!");
                            continue;
                        }
                        else
                        {
                            cone.H = double.Parse(height);

                        }
                        b -= 1;
                        a -= 1;
                    }
                }
                cone.Calc();
                cone.Print();
            }
            else if (figure == "усеченный" || figure == "Усеченный")
            {
                int a = 0;
                Frustum frustum = new Frustum();

                while (a == 0)
                {
                    Console.WriteLine("Введите радиус основания:");
                    string Radius = Console.ReadLine();
                    if (Radius.Any(q => char.IsLetter(q)) || string.IsNullOrWhiteSpace(Radius))
                    {
                        Console.WriteLine("Ошибка, вы ввели не число!");
                        continue;
                    }
                    else
                    {
                        frustum.R = double.Parse(Radius);
                    }

                    int b = 0;
                    while (b == 0)
                    {
                        Console.WriteLine("Введите высоту конуса:");
                        string height = Console.ReadLine();
                        if (height.Any(q => char.IsLetter(q)) || string.IsNullOrWhiteSpace(height))
                        {
                            Console.WriteLine("Ошибка, вы ввели не число!");
                            continue;
                        }
                        else
                        {
                            frustum.H = double.Parse(height);

                        }
                        b -= 1;
                        a -= 1;
                    }
                }
                int c = 0;
                while (c == 0)
                {
                    Console.WriteLine("Введите радиус верхнего основания:");
                    string radius = Console.ReadLine();
                    if (radius.Any(q => char.IsLetter(q)) || string.IsNullOrWhiteSpace(radius))
                    {
                        Console.WriteLine("Ошибка, вы ввели не число!");
                        continue;
                    }
                    else
                    {
                        frustum.r = double.Parse(radius);
                    }
                    c -= 1;
                }

                frustum.Calc();
                frustum.Print();

            }
            else
                Console.WriteLine("Вы не выбрали фигуру");
            
        }
    }
}
