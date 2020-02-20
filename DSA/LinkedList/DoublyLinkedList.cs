using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace linkedlist
{
    /// <summary>
    /// A Doubly Linked list collection capable of adding, removing, searching and enumerating
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class DoublyLinkedList<T> : ICollection<T>
    {
        public DoublyLinkedList()
        {
            this.Head = null;
            this.Tail = null;
            this.Count = 0;
        }

        public DoubleNode<T> Head
        {
            get;
            private set;
        }

        public DoubleNode<T> Tail
        {
            get;
            private set;
        }

        #region Add Methods
        /// <summary>
        /// This method adds the given item to the begining of the list.
        /// </summary>
        /// <param name="item">The item to add at the begining of the list.</param>
        public void AddFirst(T item)
        {
            AddFirst(new DoubleNode<T>(item));
        }

        /// <summary>
        /// This method adds the given DoubleNode<> to the begining of the list.
        /// </summary>
        /// <param name="node">The DoubleNode<T> to add at the begining of the list.</param>
        public void AddFirst(DoubleNode<T> node)
        {
            DoubleNode<T> temp = Head;

            Head = node;
            Head.Next = temp;
            temp.Previous = Head;

            Count++;

            if(Count == 1)
            {
                Tail = Head;
            }
        }

        /// <summary>
        /// This method adds the given item to the last of the list.
        /// </summary>
        /// <param name="item">The item to add at the last of the list</param>
        public void AddLast(T item)
        {
            AddLast(new DoubleNode<T>(item));
        }

        /// <summary>
        /// This method adds the given node to the end of the list.
        /// </summary>
        /// <param name="node">The node to add at the last of the list</param>
        public void AddLast(DoubleNode<T> node)
        {
            if(Count == 0)
            {
                Head = node;
            }
            else
            {
                Tail.Next = node;
                node.Previous = Tail;
            }

            Tail = node;
            Count++;
        }
        #endregion

        #region Remove Methods
        /// <summary>
        /// Removes the first element from the list;
        /// </summary>
        public void RemoveFirst()
        {
            Head = Head.Next;

            Count--;

            if(Count == 0)
            {
                Tail = null;
            }
            else
            {
                Head.Previous = null;
            }
        }

        /// <summary>
        /// Removes the last element from the list
        /// </summary>
        public void RemoveLast()
        {
            if(Count == 1)
            {
                Head = null;
                Tail = null;
            }

            Tail = Tail.Previous;
            Tail.Next = null;

            Count--;
        }
        #endregion

        #region ICollection
        public int Count
        {
            get;
            private set;
        }

        /// <summary>
        /// Returns true if collection is read only, false otherwise.
        /// </summary>
        public bool IsReadOnly
        {
            get
            {
                return false;
            }
        }

        /// <summary>
        /// Adds the given element to the last of the list.
        /// </summary>
        /// <param name="item">The item to be added to the last of the list.</param>
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

        public bool Contains(T item)
        {
            DoubleNode<T> current = Head;

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

        public void CopyTo(T[] array, int arrayIndex)
        {
            DoubleNode<T> current = Head;

            while (current != null)
            {
                array[arrayIndex++] = current.Value;
                current = current.Next;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            DoubleNode<T> current = Head;

            while(current != null)
            {
                yield return current.Value;
                current = current.Next;
            }
        }

        public bool Remove(T item)
        {
            DoubleNode<T> current = Head;
            DoubleNode<T> previous = null;

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
                        else
                        {
                            current.Next.Previous = previous;
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

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
        #endregion
    }
}
