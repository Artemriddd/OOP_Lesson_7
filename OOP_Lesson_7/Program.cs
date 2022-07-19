using System;

namespace OOP_Lesson_7
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Привет Артем";
            Console.WriteLine($"Изначальное слово: {str}");

            ACoder acoder = new ACoder();

            acoder.Encode(ref str);
            Console.WriteLine($"Закодированное слово: {str}");
            acoder.Decode(ref str);
            Console.WriteLine($"Декодированное слово: {str}");


            string str1 = "Привет Артем";
            Console.WriteLine($"Изначальное слово: {str1}");

            BCoder bcoder = new BCoder();

            bcoder.Encode(ref str1);
            Console.WriteLine($"Закодированное слово: {str1}");
            bcoder.Decode(ref str1);
            Console.WriteLine($"Декодированное слово: {str1}");
        }
    }
}
