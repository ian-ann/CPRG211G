using System;
using System.Collections.Generic;
using System.Reflection;

namespace Utility
{
    [Serializable]
    public class SLL<T> : ILinkedListADT<T>
    {
        private Node<T> head;
        private int size;

        public SLL()
        {
            head = null;
            size = 0;
        }

        public void Add(T item)
        {
            if (head == null)
            {
                Node<T> newNode = new Node<T>(item);
                newNode.Next = head;
                head = newNode;
            }
            else
            {
                throw new Exception("List already has an existing record, use AddLast or AddFirst");
            }
            size++;
        }

        public void AddFirst(T item)
        {
            Node<T> newNode = new Node<T>(item);
            newNode.Next = head;
            head = newNode;
            size++;
        }

        public void AddLast(T item)
        {
            Node<T> newNode = new Node<T>(item);
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                Node<T> current = head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
            }
            size++;
        }

        public void Remove(int index)
        {
            if (index < 0 || index >= size)
            {
                throw new IndexOutOfRangeException("Index out of bounds");
            }
            if (index == 0)
            {
                RemoveFirst();
                return;
            }
            Node<T> current = head;
            for (int i = 0; i < index - 1; i++)
            {
                current = current.Next;
            }
            current.Next = current.Next.Next;
            size--;
        }

        public void RemoveFirst()
        {
            if (head == null)
            {
                throw new InvalidOperationException("List is empty");
            }
            head = head.Next;
            size--;
        }

        public void RemoveLast()
        {
            if (head == null)
            {
                throw new InvalidOperationException("List is empty");
            }
            if (head.Next == null)
            {
                head = null;
            }
            else
            {
                Node<T> current = head;
                while (current.Next.Next != null)
                {
                    current = current.Next;
                }
                current.Next = null;
            }
            size--;
        }

        public void InsertAt(int index, T item)
        {
            if (index < 0 || index > size)
            {
                throw new IndexOutOfRangeException("Index out of bounds");
            }
            if (index == 0)
            {
                AddFirst(item);
                return;
            }
            Node<T> newNode = new Node<T>(item);
            Node<T> current = head;
            for (int i = 0; i < index - 1; i++)
            {
                current = current.Next;
            }
            newNode.Next = current.Next;
            current.Next = newNode;
            size++;
        }

        public void Replace(int index, T item)
        {
            if (index < 0 || index >= size)
            {
                throw new IndexOutOfRangeException("Index out of bounds");
            }
            Node<T> current = head;
            for (int i = 0; i < index; i++)
            {
                current = current.Next;
            }
            current.Data = item;
        }

        public T GetValue(int index)
        {
            if (index < 0 || index >= size)
            {
                throw new IndexOutOfRangeException("Index out of bounds");
            }
            Node<T> current = head;
            for (int i = 0; i < index; i++)
            {
                current = current.Next;
            }
            return current.Data;
        }

        public int IndexOf(T item)
        {
            Node<T> current = head;
            for (int i = 0; i < size; i++)
            {
                if (current.Data.Equals(item))
                {
                    return i;
                }
                current = current.Next;
            }
            return -1;
        }

        public bool Contains(T item)
        {
            return IndexOf(item) != -1;
        }

        public void Clear()
        {
            head = null;
            size = 0;
        }

        public int Count()
        {
            return size;
        }

        public void Reverse()
        {
            Node<T> prev = null;
            Node<T> current = head;
            Node<T> next = null;
            while (current != null)
            {
                next = current.Next;
                current.Next = prev;
                prev = current;
                current = next;
            }
            head = prev;
        }

        public bool IsEmpty()
        {
            return size == 0;
        }
    }
}
