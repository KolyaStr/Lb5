using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lb5
{
    class RotateSquare : MovingSquare
    {
        public static Point point = new Point();
        public RotateSquare()
        {
            if (action == 2)
            {
                RectangleCoordinates();
                Console.WriteLine("Стрелка вправо - вращение квадрата в правую сторону, стрелка влево - вращение квадрата в левую сторону");
            }
            while (action == 2)
            {
                string button = Convert.ToString(Console.ReadKey().Key);
                if (button == "RightArrow")
                {
                    point = leftUp;
                    leftUp = leftDown;
                    leftDown = rightDown;
                    rightDown = rightUp;
                    rightUp = point;
                    Print();
                }
                else if (button == "LeftArrow")
                {
                    LeftArrow();
                }
            }
        }
        private void LeftArrow()
        {
            point = leftDown;
            leftDown = leftUp;
            leftUp = rightUp;
            rightUp = rightDown;
            rightDown = point;
            Print();
        }
    }
}
