using System;
using System.Collections.Generic;
using System.Text;
using System.Web;

namespace Arrays
{
    public class ResizableArrays<T>
    {
        private T[] _items;

        public ResizableArrays()
        {
            
        }

        public int Count
        {
            get
            {
                if(this._items == null)
                {
                    return 0;
                }
                else
                {
                    return this._items.Length;
                }
            }
        }

        public void Add(T item)
        {
            if(this._items == null)
            {
                this._items = new T[] { item };
            }
            else
            {
                T[] newArray = new T[this._items.Length + 1]; // initializing a new array with increased size
                
                for(int i = 0; i < this._items.Length; i++)
                {
                    newArray[i] = this._items[i]; // copying the old array to new array
                }

                newArray[this._items.Length] = item; // adding the new value at the end of the new array

                this._items = newArray; // assigning the new array to items array
            }
        }
    }
}
