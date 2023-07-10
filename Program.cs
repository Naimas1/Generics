using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class CircularQueue<T>
    {
        private T[] items;
        private int head;
        private int tail;
        private int count;

        public int Count => count;

        public int Capacity => items.Length;

        public bool IsEmpty => count == 0;

        public bool IsFull => count == items.Length;

        public CircularQueue(int capacity)
        {
            items = new T[capacity];
            head = 0;
            tail = -1;
            count = 0;
        }

        public void Enqueue(T item)
        {
            if (IsFull)
            {
                throw new InvalidOperationException("Кільцева черга повна");
            }

            tail = (tail + 1) % items.Length;
            items[tail] = item;
            count++;
        }

        public T Dequeue()
        {
            if (IsEmpty)
            {
                throw new InvalidOperationException("Кільцева черга порожня");
            }

            T item = items[head];
            items[head] = default(T);
            head = (head + 1) % items.Length;
            count--;

            return item;
        }

        public T Peek()
        {
            if (IsEmpty)
            {
                throw new InvalidOperationException("Кільцева черга порожня");
            }

            return items[head];
        }

        public void Clear()
        {
            Array.Clear(items, 0, items.Length);
            head = 0;
            tail = -1;
            count = 0;
        }
    }

    class Programj
    {
        static void Main()
        {
            CircularQueue<string> queue = new CircularQueue<string>(3);

            queue.Enqueue("Apple");
            queue.Enqueue("Banana");
            queue.Enqueue("Orange");

            Console.WriteLine($"Кількість елементів у черзі: {queue.Count}");

            while (!queue.IsEmpty)
            {
                string item = queue.Dequeue();
                Console.WriteLine($"Елемент: {item}");
            }

            Console.WriteLine();

            CircularQueue<int> numberQueue = new CircularQueue<int>(5);

            numberQueue.Enqueue(5);
            numberQueue.Enqueue(10);
            numberQueue.Enqueue(15);

            Console.WriteLine($"Кількість елементів у черзі: {numberQueue.Count}");

            while (!numberQueue.IsEmpty)
            {
                int item = numberQueue.Dequeue();
                Console.WriteLine($"Елемент: {item}");
            }
        }
    }
}
