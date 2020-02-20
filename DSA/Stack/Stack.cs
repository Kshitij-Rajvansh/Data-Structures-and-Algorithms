using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Stack
{
    /// <summary>
    /// A stack collection capable of adding and removing elements
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Stack<T> : IEnumerable<T>
    {
        private LinkedList<T> _list;

        public Stack()
        {
            this._list = new LinkedList<T>();
            this.Count = 0;
        }

        public int Count
        {
            get;
            private set;
        }

        public bool IsReadOnly
        {
            get
            {
                return false;
            }
        }

        /// <summary>
        /// This method adds the element to the stack.
        /// </summary>
        /// <param name="item">The item to be added on the stack.</param>
        public void Push(T item)
        {
            _list.AddFirst(item);
            Count++;
        }

        public T Pop()
        {
            if (_list.Count == 0)
            {
                throw new InvalidOperationException("Stack is empty.");
            }

            T item = _list.First.Value;
            _list.RemoveFirst();
            Count--;

            return item;
        }

        public T Peek()
        {
            if (_list.Count == 0)
            {
                throw new InvalidOperationException("Stack is empty.");
            }

            T item = _list.First.Value;

            return item;
        }

        public void Add(T item)
        {
            Push(item);
        }

        public void Clear()
        {
            _list.Clear();
            Count = 0;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return _list.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
