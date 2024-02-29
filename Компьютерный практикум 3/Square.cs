using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Компьютерный_практикум_3
{
    /// <summary>
    /// Производный класс Квадрат от базового класса Фигуры
    /// </summary>
    class Square : Figure
    {
        /// <summary>
        /// Создания поля сторон квадрата
        /// </summary>
        private int side1;
        /// <summary>
        /// свойство поля side1
        /// </summary>
        public int Side1 { get { return side1; } set { side1 = value; } }
        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public Square() { }
        /// <summary>
        /// Конструктор с параметрами 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="side1"></param>
        public Square(string name, int side1) : base(name)
        {
            this.side1 = side1;
        }
        /// <summary>
        /// Метод, предназначенный для получения площади фигуры
        /// </summary>
        /// <returns></returns>
        public override double Area()
        {
            return Math.Pow(side1, 2);
        }
        /// <summary>
        /// Метод, предназначенный для получения периметра фигуры
        /// </summary>
        /// <returns></returns>
        public override double Perimeter()
        {
            return side1 * 4;
        }
        /// <summary>
        /// Метод, который выводит информацию о фигуре
        /// </summary>
        public override void Print()
        {
            Console.Write("Введите сторону: ");
            int side1 = Convert.ToInt32(Console.ReadLine());
        }
    }
}
