using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class Stack<T>
    {
        private T[] items;
        private int top;

        public Stack(int capacity)
        {
            items = new T[capacity];
            top = -1;
        }

        public void Push(T item)
        {
            if (top == items.Length - 1)
            {
                throw new InvalidOperationException("Стек переповнений");
            }

            top++;
            items[top] = item;
        }

        public T Pop()
        {
            if (top == -1)
            {
                throw new InvalidOperationException("Стек порожній");
            }

            T item = items[top];
            top--;
            return item;
        }

        public T Peek()
        {
            if (top == -1)
            {
                throw new InvalidOperationException("Стек порожній");
            }

            return items[top];
        }

        public int Count
        {
            get { return top + 1; }
        }
    }

    class Programb
    {
        static void Main()
        {
            Stack<int> stack = new Stack<int>(5);
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            Console.WriteLine("Кількість елементів у стеці: " + stack.Count);

            int topItem = stack.Peek();
            Console.WriteLine("Верхній елемент у стеці: " + topItem);

            int poppedItem = stack.Pop();
            Console.WriteLine("Видалений елемент зі стеку: " + poppedItem);

            Console.WriteLine("Кількість елементів у стеці після видалення: " + stack.Count);
        }
    }

}
