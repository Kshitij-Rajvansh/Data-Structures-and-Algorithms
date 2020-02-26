using System;
using System.Linq;

namespace linkedlist
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> list = new LinkedList<int>();
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Add(6);

            Node<int> reversed = ReverseLinkedList(list.Head);

            while (reversed != null)
            {
                Console.Write(reversed.Value + "-->");
                reversed = reversed.Next;
            }

           

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

        #region Function to find the middle of the linked list
            public static Node<int> GetMiddleNode(Node<int> head)
            {
                if(head == null || head.Next == null)
                {
                    return head;
                }
                
                Node<int> slow = head;
                Node<int> fast = head;

                while(fast.Next != null && fast.Next.Next != null)
                {
                    slow = slow.Next;
                    fast = fast.Next.Next;
                }

                return slow;
            }
        #endregion

        #region Function to reverse a linked list
            public static Node<int> ReverseLinkedList(Node<int> head)
            {
                if(head == null || head.Next == null)
                {
                    return null;
                }

                Node<int> prev = null;
                Node<int> curr = head;
                Node<int> next = null;

                while(curr != null)
                {
                    next = curr.Next;
                    curr.Next = prev;
                    prev = curr;
                    curr = next;
                }

                return prev;
            }
        #endregion

        #region Function
        #endregion
    }
}
