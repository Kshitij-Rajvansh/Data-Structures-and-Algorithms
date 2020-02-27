using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace BinaryTrees
{
    public class BinaryTreeNode<TNode> : IComparable<TNode> where TNode : IComparable<TNode>
    {
        public BinaryTreeNode(TNode data)
        {
            this.Value = data;
            this.Left = null;
            this.Right = null;
        }
        public BinaryTreeNode<TNode> Left { get; set; }
        public BinaryTreeNode<TNode> Right { get; set; }
        public TNode Value { get; private set; }
        public int CompareTo([AllowNull] TNode other)
        {
            return this.Value.CompareTo(other);
        }
    }
}