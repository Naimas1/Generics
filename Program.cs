using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Programn
    {
        static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }

        static void Main()
        {
            int num1 = 10;
            int num2 = 20;

            Console.WriteLine($"До обміну: num1 = {num1}, num2 = {num2}");

            Swap(ref num1, ref num2);

            Console.WriteLine($"Після обміну: num1 = {num1}, num2 = {num2}");

            string str1 = "Hello";
            string str2 = "World";

            Console.WriteLine($"До обміну: str1 = {str1}, str2 = {str2}");

            Swap(ref str1, ref str2);

            Console.WriteLine($"Після обміну: str1 = {str1}, str2 = {str2}");
        }
    }
}
