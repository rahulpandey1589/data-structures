using System;

namespace DataStructures.LinkedList
{
    public class LinkedListWrapper<T>
    {
        public Node<T> head;
        internal Node<T> tempNode { get; private set;}

        public int Count { get; private set; }

        public LinkedListWrapper()
        {
            head = null;
            Count = 0;
        }

        public bool IsEmpty() => head == null;

        public void AddHead(T data)
        {
            Node<T> newNode = new Node<T>(data, null);
            newNode.next = head;
            head = newNode;
            Count++;
        }

        public void AddToLast(T data)
        {
            if (head is not null)
            {
                tempNode = head;
                while (tempNode.next != null)
                {
                    tempNode = tempNode.next;
                }

                Node<T> newNode = new Node<T>(data);
                tempNode.next = newNode;
                Count++;
            }
        }

        public Node<T> Find(T item)
        {
            Node<T> currentNode = head;

            while (currentNode.next != null)
            {
                if (currentNode.value.Equals(item))
                {
                    return currentNode;
                }

                currentNode = currentNode.next;
            }
            return null;
        }

        public void Delete(Node<T> node)
        {
            Node<T> current = head;
            Node<T> previous = null;

            while (!current.value.Equals(node.value))
            {
                previous = current;
                current = current.next;
            }

            if (current.value.Equals(node.value))
            {
                previous.next = previous.next.next;
                current = null;
                Count--;
            }
        }

        public void Delete(T item)
        {
            var nodeToBeDeleted = Find(item);
            if (nodeToBeDeleted == null)
            {
                Console.WriteLine($"No item exists in linkedlist with value as {item}");
                return;
            }
        }

        public void AddAtAfter(
            Node<T> currentNode,
            T itemToBeAdded
            )
        {
            if (head is not null)
            {
                Node<T> nodeToBeAdded = new Node<T>(itemToBeAdded);
                nodeToBeAdded.next = currentNode.next;
                currentNode.next = nodeToBeAdded;
                Count++;
            }
        }

        public void Print()
        {
            Node<T> tempNode;
            tempNode = head;
            while (tempNode.next != null)
            {
                Console.WriteLine($"The next item is {head.value}");
                tempNode = tempNode.next;
            }
        }
    }
}
