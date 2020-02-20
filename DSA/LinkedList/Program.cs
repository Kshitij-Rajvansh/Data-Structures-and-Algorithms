using System;
using System.Linq;

namespace linkedlist
{
    class Program
    {
        static void Main(string[] args)
        {
            //LinkedList<int> list = new LinkedList<int>();
            //list.AddFirst(1);
            //list.AddLast(2);
            //list.AddLast(3);
            //list.AddFirst(5);

            //foreach (var item in list)
            //{
            //    Console.Write(item + "-->");
            //}

            DoublyLinkedList<int> doublyList = new DoublyLinkedList<int>();
            doublyList.Add(2);
            //doublyList.Add(3);
            //doublyList.Add(4);
            //doublyList.Add(5);

            doublyList.Remove(4);

            Console.ReadLine();
        }
    }
}
