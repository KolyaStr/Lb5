using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lb5
{
    class MovingSquare
    {
        public static Rectangle square = new Rectangle();
        public static int x, y, length, action;
        public static Point leftUp = new Point();
        public static Point leftDown = new Point();
        public static Point rightUp = new Point();
        public static Point rightDown = new Point();

        public static void Input()
        {
            int a = 0;
            while (a == 0)
            {
                Console.WriteLine("Введите координату X верхнего левого угла квадрата: ");
                string X = Console.ReadLine();
                if (X.Any(q => char.IsLetter(q)) || string.IsNullOrWhiteSpace(X))
                {
                    Console.WriteLine("Ошибка, вы ввели не число!");
                }
                else
                {
                    x = int.Parse(X);
                    a++;
                }
            }

            int b = 0;
            while (b == 0)
            {
                Console.WriteLine("Введите координату Y верхнего левого угла квадрата: ");
                string Y = Console.ReadLine();
                if (Y.Any(q => char.IsLetter(q)) || string.IsNullOrWhiteSpace(Y))
                {
                    Console.WriteLine("Ошибка, вы ввели не число!");
                }
                else
                {
                    y = int.Parse(Y);
                    b++;
                }
            }

            int c = 0;
            while (c == 0)
            {
                Console.WriteLine("Введите длину стороны квадрата: ");
                string Length = Console.ReadLine();
                if (Length.Any(q => char.IsLetter(q)) || string.IsNullOrWhiteSpace(Length))
                {
                    Console.WriteLine("Ошибка, вы ввели не число!");
                }
                else
                {
                    length = int.Parse(Length);
                    c++;
                }
            }

            int d = 0;
            while (d == 0)
            {
                Console.WriteLine("Введите '1', если хотите передвинуть квадрат или '2', если хотите повернуть");
                string Action = Console.ReadLine();
                if (Action.Any(q => char.IsLetter(q)) || string.IsNullOrWhiteSpace(Action))
                {
                    Console.WriteLine("Ошибка, вы ввели не число!");
                }
                else
                {
                    action = int.Parse(Action);
                    d++;
                }
            }
        }
        public MovingSquare()
        {
            if (action == 1)
            {
                RectangleCoordinates();
                Console.WriteLine("Стрелка вправо - движение вправо, стрелка влево - движение влево");
            }
            while (action == 1)
            {
                string button = Convert.ToString(Console.ReadKey().Key);

                if (button == "RightArrow")
                {
                    leftUp.X++;
                    leftDown.X++;
                    rightUp.X++;
                    rightDown.X++;
                    Print();
                }
                else if (button == "LeftArrow")
                {
                    leftUp.X--;
                    leftDown.X--;
                    rightUp.X--;
                    rightDown.X--;
                    Print();
                }
            }
        }

        protected void RectangleCoordinates()
        {
            leftUp.X = x;
            leftUp.Y = y;

            leftDown.X = x;
            leftDown.Y = y - length;

            rightUp.X = x + length;
            rightUp.Y = y;

            rightDown.X = x + length;
            rightDown.Y = y - length;

            square.X = leftUp.X;
            square.Y = leftUp.Y;

            square.Width = length;
            square.Height = length;

            Console.WriteLine($"Параметры квадрата: {square}");
            Print();
        }
        protected void Print()
        {
            Console.WriteLine($"Координаты верхнего левого угла: {leftUp}");
            Console.WriteLine($"Координаты нижнего левого угла: {leftDown}");
            Console.WriteLine($"Координаты верхнего правого угла:{rightUp}");
            Console.WriteLine($"Координаты нижнего правого угла: {rightDown}");
            Console.WriteLine();
        }
    }
}
