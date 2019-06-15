using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB5_CSHARP
{
    class Dot : IDot
    {
       
        private double x;
        private double y;

        public double X { get => x; set => x = value; }
        public double Y { get => y; set => y = value; }
       

        // Координаты точки в виде свойств


        // Конструкторы
        public Dot()
        {
            X = 0;
            Y = 0;
        }

        public Dot(double a)
        {
           
            X = a;
            Y = a;
        }

        public Dot(double x, double y)
        {
           
            X = x;
            Y = y;
        }

        public Dot(Dot p)
        {
            this.X = p.X;
            this.Y = p.Y;
        }

        public void Input()
        {
            Console.WriteLine("X: ");
            X = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Y: ");
            Y = Convert.ToDouble(Console.ReadLine());
        }

        // Перегрузка метода ToString
        public override string ToString()
        {
            return string.Format($"({Math.Round(X, 4)},{Math.Round(Y, 4)})");
        }
    }
}
