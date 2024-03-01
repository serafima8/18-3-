using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Компьютерный_практикум_3
{
    /// <summary>
    /// Производный класс Прямоугольник от базового класса Фигуры
    /// </summary>
    class Rectangle : Figure
    {
        /// <summary>
        /// Создание поля первой стороны
        /// </summary>
        private double side1;
        /// <summary>
        /// Создание поля второй стороны
        /// </summary>
        private double side2;
        /// <summary>
        /// Свойство поля side1
        /// </summary>
        public double Side1 { get { return side1; } set { side1 = value; } }
        /// <summary>
        /// Свойство поля side2
        /// </summary>
        public double Side2 { get { return side2; } set { side2 = value; } }
        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public Rectangle() { }
        /// <summary>
        /// Конструктор с параметрами 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="side1"></param>
        /// <param name="side2"></param>
        public Rectangle(string name, double side1, double side2) : base(name)
        {
            this.side1 = side1;
            this.side2 = side2;
        }
        /// <summary>
        /// Метод, предназначенный для получения площади фигуры
        /// </summary>
        /// <returns></returns>
        public override double Area()
        {
            return side1 * side2;
        }
        /// <summary>
        /// Метод, предназначенный для получения периметра фигуры
        /// </summary>
        /// <returns></returns>
        public override double Perimeter()
        {
            return 2 * (side1 + side2);
        }
        /// <summary>
        /// Метод, который выводит информацию о фигуре
        /// </summary>
        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Первая сторона: {side1}\nВторая сторона: {side2}");
        }
        /// <summary>
        /// Метод, с помощью которого мы вводим информацию о фигуре 
        /// </summary>
        /// <returns></returns>
        static public Rectangle Show()
        {
            string name = "прямоугольник";
            Console.Write("Введите первую сторону: ");
            int side1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите вторую сторону: ");
            int side2 = Convert.ToInt32(Console.ReadLine());
            return new Rectangle(name,side1, side2);
        }
    }
}
