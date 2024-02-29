using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Компьютерный_практикум_3
{
    /// <summary>
    /// Базовый абстрактный класс
    /// </summary>
    abstract class Figure
    {
        /// <summary>
        /// Создание поля названия фигуры
        /// </summary>
        private string name;
        /// <summary>
        /// Свойство поля name
        /// </summary>
        public string Name { get { return name; } set { name = value; } }
        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public Figure() { }
        /// <summary>
        /// Конструктор с параметрами
        /// </summary>
        /// <param name="name"></param>
        public Figure(string name)
        {
            this.name = name;
        }
        /// <summary>
        /// абстрактный метод, предназначенный для получения площади фигуры
        /// </summary>
        /// <returns></returns>
        public abstract double Area();
        /// <summary>
        /// абстрактный метод, предназначенный для получения периметра фигуры
        /// </summary>
        /// <returns></returns>
        public abstract double Perimeter();
        /// <summary>
        ///  виртуальный метод, который выводит информацию о фигуре
        /// </summary>
        public virtual void Print()
        {
            Console.WriteLine($"Название фигуры: {name}");
        }
    }
}
