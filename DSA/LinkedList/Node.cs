using System;
using System.Collections.Generic;

namespace linkedlist
{
  public class Node<T>
  {
    public T value {get; set;}
    public Node<T> Next {get; set;}

    public Node(T value)
    {
      this.value = value;
      this.Next = null;
    }
  }
}