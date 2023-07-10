using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class PriorityQueue<T>
    {
        private List<T> items;
        private IComparer<T> comparer;

        public int Count => items.Count;

        public PriorityQueue()
        {
            items = new List<T>();
            comparer = Comparer<T>.Default;
        }

        public PriorityQueue(IComparer<T> comparer)
        {
            items = new List<T>();
            this.comparer = comparer;
        }

        public void Enqueue(T item)
        {
            items.Add(item);
            items.Sort(comparer);
        }

        public T Dequeue()
        {
            if (items.Count == 0)
            {
                throw new InvalidOperationException("Черга порожня");
            }

            T item = items[0];
            items.RemoveAt(0);
            return item;
        }

        public T Peek()
        {
            if (items.Count == 0)
            {
                throw new InvalidOperationException("Черга порожня");
            }

            return items[0];
        }

        public bool Contains(T item)
        {
            return items.Contains(item);
        }

        public void Clear()
        {
            items.Clear();
        }
    }

    class Programh
    {
        static void Main()
        {
            PriorityQueue<string> queue = new PriorityQueue<string>();

            queue.Enqueue("Apple");
            queue.Enqueue("Banana");
            queue.Enqueue("Orange");

            Console.WriteLine($"Кількість елементів у черзі: {queue.Count}");

            while (queue.Count > 0)
            {
                string item = queue.Dequeue();
                Console.WriteLine($"Елемент: {item}");
            }

            Console.WriteLine();

            PriorityQueue<int> numberQueue = new PriorityQueue<int>();

            numberQueue.Enqueue(5);
            numberQueue.Enqueue(10);
            numberQueue.Enqueue(3);

            Console.WriteLine($"Кількість елементів у черзі: {numberQueue.Count}");

            while (numberQueue.Count > 0)
            {
                int item = numberQueue.Dequeue();
                Console.WriteLine($"Елемент: {item}");
            }
        }
    }
}
