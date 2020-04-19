using System;

namespace Heap
{
    class Program
    {
        static void Main(string[] args)
        {
            MinIntHeap heap = new MinIntHeap();

            heap.add(15);
            heap.add(10);
            heap.add(12);

            Console.ReadLine();
        }
    }
}
