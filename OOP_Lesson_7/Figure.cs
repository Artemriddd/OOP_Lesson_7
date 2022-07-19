using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lesson_7
{
    public enum Color
    {
        Red,
        Yellow,
        Green,
        Blue,
        Gray,
        White
    }
    public abstract class Figure
    {
        private Color _color;
        private bool _isVisible;
        protected int _x;
        protected int _y;

        public bool IsVisible
        {
            get
            {
                return _isVisible;
            }
            set
            {
                _isVisible = value;
            }
        }  // Свойство для определения видимости для каждой фигуры идентично
        public Color color
        {
            get
            {
                return _color;
            }
            set
            {
                _color = value;
            }
        } // Свойство для опередления цвета для каждой фигуры идентично
        public abstract int X
        {
            get;
            set;
        }  // Объявляем абстрактные свойства, так как мы до конца не знаем какие именно требования к опеределнию исходной точки расположения фигуры
        public abstract int Y
        {
            get;
            set;
        }  // Объявляем абстрактные свойства, так как мы до конца не знаем какие именно требования к опеределнию исходной точки расположения фигуры



        public abstract double Area(); // Объявляем абстрактный метод, так как площадь вычисляется для каждой фигуры по разной логике

        public abstract void Print(); // Объявляем абстрактный метод, так как рисовалка для каждой фигуры своя

        /// <summary>
        /// Передвижение по горизонтали
        /// </summary>
        /// <param name="x"></param>
        public void MoveX(int x)
        {
            if(X+x<0)
            {
                throw new Exception("Выход за границу поля");
            }
            else
            {
                X += x;
            }
        }  // Движение идентично для всех фигур
        /// <summary>
        /// Передвижение по вертикали
        /// </summary>
        /// <param name="y"></param>
        public void MoveY(int y)
        {
            if (Y + y < 0)
            {
                throw new Exception("Выход за границу поля");
            }
            else
            {
                Y += y;
            }
        }  // Движение идентично для всех фигур
        /// <summary>
        /// Изменение цвета
        /// </summary>
        /// <param name="color1"></param>
        public void ChangeColor(Color color1)
        {
            switch (color1)
            {
                case Color.Red:
                    color = color1;
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case Color.Blue:
                    color = color1;
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case Color.Gray:
                    color = color1;
                    Console.ForegroundColor = ConsoleColor.Gray;
                    break;
                case Color.Green:
                    color = color1;
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case Color.White:
                    color = color1;
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case Color.Yellow:
                    color = color1;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
            }
        }  // Смена цвета идентична для всех фигур
        /// <summary>
        /// Видимый или нет
        /// </summary>
        /// <returns></returns>
        public bool Visible()
        {
            return IsVisible;
        }  // Смена видимости идентична для всех фигур
        /// <summary>
        /// Метод вывода на экран информации об объекте
        /// </summary>
        public virtual void Status() // Вывод состояния для фигур различается, можно было сделать и абстрактным, но так как нам нужно будет лишь добавлять некоторые данные, типа площади, то сделаем виртуальным
        {
            Console.WriteLine($"Видимый: {IsVisible}, Цвет: {color}, Координата X: {X}, Координата Y: {Y}.");
        }
    }

}
