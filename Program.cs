using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class Queue<T> : IEnumerable<T>
    {
        private LinkedList<T> items;

        public Queue()
        {
            items = new LinkedList<T>();
        }

        public void Enqueue(T item)
        {
            items.AddLast(item);
        }

        public T Dequeue()
        {
            if (items.Count == 0)
            {
                throw new InvalidOperationException("Черга порожня");
            }

            T item = items.First.Value;
            items.RemoveFirst();
            return item;
        }

        public T Peek()
        {
            if (items.Count == 0)
            {
                throw new InvalidOperationException("Черга порожня");
            }

            return items.First.Value;
        }

        public int Count
        {
            get { return items.Count; }
        }

        public IEnumerator<T> GetEnumerator()
        {
            return items.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    class Programu
    {
        static void Main()
        {
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("один");
            queue.Enqueue("два");
            queue.Enqueue("три");

            Console.WriteLine("Кількість елементів у черзі: " + queue.Count);

            string firstItem = queue.Dequeue();
            Console.WriteLine("Перший елемент у черзі: " + firstItem);

            string peekedItem = queue.Peek();
            Console.WriteLine("Елемент, який дивимося в черзі: " + peekedItem);

            Console.WriteLine("Кількість елементів у черзі після видалення: " + queue.Count);

            Console.WriteLine("Елементи у черзі:");
            foreach (string item in queue)
            {
                Console.WriteLine(item);
            }
        }
    }
}
