using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Компьютерный_практикум_3
{
    /// <summary>
    /// Производный класс Треугольник от базового класса Фигуры
    /// </summary>
    class Triangle : Figure
    {
        /// <summary>
        /// Создание поля стороны 1
        /// </summary>
        private int side1;
        /// <summary>
        /// Создание поля стороны 2
        /// </summary>
        private int side2;
        /// <summary>
        /// Создание поля стороны 3
        /// </summary>
        private int side3;
        /// <summary>
        /// Свойство поля side1
        /// </summary>
        public int Side1 { get { return side1; } set { side1 = value; } }
        /// <summary>
        /// Свойство поля side2
        /// </summary>
        public int Side2 { get { return side2; } set { side2 = value; } }
        /// <summary>
        /// Свойство поля side3
        /// </summary>
        public int Side3 { get { return side3; } set { side3 = value; } }
        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public Triangle() { }
        /// <summary>
        /// Конструктор с параметрами 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="side1"></param>
        /// <param name="side2"></param>
        /// <param name="side3"></param>
        public Triangle(string name, int side1, int side2, int side3): base(name)
        {
            this.side1 = side1;
            this.side2 = side2;
            this.side3 = side3;
            if (side1<side2+side3 & side2< side1+side3 & side3<side1+side2)
            {
                Console.WriteLine("Треугольник существует");
            }
            else
            {
                Console.WriteLine("Треугольник не существует");
            }
        }
        /// <summary>
        /// Метод, предназначенный для получения площади фигуры
        /// </summary>
        /// <returns></returns>
        public override double Area()
        {
            double p = (side1 + side2 + side3) / 2;
            return Math.Sqrt(p * (p - side1) * (p - side2) * (p - side3));
        }
        /// <summary>
        /// Метод, предназначенный для получения периметра фигуры
        /// </summary>
        /// <returns></returns>
        public override double Perimeter()
        {
            return side1 + side2 + side3;
        }
        /// <summary>
        /// Метод, который выводит информацию о фигуре
        /// </summary>
        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Первая сторона: {side1}\nВторая сторона: {side2}\nТретья сторона: {side3}");
        }
        /// <summary>
        /// Метод, с помощью которого мы вводим информацию о фигуре 
        /// </summary>
        /// <returns></returns>
        static public Triangle Show()
        {
            string name = "треугольник";
            Console.Write("Введите первую сторону: ");
            int side1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите вторую сторону: ");
            int side2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите третью сторону: ");
            int side3 = Convert.ToInt32(Console.ReadLine());
            return new Triangle(name, side1, side2, side3);
        }
    }
}
