using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace BinaryTrees
{
    public class BinaryTree<T> : IEnumerable<T> where T : IComparable<T>
    {
        public BinaryTree()
        {

        }

        private BinaryTreeNode<T> _root;

        private int _count;

        public BinaryTreeNode<T> GetRoot()
        {
            return this._root;
        }

        #region Add a node to the tree
        public void Add(T data)
        {
            if(_root == null)
            {
                _root = new BinaryTreeNode<T>(data);
            }
            else
            {
                AddTo(_root, data);
            }

            _count++;
        }

        private void AddTo(BinaryTreeNode<T> node, T data)
        {
            // if value is less than current node
            if(node.Value.CompareTo(data) > 0)
            {
                if(node.Left == null)
                {
                    node.Left = new BinaryTreeNode<T>(data);
                }
                else
                {
                    AddTo(node.Left, data);
                }
            }
            // if value is greater than or equal to
            else
            {
                if(node.Right == null)
                {
                    node.Right = new BinaryTreeNode<T>(data);
                }
                else
                {
                    AddTo(node.Right, data);
                }
            }
        }
        #endregion

        #region Find
        public bool Contains(T data)
        {
            BinaryTreeNode<T> parent;

            return FindWithParent(data, out parent) != null;
        }
        private BinaryTreeNode<T> FindWithParent(T data, out BinaryTreeNode<T> parent)
        {
            BinaryTreeNode<T> current = _root;
            parent = null;

            while (current != null)
            {
                int result = current.Value.CompareTo(data);

                if(result > 0) // if given value is less than node value 
                {
                    parent = current;
                    current = current.Left;
                }
                else if(result < 0) // if given value is greater than node value
                {
                    parent = current;
                    current = current.Right;
                }
                else
                {
                    break;
                }
            }

            return current;
        }
        #endregion

        #region Remove
        //public bool Remove(T value)
        //{
        //    BinaryTreeNode<T> current, parent;

        //    current = FindWithParent(value, out parent);

        //    if(current == null)
        //    {
        //        return false;
        //    }

        //    // Case 1: if current has no right child, then current's left becomes current
        //    if(current.Right == null)
        //    {
        //        if(parent == null)
        //        {
        //            _root = current.Left;
        //        }
        //        else
        //        {
        //            int result = parent.CompareTo(value);

        //            if(result > 0)
        //            {
        //                parent.Left = current.Left;
        //            }
        //            else if(result < 0)
        //            {
        //                parent.Right = current.Right;
        //            }
        //        }
        //    }
        //    else if(current.Right.Left == null)
        //    {
        //        current.Right.Left = current.Left;

        //        if (parent == null)
        //        {
        //            _root = current.Left;
        //        }
        //        else
        //        {
        //            int result = parent.CompareTo(value);

        //            if (result > 0)
        //            {
        //                parent.Left = current.Right;
        //            }
        //            else if (result < 0)
        //            {
        //                parent.Right = current.Left;
        //            }
        //        }
        //    }

        //    _count--;
        //}
        #endregion

        #region Traversal
        public void PreOrderTraversal(BinaryTreeNode<T> root)
        {
            if(root == null)
            {
                return;
            }

            Console.Write(root.Value + " --> ");

            PreOrderTraversal(root.Left);
            PreOrderTraversal(root.Right);
        }

        public void LevelOrderTraversal(BinaryTreeNode<T> root)
        {
            if(root == null)
            {
                return;
            }

            Queue<BinaryTreeNode<T>> queue = new Queue<BinaryTreeNode<T>>();
            
            queue.Enqueue(root);
            
            while (queue.Count != 0)
            {
                BinaryTreeNode<T> current = queue.Peek();
                Console.Write(queue.Dequeue().Value + " --> ");

                if(current.Left != null)
                {
                    queue.Enqueue(root.Left);
                }
                if(current.Right != null)
                {
                    queue.Enqueue(root.Right);
                }
                queue.Dequeue();
            }
        }
        #endregion
        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
