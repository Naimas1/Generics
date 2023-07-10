using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class MaximumCalculator
    {
        public static T FindMaximum<T>(T first, T second, T third) where T : IComparable<T>
        {
            if (first.CompareTo(second) >= 0 && first.CompareTo(third) >= 0)
            {
                return first;
            }
            else if (second.CompareTo(first) >= 0 && second.CompareTo(third) >= 0)
            {
                return second;
            }
            else
            {
                return third;
            }
        }
    }

    class Programm
    {
        static void Main()
        {
            int maxInt = MaximumCalculator.FindMaximum(10, 5, 8);
            Console.WriteLine("Максимум з трьох цілих чисел: " + maxInt);

            double maxDouble = MaximumCalculator.FindMaximum(3.14, 2.71, 2.99);
            Console.WriteLine("Максимум з трьох дійсних чисел: " + maxDouble);

            string maxString = MaximumCalculator.FindMaximum("apple", "banana", "cherry");
            Console.WriteLine("Максимум з трьох рядків: " + maxString);
        }
    }
}
