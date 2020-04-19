using System;

namespace Heap
{
    public class MinIntHeap
    {
        private int capacity = 10;
        public int size { get; private set; }
        public int[] items { get; private set; }

        public MinIntHeap()
        {
            items = new int[capacity];
            size = 0;
        }

        private int getLeftChildIndex(int parentIndex)
        {
            return 2 * parentIndex + 1;
        }
        private int getRightChildIndex(int parentIndex)
        {
            return 2 * parentIndex + 2;
        }
        private int getParentIndex(int childIndex)
        {
            return (childIndex - 1) / 2;
        }

        private bool hasLeftChild (int index)
        {
            return getLeftChildIndex(index) < size;
        }
        private bool hasRightChild(int index)
        {
            return getRightChildIndex(index) < size;
        }
        private bool hasParent(int index)
        {
            return getParentIndex(index) >= 0;
        }

        private int leftChild(int index)
        {
            return items[getLeftChildIndex(index)];
        }
        private int rightChild(int index)
        {
            return items[getRightChildIndex(index)];
        }
        private int parent(int index)
        {
            return items[getParentIndex(index)];
        }

        private void swap(int indexOne, int indexTwo)
        {
            int temp = items[indexOne];
            items[indexOne] = items[indexTwo];
            items[indexTwo] = temp;
        }

        private void ensureExtraCapacity()
        {
            if(size == capacity)
            {
                int[] newArray = new int[capacity * 2];
                items.CopyTo(newArray, 0);
                items = newArray;
                capacity *= 2;
            }
        }

        public int peek()
        {
            if(size == 0)
            {
                throw new InvalidOperationException();
            }

            return items[0];
        }
        // removes the min element from heap
        public int poll()
        {
            if(size == 0)
            {
                throw new InvalidOperationException();
            }

            int item = items[0];
            items[0] = items[size -1];
            size--;
            heapifyDown();

            return item;
        }

        public void add(int item)
        {
            ensureExtraCapacity();
            items[size] = item;
            size++;
            heapifyUp();
        }

        public void heapifyUp()
        {
            int index = size - 1;

            while(hasParent(index) && parent(index) > items[index])
            {
                swap(getParentIndex(index), index);
                index = getParentIndex(index);
            }
        }
        public void heapifyDown()
        {
            int index = 0;

            while(hasLeftChild(index))
            {
                int smallerChildIndex = getLeftChildIndex(index);

                if(hasRightChild(index) && rightChild(index) < leftChild(index))
                {
                    smallerChildIndex = getRightChildIndex(index);
                }

                if(items[index] < items[smallerChildIndex])
                {
                    break;
                }
                else
                {
                    swap(index, smallerChildIndex);
                }

                index = smallerChildIndex;
            }
        }
    }
}