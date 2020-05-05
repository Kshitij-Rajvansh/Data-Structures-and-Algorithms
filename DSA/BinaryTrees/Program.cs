using System.Drawing;
using System;

namespace BinaryTrees
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree<int> tree = new BinaryTree<int>();
            tree.Add(5);
            tree.Add(6);
            tree.Add(8);
            tree.Add(4);
            tree.Add(3);
            tree.Add(2);
            tree.Add(9);
            tree.Add(1);

            tree.LevelOrderTraversal(tree.GetRoot());

            Console.ReadLine();
        }
    }
}
