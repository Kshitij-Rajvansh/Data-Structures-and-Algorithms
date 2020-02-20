using System;
using System.Collections;
using System.Collections.Generic;

namespace linkedlist
{
    /// <summary>
    /// A Linked list collection capable of adding, removing, searching and enumerating
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class LinkedList<T> : ICollection<T>
    {
        /// <summary>
        /// InitializesB an empty List
        /// </summary>
        public LinkedList()
        {
            Head = null;
            Tail = null;
            Count = 0;
        }

        /// <summary>
        /// The first node in the list, (null if list is empty)
        /// </summary>
        public Node<T> Head
        {
            get;
            private set;
        }

        /// <summary>
        /// The last node of the list, (null if list is empty)
        /// </summary>
        public Node<T> Tail
        {
            get;
            private set;
        }

        #region Add Methods
        /// <summary>
        /// Adds the given value to thre start of the list.
        /// </summary>
        /// <param name="value">The value to add at the start of the list</param>
        public void AddFirst(T value)
        {
            AddFirst(new Node<T>(value));
        }
        /// <summary>
        /// Adds the given node to the start of the list.
        /// </summary>
        /// <param name="node">The node to add at the start of the list</param>
        public void AddFirst(Node<T> node)
        {
            Node<T> temp = Head;

            Head = node;

            Head.Next = temp;

            Count++;

            if(Count == 1)
            {
                Tail = Head;
            }
        }

        /// <summary>
        /// Adds the given value to the last of the list.
        /// </summary>
        /// <param name="value">The value to add at the end of the list</param>
        public void AddLast(T value)
        {
            AddLast(new Node<T>(value));
        }

        /// <summary>
        /// Adds the given node to the last of the list.
        /// </summary>
        /// <param name="node">The node to add at the last of the list.</param>
        public void AddLast(Node<T> node)
        {
            if(Count == 0)
            {
                Head = node;
            }
            else
            {
                Tail.Next = node;
            }

            Tail = node;

            Count++;
        }
        #endregion

        #region Remove Methods
        /// <summary>
        /// Removes the first node from the list.
        /// </summary>
        public void RemoveFirst()
        {
            if(Count != 0)
            {
                Head = Head.Next;

                Count--;

                if(Count == 0)
                {
                    Tail = null;
                }
            }
        }

        /// <summary>
        /// Removes the last node from the list.
        /// </summary>
        public void RemoveLast()
        {
            if (Count != 0)
            {
                if(Count == 1)
                {
                    Head = null;
                    Tail = null;
                }
                else
                {
                    Node<T> current = Head;
                    
                    while(current.Next != Tail)
                    {
                        current = current.Next;
                    }

                    current.Next = null;
                    Tail = current;
                }

                Count--;
            }
        }
        #endregion

        #region ICollection
        /// <summary>
        /// Number of nodes in the linked list, ( 0, if list is empty)
        /// </summary>
        public int Count
        {
            get;
            private set;
        }

        /// <summary>
        /// Returns true if collection is readonly, false otherwise.
        /// </summary>
        public bool IsReadOnly
        {
            get
            {
                return false;
            }
        }

        /// <summary>
        /// Adds the item to the last of the list
        /// </summary>
        /// <param name="item">The item to add at the last of the list.</param>
        public void Add(T item)
        {
            AddLast(item);
        }

        /// <summary>
        /// Clears the list.
        /// </summary>
        public void Clear()
        {
            Head = null;
            Tail = null;
            Count = 0;
        }

        /// <summary>
        /// This method returns true if it contains the given element, false otherwise
        /// </summary>
        /// <param name="item">Item to check in the list.</param>
        /// <returns></returns>
        public bool Contains(T item)
        {
            Node<T> current = Head;

            while(current != null)
            {
                if (current.Value.Equals(item))
                {
                    return true;
                }

                current = current.Next;
            }

            return false;
        }

        /// <summary>
        /// This method copies the current list elements to an array.
        /// </summary>
        /// <param name="array">The array where the list needs to be copied to.</param>
        /// <param name="arrayIndex">The index of the array where to start copying.</param>
        public void CopyTo(T[] array, int arrayIndex)
        {
            Node<T> current = Head;

            while(current != null)
            {
                array[arrayIndex++] = current.Value;
                current = current.Next;
            }
        }

        /// <summary>
        /// Removes the given item from the list.
        /// </summary>
        /// <param name="item">The item to be removed.</param>
        /// <returns></returns>
        public bool Remove(T item)
        {
            Node<T> current = Head;
            Node<T> previous = null;

            while(current != null)
            {
                if (current.Value.Equals(item))
                {
                    if(previous != null)
                    {
                        previous.Next = current.Next;

                        if(current.Next == null)
                        {
                            Tail = previous;
                        }

                        Count--;
                    }
                    else
                    {
                        RemoveFirst();
                    }

                    return true;
                }

                previous = current;
                current = current.Next;
            }

            return false;
        }

        public IEnumerator<T> GetEnumerator()
        {
            Node<T> current = Head;

            while (current != null)
            {
                yield return current.Value;
                current = current.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
        #endregion
    }
}