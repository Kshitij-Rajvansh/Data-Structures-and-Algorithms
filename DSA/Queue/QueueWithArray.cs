using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Queue
{
    /// <summary>
    /// A first in first out collection implemented using Arrays
    /// </summary>
    /// <typeparam name="T">Type of data you want to store in a queue.</typeparam>
    public class QueueWithArray<T> : IEnumerable<T>
    {
        private T[] _items;

        private int _size;

        private int _head;

        private int _tail;

        public QueueWithArray()
        {
            this._items = new T[0];
            this._size = 0;
            this._head = 0;
            this._tail = -1;
        }

        /// <summary>
        /// This method inserts an item into the queue.
        /// </summary>
        /// <param name="item">The item to be inserted into the queue.</param>
        public void Enqueue(T item)
        {
            if(_size == _items.Length)
            {
                int newSize = _size == 0 ? 4 : _size * 2;

                T[] newArray = new T[newSize];
                
                if(_size > 0)
                {
                    int targetIndex = 0;

                    if(_tail < _head)
                    {
                        for(int i = _head; i < _items.Length; i++)
                        {
                            newArray[targetIndex] = _items[i];
                            targetIndex++;
                        }

                        for(int i = 0; i <= _tail; i++)
                        {
                            newArray[targetIndex] = _items[i];
                            targetIndex++;
                        }
                    }
                    else
                    {
                        for(int i = _head; i <= _tail; i++)
                        {
                            newArray[targetIndex] = _items[i];
                            targetIndex++;
                        }
                    }

                    _head = 0;
                    _tail = targetIndex - 1;
                }
                else
                {
                    _head = 0;
                    _tail = -1;
                }

                _items = newArray;
            }

            if(_tail == _items.Length)
            {
                _tail = 0;
            }
            else
            {
                _tail++;
            }

            _items[_tail] = item;
            _size++;
        }

        /// <summary>
        /// This method removes an item from the queue.
        /// </summary>
        /// <returns>Returns the item removed from the queue.</returns>
        public T Dequeue()
        {
            if (_size == 0)
            {
                throw new InvalidOperationException("Queue is empty.");
            }

            T value = _items[_head];

            if(_head == _items.Length - 1)
            {
                _head = 0;
            }
            else
            {
                _head++;
            }

            _size--;
            return value;
        }

        /// <summary>
        /// This method returns the first element in the queue.
        /// </summary>
        /// <returns>Returns the begining element of the queue.</returns>
        public T Peek()
        {
            if(_size == 0)
            {
                throw new InvalidOperationException("Queue is empty.");
            }

            return _items[_head];
        }

        public IEnumerator<T> GetEnumerator()
        {
            if(_size > 0)
            {
                if (_tail < _head)
                {
                    for (int i = _head; i < _items.Length; i++)
                    {
                        yield return _items[i];
                    }

                    for (int i = 0; i <= _tail; i++)
                    {
                        yield return _items[i];
                    }
                }
                else
                {
                    for (int i = _head; i <= _tail; i++)
                    {
                        yield return _items[i];
                    }
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
