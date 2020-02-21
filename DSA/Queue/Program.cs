using System;

namespace Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            QueueWithArray<int> line = new QueueWithArray<int>();
            line.Enqueue(1);
            line.Enqueue(2);
            line.Enqueue(3);
            line.Enqueue(4);
            line.Enqueue(5);
            line.Enqueue(6);

            Console.ReadKey();
        }
    }
}
