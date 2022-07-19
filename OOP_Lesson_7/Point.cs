using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lesson_7
{
    class Point:Figure
    {
        public override int X
        {
            get
            {
                return _x;
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Координата должна быть больше 0");
                }
                else
                {
                    _x = value;
                }
            }
        }
        public override int Y
        {
            get
            {
                return _y;
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Координата должна быть больше 0");
                }
                else
                {
                    _y = value;
                }
            }
        }

        public override double Area()
        {
            return 0;
        }

        /// <summary>
        /// Рисует точку на экране
        /// </summary>
        public override void Print()
        {
            if(IsVisible == true)
            {
                Console.Clear();
                Console.SetCursorPosition(X, Y);
                ChangeColor(color);
                Console.Write("*");
                Console.ResetColor();
            }
            else
            {
                Console.WriteLine("Деталь невидима");
            }
        }
    }
}
