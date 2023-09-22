using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibrarySharp;


namespace UseLibrary
{
     class Program
    {
        static void Main()
        {
            IShape shape1 = new Circle(5);
            Console.WriteLine($"Площадь круга равна {shape1.CalculateArea()}");

            IShape shape2 = new Triangle(3, 4, 5);
            Console.WriteLine($"Площадь треугольника равна {shape2.CalculateArea()}");
            Console.WriteLine($"Это прямоугольный треугольник: {((Triangle)shape2).IsRightAngleTriangle()}");
        }
    }
}
