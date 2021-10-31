using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lb_5._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Matrix matrix = new Matrix();
            matrix.Create();
            matrix.Print();

            IdentityMatrix identityMatrix = new IdentityMatrix();
            identityMatrix.Create();
            identityMatrix.Print();

            TriangularMatrix triangularMatrix = new TriangularMatrix();
            triangularMatrix.Create();
            triangularMatrix.Print();

            CalcIdentityMatrix calcIdentityMatrix = new CalcIdentityMatrix();
            calcIdentityMatrix.Create();
            calcIdentityMatrix.Calc();

            CalcTriangularMatrix calcTriangularMatrix = new CalcTriangularMatrix();
            calcTriangularMatrix.Create();
            calcTriangularMatrix.Calc();
        }
    }
}
