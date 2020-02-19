using System;
using System.Linq;
using System.Text;

namespace linkedlist
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> list = new LinkedList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);

            list.Remove(2);

            foreach (int item in list)
            {
                Console.Write(item + "-->");
            }
            // LinkedListNode<int> single = list.First;
            // LinkedListNode<int> twice = list.First;

            // while(twice.Next != null && twice.Next.Next != null)
            // {
            //     single = single.Next;
            //     twice = twice.Next.Next;
            // }

            // Console.WriteLine("The middle element of linked list is : " + single.Value);
        }
    }
}
