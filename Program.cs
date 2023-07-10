using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class DoublyLinkedListNode<T>
    {
        public T Value { get; set; }
        public DoublyLinkedListNode<T> Previous { get; set; }
        public DoublyLinkedListNode<T> Next { get; set; }

        public DoublyLinkedListNode(T value)
        {
            Value = value;
            Previous = null;
            Next = null;
        }
    }

    class DoublyLinkedList<T>
    {
        private DoublyLinkedListNode<T> head;
        private DoublyLinkedListNode<T> tail;
        private int count;

        public int Count => count;

        public bool IsEmpty => count == 0;

        public DoublyLinkedList()
        {
            head = null;
            tail = null;
            count = 0;
        }

        public void AddFirst(T value)
        {
            DoublyLinkedListNode<T> newNode = new DoublyLinkedListNode<T>(value);

            if (IsEmpty)
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                newNode.Next = head;
                head.Previous = newNode;
                head = newNode;
            }

            count++;
        }

        public void AddLast(T value)
        {
            DoublyLinkedListNode<T> newNode = new DoublyLinkedListNode<T>(value);

            if (IsEmpty)
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                newNode.Previous = tail;
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

            DoublyLinkedListNode<T> current = head;

            while (current != null)
            {
                if (current.Value.Equals(value))
                {
                    if (current.Previous != null)
                    {
                        current.Previous.Next = current.Next;
                    }
                    else
                    {
                        head = current.Next;
                    }

                    if (current.Next != null)
                    {
                        current.Next.Previous = current.Previous;
                    }
                    else
                    {
                        tail = current.Previous;
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
            DoublyLinkedListNode<T> current = head;

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

        public void PrintForward()
        {
            DoublyLinkedListNode<T> current = head;

            while (current != null)
            {
                Console.Write(current.Value + " ");
                current = current.Next;
            }

            Console.WriteLine();
        }

        public void PrintBackward()
        {
            DoublyLinkedListNode<T> current = tail;

            while (current != null)
            {
                Console.Write(current.Value + " ");
                current = current.Previous;
            }

            Console.WriteLine();
        }
    }

    class Programz
    {
        static void Main()
        {
            DoublyLinkedList<int> list = new DoublyLinkedList<int>();

            list.AddLast(10);
            list.AddLast(20);
            list.AddFirst(5);

            list.PrintForward(); 
            list.PrintBackward(); 

            list.Remove(10);

            list.PrintForward();

            Console.WriteLine($"Кількість елементів у списку: {list.Count}");
            Console.WriteLine($"Список порожній: {list.IsEmpty}");
        }
    }
}
