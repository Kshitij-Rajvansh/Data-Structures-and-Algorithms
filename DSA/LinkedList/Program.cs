using System;
using System.Linq;

namespace linkedlist
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> list = new LinkedList<int>();
            list.AddFirst(1);
            list.AddLast(0);
            list.AddLast(2);
            list.Add(1);
            list.Add(0);
            list.Add(2);

            SortZeroOneTwo(list.Head);

            Console.ReadLine();
        }

        #region Function to sort linked list containing 0's, 1's and 2's
            public static Node<int> SortZeroOneTwo(Node<int> head)
            {
                if(head == null || head.Next == null)
                {
                    return head;
                }
                
                // just dummy nodes
                Node<int> zeroD = new Node<int>(0);
                Node<int> oneD = new Node<int>(0);
                Node<int> twoD = new Node<int>(0);

                Node<int> curr = head;
                Node<int> zero = zeroD;
                Node<int> one = oneD;
                Node<int> two = twoD;

                while(curr != null)
                {
                    if(curr.Value == 0)
                    {
                        zero.Next = curr;
                        zero = zero.Next;
                        curr = curr.Next;
                    }
                    else if(curr.Value == 1)
                    {
                        one.Next = curr;
                        one = oneD.Next;
                        curr = curr.Next;
                    }
                    else
                    {
                        two.Next = curr;
                        two = two.Next;
                        curr = curr.Next;
                    }
                }

                // Attach three lists  
                    zero.Next = (oneD.Next != null) ? (oneD.Next) : (twoD.Next);  
                    one.Next = twoD.Next;  
                    two.Next = null; 
          
                    // Updated head  
                    head = zeroD.Next; 
                    return head;
            }
        #endregion
    }
}
