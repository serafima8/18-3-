using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Компьютерный_практикум_3
{
    /// <summary>
    /// Производный класс Круг от базового класса Фигуры
    /// </summary>
    class Circle : Figure
    {
        /// <summary>
        /// Создание поля радиус
        /// </summary>
        private int r;
        /// <summary>
        /// Свойство поля r
        /// </summary>
        public int R { get { return r; } set { r = value; } }
        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public Circle() { }
        /// <summary>
        /// Конструктор с параметрами 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="r"></param>
        public Circle(string name, int r):base(name)
        {
            this.r = r;
        }
        /// <summary>
        /// Метод, предназначенный для получения площади фигуры
        /// </summary>
        /// <returns></returns>
        public override double Area()
        {
            return Math.PI * Math.Pow(r, 2);
        }
        /// <summary>
        /// Метод, предназначенный для получения периметра фигуры
        /// </summary>
        /// <returns></returns>
        public override double Perimeter()
        {
            return 2 * r * Math.PI;
        }
        /// <summary>
        /// Метод, который выводит информацию о фигуре
        /// </summary>
        public override void Print()
        {
            Console.Write("Введите радиус круга: ");
            int r = Convert.ToInt32(Console.ReadLine());
        }
    }
}
