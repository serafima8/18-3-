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
                switch (name.ToLower())
                {
                    case "прямоугольник":
                        Rectangle rct = new Rectangle();
                        figures.Add(Rectangle.Show());
                        foreach (var elem in figures)
                        {
                            elem.Print();
                            Console.WriteLine($"Площадь прямоугольника: {elem.Area()}");
                            Console.WriteLine($"Периметр прямоугольника: {elem.Perimeter()}");
                        }
                        break;
                    case "квадрат":
                        Square sqr = new Square();
                        figures.Add(Square.Show());
                        foreach (var elem in figures)
                        {
                            Console.WriteLine($"Площадь квадрата: {elem.Area()}");
                            Console.WriteLine($"Периметр квадрата: {elem.Perimeter()}");
                        }
                        break;
                    case "треугольник":
                        Triangle tng = new Triangle();
                        figures.Add(Triangle.Show());
                        foreach (var elem in figures)
                        {
                            Console.WriteLine($"Площадь треугольника: {elem.Area()}");
                            Console.WriteLine($"Периметр треугольника: {elem.Perimeter()}");
                        }
                        break;
                    case "круг":
                        Circle crc = new Circle();
                        figures.Add(Circle.Show());
                        foreach (var elem in figures)
                        {
                            Console.WriteLine($"Площадь круга: {elem.Area()}");
                            Console.WriteLine($"Периметр круга: {elem.Perimeter()}");
                        }
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
