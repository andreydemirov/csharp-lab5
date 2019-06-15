using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB5_CSHARP
{
    class Line : ILine
    {
        // Свойства отвечающие за начальную и конечную точки

        private Dot origin;
        private Dot end;
        

        // Свойство длины. Только для чтения
        public double Length { get { return length(); } }

        internal Dot Origin { get => origin; set => origin = value; }
        internal Dot End { get => end; set => end = value; }

        // Конструктор
        public Line(Dot p1, Dot p2)
        {
            Origin = p1;
            End = p2;
        }

        // метод для определения длины
        public double length()
        {
            return Math.Round(Math.Sqrt((End.X - Origin.X) * (End.X - Origin.X) + (End.Y - Origin.Y) * (End.Y - Origin.Y)),4);
        }

        public void Input()
        {
            Console.WriteLine("Введите координаты первой точки: \nX: ");
            Origin.X = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Y:");
            Origin.Y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите координаты второй точки: \nX: ");
            End.X = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Y:");
            End.Y = Convert.ToInt32(Console.ReadLine());
        }

        // Статический метод для проверки параллельности 2х отрезков
        public static bool IsParallel(Line l1, Line l2)
        {
            return
                Math.Abs((l2.End.Y - l2.Origin.Y) * (l1.End.X - l1.Origin.X) -
                         (l2.End.X - l2.Origin.X) * (l1.End.Y - l1.Origin.Y)) < Double.Epsilon;
        }

        public override string ToString()
        {
            return $"Линия с точками 1({origin.X},{origin.Y}) и 2({end.X},{end.Y}). Длина - {Math.Round(Length,4)}";

        }
    }
}
