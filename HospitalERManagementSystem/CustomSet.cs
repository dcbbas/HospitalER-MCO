using System;

namespace HospitalERManagementSystem
{
    public class CustomSet<T>
    {
        private class Node
        {
            public T Data;
            public Node? Next;

            public Node(T data)
            {
                Data = data;
                Next = null;
            }
        }

        private Node? _head;
        public int Count { get; private set; }

        public CustomSet()
        {
            _head = null;
            Count = 0;
        }

        public bool Contains(T item)
        {
            Node? current = _head;
            while (current != null)
            {
                if (Equals(current.Data, item)) return true;
                current = current.Next;
            }
            return false;
        }

        public bool Add(T item)
        {
            if (Contains(item)) return false;

            Node newNode = new Node(item);
            newNode.Next = _head;
            _head = newNode;
            Count++;
            return true;
        }

        public bool Remove(T item)
        {
            Node? current = _head;
            Node? prev = null;

            while (current != null)
            {
                if (Equals(current.Data, item))
                {
                    if (prev == null) _head = current.Next;
                    else prev.Next = current.Next;
                    Count--;
                    return true;
                }
                prev = current;
                current = current.Next;
            }
            return false;
        }

        public CustomSet<T> Union(CustomSet<T> otherSet)
        {
            CustomSet<T> result = new CustomSet<T>();
            Node? current = _head;
            while (current != null)
            {
                result.Add(current.Data);
                current = current.Next;
            }

            Node? otherCurrent = otherSet._head;
            while (otherCurrent != null)
            {
                result.Add(otherCurrent.Data);
                otherCurrent = otherCurrent.Next;
            }
            return result;
        }

        public CustomSet<T> Intersection(CustomSet<T> otherSet)
        {
            CustomSet<T> result = new CustomSet<T>();
            Node? current = _head;
            while (current != null)
            {
                if (otherSet.Contains(current.Data))
                {
                    result.Add(current.Data);
                }
                current = current.Next;
            }
            return result;
        }

        public CustomSet<T> Difference(CustomSet<T> otherSet)
        {
            CustomSet<T> result = new CustomSet<T>();
            Node? current = _head;
            while (current != null)
            {
                if (!otherSet.Contains(current.Data))
                {
                    result.Add(current.Data);
                }
                current = current.Next;
            }
            return result;
        }

        public void Display()
        {
            if (_head == null)
            {
                Console.WriteLine("  None recorded.");
                return;
            }

            Node? current = _head;
            while (current != null)
            {
                Console.WriteLine("  - " + current.Data);
                current = current.Next;
            }
        }
    }
}