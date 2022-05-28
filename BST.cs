using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class BST<T> where T : IComparable
    {
        
        public T nodeData { get; set; }
        public BST<T> leftTree { get; set; }

        public BST<T> rightTree { get; set; }

        public BST(T data)
        {
            nodeData = data;
            leftTree = null;
            rightTree = null;
        }

        public void Insert(T item)
        {
            T CurrNodeVal = nodeData;
            if ((CurrNodeVal.CompareTo(item)) > 0)
            {
                if (leftTree == null)
                {
                    leftTree = new BST<T>(item);
                }
                else
                {
                    leftTree.Insert(item);
                }
            }
            else
            {
                if (rightTree == null)
                {
                    rightTree = new BST<T>(item);
                }
                else
                {
                    rightTree.Insert(item);
                }
            }
        }

        public void Inorder()
        {
            if (leftTree != null)
            {
                leftTree.Inorder();
            }
            Console.Write(nodeData + " ");
            if (rightTree != null)
            {
                rightTree.Inorder();
            }
        }
        public void Preorder()
        {
            Console.Write(nodeData + " ");
            if (leftTree != null)
            {
                leftTree.Preorder();
            }
            if (rightTree != null)
            {
                rightTree.Preorder();
            }
        }
        public void Postorder()
        {
            if (leftTree != null)
            {
                leftTree.Postorder();
            }
            if (rightTree != null)
            {
                rightTree.Postorder();
            }
            Console.Write(nodeData + " ");
        }
    }
}
