using System;
using System.Collections.Generic;

namespace linkedlist
{
  public class LinkedList<T> : ICollection<T>
  {
    private Node<T> _head;
    private Node<T> _tail;

    public LinkedList()
    {
      _head = null;
      _tail = null;
    }

    public LinkedList(T value)
    {
      Node<T> firstNode = new Node<T>(value);
      _head = firstNode;
      _tail = _head;

      Count++;
    }

    public void Add(T item)
    {
      if(_head != null)
      {
        Node<T> newNode = new Node<T>(item);
        _tail.Next = newNode;
        _tail = newNode;
      }
      else
      {
        Node<T> newNode = new Node<T>(item);
        _head = newNode;
        _tail = newNode;
      }

      Count++;
    }
    public void Clear()
    {
      _head = null;
      _tail = null;
      Count = 0;
    }
    public bool Contains(T item)
    {
      Node<T> currentNode = _head;
      while(currentNode.Next != null)
      {
        if(currentNode.value.Equals(item))
        {
          return true;
        }
        currentNode = currentNode.Next;
      }
      return false;
    }
    public void CopyTo(T[] array, int arrayIndex)
    {
      Node<T> currentNode = _head;
      while(currentNode.Next != null)
      {
        array[arrayIndex++] = currentNode.value;
        currentNode = currentNode.Next;
      }
    }
    public int Count
    {
      get;
      private set;
    }

    public bool IsReadOnly
    {
      get { return false; }
    }
    public bool Remove(T item)
    {
      Node<T> previousNode = null;
      Node<T> currentNode = _head;

      while(currentNode != null)
      {
        if(currentNode.value.Equals(item))
        {
          if(previousNode != null)
          {
            previousNode.Next = currentNode.Next;

            if(currentNode.Next == null)
            {
              _tail = previousNode;
            }
          }
          else
          {
            _head = _head.Next;
            if(_head == null)
            {
              _tail = null;
            }
          }
          Count--;
          return true;
        }

        previousNode = currentNode;
        currentNode = currentNode.Next;
      }
      return false;
    }
    public System.Collections.Generic.IEnumerator<T> GetEnumerator()
    {
      Node<T> current = _head;
      while (current != null)
      {
      yield return current.value;
      current = current.Next;
      }
    }
    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
    {
      return ((IEnumerable<T>)this).GetEnumerator();
    }
  }
}