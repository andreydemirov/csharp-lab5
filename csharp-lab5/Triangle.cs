using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB5_CSHARP
{
    class Triangle : IFigure
    {

        private Line ab;
        private Line bc;
        private Line ca;
     

        private Dot a;
        private Dot b;
        private Dot c;

        public Triangle()
        {

        }

        public Triangle(Dot a, Dot b, Dot c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        internal Line Ab { get => ab; set => ab = value; }
        internal Line Bc { get => bc; set => bc = value; }
        internal Line Ca { get => ca; set => ca = value; }
        internal Dot A { get => a; set => a = value; }
        internal Dot B { get => b; set => b = value; }
        internal Dot C { get => c; set => c = value; }

        public double Perimeter()
        {
            return Ab.length() + Bc.length() + Ca.length();
        }

        public double Area()
        {
            return Math.Sqrt(Perimeter() * (Perimeter() - Ab.length()) * (Perimeter() - Bc.length()) * (Perimeter() - Ca.length()));
        }

        public void Input()
        {
            Console.WriteLine("Введите координаты точки A:  ");
            A = new Dot();
            A.Input();

            Console.WriteLine("Введите координаты точки B:  ");
            B = new Dot();
            B.Input();

            Console.WriteLine("Введите координаты точки C:  ");
            C = new Dot();
            C.Input();

            Ab = new Line(A, B);
            Bc = new Line(B, C);
            Ca = new Line(C, A);
        }

        public override string ToString()
        {
            string points = string.Format($"\nВершины: A {A.ToString()} B {B.ToString()} C {C.ToString()}");
            string lines = string.Format($"Стороны: AB = {Ab.Length}; BC = {Bc.Length}; CD = {Ca.Length};");
            string otherData = string.Format($"Периметр = {Perimeter()}, Площадь = {Area()};\n");

            return string.Format(points + lines + otherData);
        }
    }
}
