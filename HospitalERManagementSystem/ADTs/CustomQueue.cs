using System;

namespace HospitalERManagementSystem.ADTs
{
    public class CustomQueue<T>
    {
        private class Node
        {
            public T Value;
            public Node? Next;
            public Node? Prev;

            public Node(T value)
            {
                Value = value;
            }
        }

        private Node? _head;
        private Node? _tail;
        private int _count;

        public int Count => _count;

        public bool IsEmpty()
        {
            return _count == 0;
        }

        public void Enqueue(T item)
        {
            Node newNode = new Node(item);

            if (_tail == null)
            {
                _head = newNode;
                _tail = newNode;
            }
            else
            {
                _tail.Next = newNode;
                newNode.Prev = _tail;
                _tail = newNode;
            }

            _count++;
        }

        public T Dequeue()
        {
            if (_head == null)
            {
                throw new InvalidOperationException("Queue is empty.");
            }

            T value = _head.Value;
            _head = _head.Next;

            if (_head != null)
            {
                _head.Prev = null;
            }
            else
            {
                _tail = null;
            }

            _count--;
            return value;
        }

        public T Peek()
        {
            if (_head == null)
            {
                throw new InvalidOperationException("Queue is empty.");
            }

            return _head.Value;
        }

        public void Display()
        {
            if (_head == null)
            {
                Console.WriteLine("[Empty Queue]");
                return;
            }

            Node? current = _head;
            while (current != null)
            {
                Console.WriteLine(current.Value);
                current = current.Next;
            }
        }
    }
}