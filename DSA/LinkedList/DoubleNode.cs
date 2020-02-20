using System;
using System.Collections.Generic;
using System.Text;

namespace linkedlist
{
    public class DoubleNode<T>
    {
        /// <summary>
        /// Creates a node with the given value along with next and previous pointer.
        /// </summary>
        /// <param name="value">The value which will be assigned to the node</param>
        public DoubleNode(T value)
        {
            this.Value = value;
            this.Next = null;
            this.Previous = null;
        }

        /// <summary>
        /// The value of the node.
        /// </summary>
        public T Value { get; set; }

        /// <summary>
        /// The pointer to the next node
        /// </summary>
        public DoubleNode<T> Next { get; set; }

        /// <summary>
        /// The pointer to the previous node
        /// </summary>
        public DoubleNode<T> Previous { get; set; }
    }
}
