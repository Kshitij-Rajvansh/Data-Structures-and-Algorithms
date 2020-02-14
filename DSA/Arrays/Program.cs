using System;
using System.Collections.Generic;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            ResizableArrays<int> arr = new ResizableArrays<int>();
            arr.Add(1);
            arr.Add(2);
            arr.Add(3);
            arr.Add(5);

            // Using List<t>
            List<string> dynamicArray = new List<string>();
            dynamicArray.Add("akash");
            dynamicArray.Add("deepak");
            dynamicArray.Add("aakash");
            dynamicArray.Add("zoho");

            dynamicArray.Sort();
            foreach (string item in dynamicArray)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine($"Size of resizable array {arr.Count}");

            Console.WriteLine(dynamicArray[2]);

            Console.ReadLine();
        }
    }
}
