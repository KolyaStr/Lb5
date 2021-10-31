using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lb5
{
    class Program
    {

        static void Main(string[] args)
        {
            MovingSquare.Input();
            MovingSquare moving = new MovingSquare();
            RotateSquare rotateSquare = new RotateSquare();
        }
    }
}
