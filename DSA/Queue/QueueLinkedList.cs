using System;
using System.Collections.Generic;
using System.Text;

namespace Queue
{
    /// <summary>
    /// A first in first out collection implemented using LinkedList
    /// </summary>
    /// <typeparam name="T">Type of data you want to store in the FIFO collection</typeparam>
    public class QueueLinkedList<T>
    {
        private System.Collections.Generic.LinkedList<T> _list;

        public QueueLinkedList()
        {
            _list = new System.Collections.Generic.LinkedList<T>();
        }

        public int Count
        {
            get
            {
                return _list.Count;
            }
        }

        /// <summary>
        /// This method adds the given element to the queue.
        /// </summary>
        /// <param name="item">The value to be added to the queue.</param>
        public void Enqueue(T item)
        {
            _list.AddLast(item);
        }

        /// <summary>
        /// This methods removes the first element from the queue.
        /// </summary>
        /// <returns>Returns the first element removed from the queue.</returns>
        public T Dequeue()
        {
            if(_list.Count == 0)
            {
                throw new InvalidOperationException("Queue is empty.");
            }

            T item = _list.First.Value;
            _list.RemoveFirst();

            return item;
        }

    }
}
