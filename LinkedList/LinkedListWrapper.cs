using DataStructures.Common;
using System;

namespace DataStructures.LinkedList
{
    public class LinkedListWrapper<T>
    {
        private Node<T> head;
        private Node<T> tempNode;

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
                tempNode = head;
                while(tempNode.next != null)
                {
                    tempNode = tempNode.next;
                }

                Node<T> newNode = new Node<T>(data);
                tempNode.next = newNode;
                Count++;
            }
        }
    }
}
