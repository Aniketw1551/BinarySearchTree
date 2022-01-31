using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class MyBinaryTree<T> where T : IComparable
    {
        //Variable.
        public INode<T> root;
        public void CreateNode(T value)
        {
            INode<T> newNode = new INode<T>(value);
            if (root == null)
            {
                root = newNode;
            }
            else
            {
                INode<T> parentNode = root;
                INode<T> currentNode = root;
                while (true)
                {
                    parentNode = currentNode;
                    if (currentNode.data.CompareTo(value) >= 0)
                    {
                        currentNode = currentNode.left;
                        if (currentNode == null)
                        {
                            parentNode.left = newNode;
                            break;
                        }
                    }
                    else
                    {
                        currentNode = currentNode.right;
                        if (currentNode == null)
                        {
                            parentNode.right = newNode;
                            break;
                        }
                    }
                }
            }
        }
        //Display Root Node.
        public void Root()
        {
            do
            {
                Console.WriteLine("BST Root Node:" + root.data);
                break;
            } while (root != null);
        }
        //Method to Display Nodes in binary search tree

        public void Display(INode<T> parent)
        {
            if (parent != null)
            {
                Display(parent.left);
                Display(parent.right);
                Console.WriteLine("{0} is BST Node", parent.data);
            }
        }
        //length of binary search tree 
        public int Size(INode<T> root)
        {
            if (root == null)
                return 0;
            else
                return (Size(root.left) + 1 + Size(root.right));
        }
    }
}
        
  
