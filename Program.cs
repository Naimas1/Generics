using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class MinimumCalculator
    {
        public static T FindMinimum<T>(T first, T second, T third) where T : IComparable<T>
        {
            if (first.CompareTo(second) <= 0 && first.CompareTo(third) <= 0)
            {
                return first;
            }
            else if (second.CompareTo(first) <= 0 && second.CompareTo(third) <= 0)
            {
                return second;
            }
            else
            {
                return third;
            }
        }
    }

    class Programe
    {
        static void Main()
        {
            int minInt = MinimumCalculator.FindMinimum(10, 5, 8);
            Console.WriteLine("Мінімум з трьох цілих чисел: " + minInt);

            double minDouble = MinimumCalculator.FindMinimum(3.14, 2.71, 2.99);
            Console.WriteLine("Мінімум з трьох дійсних чисел: " + minDouble);

            string minString = MinimumCalculator.FindMinimum("apple", "banana", "cherry");
            Console.WriteLine("Мінімум з трьох рядків: " + minString);
        }
    }
}
