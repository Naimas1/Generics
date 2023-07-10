using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class LinkedListNode<T>
    {
        public T Value { get; set; }
        public LinkedListNode<T> Next { get; set; }

        public LinkedListNode(T value)
        {
            Value = value;
            Next = null;
        }
    }

    class LinkedList<T>
    {
        private LinkedListNode<T> head;
        private LinkedListNode<T> tail;
        private int count;

        public int Count => count;

        public bool IsEmpty => count == 0;

        public LinkedList()
        {
            head = null;
            tail = null;
            count = 0;
        }

        public void AddFirst(T value)
        {
            LinkedListNode<T> newNode = new LinkedListNode<T>(value);

            if (IsEmpty)
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                newNode.Next = head;
                head = newNode;
            }

            count++;
        }

        public void AddLast(T value)
        {
            LinkedListNode<T> newNode = new LinkedListNode<T>(value);

            if (IsEmpty)
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                tail.Next = newNode;
                tail = newNode;
            }

            count++;
        }

        public bool Remove(T value)
        {
            if (IsEmpty)
            {
                return false;
            }

            if (head.Value.Equals(value))
            {
                head = head.Next;
                count--;
                return true;
            }

            LinkedListNode<T> current = head;

            while (current.Next != null)
            {
                if (current.Next.Value.Equals(value))
                {
                    current.Next = current.Next.Next;

                    if (current.Next == null)
                    {
                        tail = current;
                    }

                    count--;
                    return true;
                }

                current = current.Next;
            }

            return false;
        }

        public void Clear()
        {
            head = null;
            tail = null;
            count = 0;
        }

        public bool Contains(T value)
        {
            LinkedListNode<T> current = head;

            while (current != null)
            {
                if (current.Value.Equals(value))
                {
                    return true;
                }

                current = current.Next;
            }

            return false;
        }

        public void Print()
        {
            LinkedListNode<T> current = head;

            while (current != null)
            {
                Console.Write(current.Value + " ");
                current = current.Next;
            }

            Console.WriteLine();
        }
    }

    class Programl
    {
        static void Main()
        {
            LinkedList<int> list = new LinkedList<int>();

            list.AddLast(10);
            list.AddLast(20);
            list.AddFirst(5);

            list.Print(); 

            list.Remove(10);

            list.Print(); 

            Console.WriteLine($"Кількість елементів у списку: {list.Count}");
            Console.WriteLine($"Список порожній: {list.IsEmpty}");
        }
    }
}
