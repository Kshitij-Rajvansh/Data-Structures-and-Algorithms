using System;
using System.Collections.Generic;

namespace linkedlist
{
    /// <summary>
    /// A node in the LinkedList
    /// </summary>
    /// <typeparam name="T"></typeparam>
  public class Node<T>
  {
    /// <summary>
    /// Creates a new Node with the supplied value
    /// </summary>
    /// <param name="value"></param>
    public Node(T value)
    {
      this.Value = value;
      this.Next = null;
    }
    
    /// <summary>
    /// The node value
    /// </summary>
    public T Value { get; set; }

    /// <summary>
    /// The pointer to next node in the list, (null if it is last node)
    /// </summary>
    public Node<T> Next { get; set; }

    }
}