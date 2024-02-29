using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Компьютерный_практикум_3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Figure> figures = new List<Figure>();
            while (true)
            {
                Console.Write("Введите фигуру: ");
                string name = Console.ReadLine();
                switch (name)
                {
                    case "прямоугольник":
                        Figure rct = new Rectangle();
                        rct.Print();
                        Console.WriteLine($"Площадь прямоугольника: {rct.Area()}");
                        Console.WriteLine($"Периметр прямоугольника: {rct.Perimeter()}");
                        break;
                    case "квадрат":
                        Figure sqr = new Square();
                        sqr.Print();
                        Console.WriteLine($"Площадь квадрата: {sqr.Area()}");
                        Console.WriteLine($"Периметр квадрата: {sqr.Perimeter()}");
                        break;
                    case "треугольник":
                        Figure tng = new Triangle();
                        tng.Print();
                        Console.WriteLine($"Площадь треугольника: {tng.Area()}");
                        Console.WriteLine($"Периметр треугольника: {tng.Perimeter()}")
                        break;
                    case "круг":
                        Figure crc = new Circle();
                        crc.Print();
                        Console.WriteLine($"Площадь круга: {crc.Area()}");
                        Console.WriteLine($"Периметр круга: {crc.Perimeter()}");
                        break;
                    case "0":return;
                    default:Console.WriteLine("Фигуры не существует");
                        break;
                }

            }
            Console.ReadKey();
        }
    }
}
