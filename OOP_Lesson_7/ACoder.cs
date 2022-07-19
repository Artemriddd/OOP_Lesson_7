using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lesson_7
{
    class ACoder : ICoder
    {
        public void Encode(ref string str)
        {
            StringBuilder sb = new StringBuilder();
            char[] charMassive = str.ToCharArray();
            foreach(char c in charMassive)
            {
                sb.Append((char)(c + 1));
            }
            str = sb.ToString();
        }
        public void Decode(ref string str)
        {
            StringBuilder sb = new StringBuilder();
            char[] charMassive = str.ToCharArray();
            foreach (char c in charMassive)
            {
                sb.Append((char)(c - 1));
            }
            str = sb.ToString();
        }
    }
}
