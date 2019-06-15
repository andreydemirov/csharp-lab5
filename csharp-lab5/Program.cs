using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB5_CSHARP
{
    class Program
    {
        delegate Rectangular InputShowRectangular(Rectangular rect);
        delegate Triangle InputShowTriangle(Triangle rect);

        static Triangle InputShowDataT(Triangle triangle)
        {
            triangle.Input();
            Console.WriteLine(triangle.ToString());
            return triangle;

        }
        static Rectangular InputShowDataR(Rectangular rect)
        {
            rect.Input();
            Console.WriteLine(rect.ToString());
            return rect;
            
        }
        static void Main(string[] args)
        {

                
            Triangle triangle = new Triangle();

            InputShowTriangle inputShowT = InputShowDataT;
            inputShowT(triangle);


            Rectangular rect1 = new Rectangular();
            InputShowRectangular inputShow = InputShowDataR;
            inputShow(rect1);

        }
    }
}
