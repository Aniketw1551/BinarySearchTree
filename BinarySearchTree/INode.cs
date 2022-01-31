using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class INode<T>
    {
        //Variables
        public T data;
        public INode<T> left;
        public INode<T> right;
        public INode(T data)
        {
            this.data = data;
            left = null;
            right = null;
        }
    }
}
