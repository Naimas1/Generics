using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class ArraySumCalculator
    {
        public static T Sum<T>(T[] array)
        {
            if (array == null)
            {
                throw new ArgumentNullException(nameof(array));
            }

            dynamic sum = default(T);
            foreach (var element in array)
            {
                sum += element;
            }

            return sum;
        }
    }

    class Programs
    {
        static void Main()
        {
            int[] intArray = { 1, 2, 3, 4, 5 };
            int intSum = ArraySumCalculator.Sum(intArray);
            Console.WriteLine("Сума елементів у цілочисельному масиві: " + intSum);

            double[] doubleArray = { 1.5, 2.5, 3.5, 4.5, 5.5 };
            double doubleSum = ArraySumCalculator.Sum(doubleArray);
            Console.WriteLine("Сума елементів у масиві дійсних чисел: " + doubleSum);
        }
    }
}
