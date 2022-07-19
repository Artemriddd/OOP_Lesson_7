using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lesson_7
{
    public interface ICoder
    {
        public void Encode(ref string str);
        public void Decode(ref string str);
    }
}
