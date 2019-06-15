using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB5_CSHARP
{
    class Rectangular : IFigure
    {
        private Line ab;
        private Line bc;
        private Line cd;
        private Line da;

        private Dot a;
        private Dot b;
        private Dot c;
        private Dot d;

        // Свойства. Стороны прямоугольника. Значения задаются только в этом классе.

        internal Line Ab { get => ab; set => ab = value; }
        internal Line Bc { get => bc; set => bc = value; }
        internal Line Cd { get => cd; set => cd = value; }
        internal Line Da { get => da; set => da = value; }


        // Свойства. Вершины прямоугольника. Значения задаются только в этом классе.

        internal Dot A { get => a; set => a = value; }
        internal Dot B { get => b; set => b = value; }
        internal Dot C { get => c; set => c = value; }
        internal Dot D { get => d; set => d = value; }

        // Свойство Периметр. Только для чтения
        public double Perimeter()
        {
            return 2 * Ab.Length + 2 * Bc.Length;
        }
        public double perimeter
        {
            get { return this.Perimeter(); }
        }

        // Свойство Площадь. Только для чтения
        public double Area()
        {
            return Ab.Length * Bc.Length;
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

            Console.WriteLine("Введите координаты точки D:  ");
            D = new Dot();
            D.Input();

            Ab = new Line(A, B);
            Bc = new Line(B, C);
            Cd = new Line(C, D);
            Da = new Line(D, A);
        }
       
        public Rectangular()
        {

        }


        // Конструктор. Создание Прямоугольника по четырем точкам
        public Rectangular(Dot a, Dot b, Dot c, Dot d)
        {
            Dot[] points = new Dot[] { a, b, c, d };
            for (int i = 0; i < points.Length; i++)
            {
                for (int j = 0; j < points.Length; j++)
                {
                    if (i != j && points[i] == points[j]) throw new ArgumentException("Точки должны отличаться.");
                }
            }

            A = new Dot(a);
            B = new Dot(b);
            C = new Dot(c);
            D = new Dot(d);

            Ab = new Line(A, B);
            Bc = new Line(B, C);
            Cd = new Line(C, D);
            Da = new Line(D, A);

            // Если срабатывает это исключение нужно обнулять значение свойств или еще что-то
            // Например переобразовывать в класс Многоугольник объект
            if (!Line.IsParallel(Ab, Cd) || !Line.IsParallel(Bc, Da))
                throw new ArgumentException("Стороны должны быть параллельны");
        }

        
        public override string ToString()
        {
            string points = string.Format($"\nВершины: A {A.ToString()} B {B.ToString()} C {C.ToString()} D {D.ToString()}\n");
            string lines = string.Format($"Стороны: AB = {Ab.Length}; BC = {Bc.Length}; CD = {Cd.Length}; DA = {Da.Length};\n");
            string otherData = string.Format($"Периметр = {this.perimeter}, Площадь = {Area()};\n");

            return string.Format(points + lines + otherData);
        }
    }
}
