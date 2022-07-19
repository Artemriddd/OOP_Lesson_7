using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lesson_7
{
    class BCoder : ICoder
    {
        public void Encode(ref string str)
        {
            StringBuilder sb = new StringBuilder();
            char[] charMassive = str.ToCharArray();
            foreach (char c in charMassive)
            {
                if(c >= 1072) // Для определения регистра
                {
                    if ((int)c == 2079) // Пробел обрано не возвращается, сделаю вручную....
                    {
                        sb.Append(' ');
                    }
                    else
                    {
                        sb.Append((char)(('а' + 31) - (c - 'а')));
                    }

                }
                else
                {
                    if ((int)c == 2079)
                    {
                        sb.Append(' ');
                    }
                    else
                    {
                        sb.Append((char)(('А' + 31) - (c - 'А')));
                    }
                }
               
            }
            str = sb.ToString();
        }
        public void Decode(ref string str)
        {
            Encode(ref str);
        }
    }
}
