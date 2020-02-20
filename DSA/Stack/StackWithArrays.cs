using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Stack
{
    /// <summary>
    /// A last in first out collection imlemented as an array.
    /// </summary>
    /// <typeparam name="T">Type of item conatained in the stack.</typeparam>
    public class StackWithArrays<T> : IEnumerable<T>
    {
        private T[] _items;

        private int _size;

        public StackWithArrays()
        {
            this._items = new T[0];
            this._size = 0;
        }

        /// <summary>
        /// This method adds an item to the stack.
        /// </summary>
        /// <param name="value">The item to be pushed on to the stack.</param>
        public void Push(T value)
        {
            if(_size == _items.Length)
            {
                int newSize = _size == 0 ? 4 : _size * 2;

                T[] newArray = new T[newSize];
                _items.CopyTo(newArray, 0);
                _items = newArray;
            }

            _items[_size] = value;
            _size++;
        }

        /// <summary>
        /// This method returns the top element on the stack and removes it from the stack.
        /// </summary>
        /// <returns>Returns the top element removed from the stack.</returns>
        public T Pop()
        {
            if(_size == 0)
            {
                throw new InvalidOperationException("Stack is empty");
            }

            _size--;

            return _items[_size];
        }

        /// <summary>
        /// This method returns the top element from the stack.
        /// </summary>
        /// <returns>Returns the top element on the stack.</returns>

        public T Peek()
        {
            if (_size == 0)
            {
                throw new InvalidOperationException("Stack is empty");
            }

            return _items[_size - 1];
        }

        public int Count
        {
            get
            {
                return _size;
            }
        }

        public void Clear()
        {

        }

        public IEnumerator<T> GetEnumerator()
        {
            for(int i = _size-1; i >= 0; i--)
            {
                yield return _items[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
