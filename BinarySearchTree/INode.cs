﻿using System;
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
        public INode<T> leftTree;
        public INode<T> rightTree;
        public INode(T data)
        {
            this.data = data;
            leftTree = null;
            rightTree = null;
        }
    }
}
