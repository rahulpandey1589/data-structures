using DataStructures.Common;
using DataStructures.LinkedList;
using System;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Program
               p = new Program();

            p.AddLinkedListNode();
            Console.Read();
        }

        #region Singly Linked List Code

         public void AddLinkedListNode()
        {
            var e1 = GetEmployee("Jane", "Whitely", "Male");
            var e2 = GetEmployee("Sarah", "Atkinson", "Female");
            var e3 = GetEmployee("Julie", "Lerman", "Female");
            var e4 = GetEmployee("Scott", "Hanselman", "Male");



            LinkedListWrapper<Employee> empLinkedList=
                new LinkedListWrapper<Employee>();

            empLinkedList.AddFront(e1);
            empLinkedList.AddFront(e2);

            empLinkedList.PrintList();


            Console.WriteLine($"The current item counts is {empLinkedList.Count}");
        }

        private Employee GetEmployee(
            string firstName,
            string lastName,
            string gender)
        {
            return new Employee(firstName,lastName,gender);
        }

        #endregion
    }
}
