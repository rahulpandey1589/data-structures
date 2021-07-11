using DataStructures.Common;
using System;

namespace DataStructures.LinkedList
{
    public class LinkedListWrapper<T>
    {
        private Node<T> head;
        public int Count { get; private set; }

        public LinkedListWrapper()
        {
            head = null;
            Count = 0;
        }

        public bool IsEmpty() => head == null;
        


        public void AddFront(T data)
        {
            Node<T> newNode = new Node<T>(data,null);
            newNode.next = head;
            head = newNode;
            Count++;
        }


        public void AddLast(T data)
        {
            if (head is not null)
            {
                Node<T> newNode = new Node<T>(data,head.next);
                head.next = newNode;
                Count++;
            }
        }

        public void PrintList()
        {
            Node<T> runner = head;
            while (runner != null)
            {
                if (runner.value is Employee)
                {
                    var currentValue = runner.value.GetType();
                    var propValue = currentValue.GetProperty("FirstName");
                    Console.WriteLine(currentValue.GetProperty("FirstName"));
                }


                runner = runner.next;
            }
        }
    }
}
