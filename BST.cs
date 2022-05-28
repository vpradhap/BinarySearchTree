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
        int leftCount = 0;
        int rightCount = 0;

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
                    leftCount++;
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
                    rightCount++;
                }
            }
        }
        public void Size()
        {
            Console.WriteLine("Size of the binary search tree : " + (1 + leftCount + rightCount));
        }
        public void Inorder()
        {
            if (leftTree != null)
            {
                leftCount++;
                leftTree.Inorder();
            }
            Console.Write(nodeData + "  ");
            if (rightTree != null)
            {
                rightCount++;
                rightTree.Inorder();
            }
        }
        public void Preorder()
        {
            Console.Write(nodeData + "  ");
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
            Console.Write(nodeData + "  ");
        }
    }
}
