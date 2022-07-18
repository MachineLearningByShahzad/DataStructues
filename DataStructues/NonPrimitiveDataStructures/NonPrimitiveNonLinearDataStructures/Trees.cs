using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructues.NonPrimitiveDataStructures.NonPrimitiveNonLinearDataStructures
{
    internal class Trees
    {
        private class Node
        {
            public int value;
            public Node leftChild;
            public Node rightChild;

            public Node(int value)
            {
                this.value = value;
            }

            override
            public string ToString()
            {
                return "Node " + value;
            }
        }

        private Node root;

        public void insert(int value)
        {
            //Refactoring
            var node = new Node(value);
            if (root == null)
            {
                //root = new Node(value);
                root = node;
                return;
            }

            var current = root;

            while (true)
            {
                if (value < current.value)
                {
                    if (current.leftChild == null)
                    {
                        //current.leftChild = new Node(value);
                        current.leftChild = node;
                        break;
                    }
                    current = current.leftChild;
                }
                else
                {
                    if (current.rightChild == null)
                    {
                        //current.rightChild = new Node(value);
                        current.rightChild = node;
                        break;
                    }
                    current = current.rightChild;
                }
            }
        }

        public string find(int value)
        {
            var current = root;

            while (current != null)
            {
                if (value < current.value)
                {
                    current = current.leftChild;
                }
                else if (value > current.value)
                {
                    current = current.rightChild;
                }
                else
                {
                    return ($"Found Value => {current.value}");
                }
            }

            return "Value Not found";
        }


        public void preOrderTraversal()
        {
            preOrderTraversal(root);
        }

        private void preOrderTraversal(Node root)
        { //root, left, right
            if (root == null)
            {
                return;
            }

            Console.WriteLine(root.value);
            preOrderTraversal(root.leftChild);
            preOrderTraversal(root.rightChild);
        }

        public void postOrderTraversal()
        {
            postOrderTraversal(root);
        }

        private void postOrderTraversal(Node root)
        { // left, right, root
            if (root == null)
            {
                return;
            }

            postOrderTraversal(root.leftChild);
            postOrderTraversal(root.rightChild);
            Console.WriteLine(root.value);
        }

        public void inOrderTraversal()
        {
            inOrderTraversal(root);
        }

        private void inOrderTraversal(Node root)
        { // left, right, root
            if (root == null)
            {
                return;
            }

            inOrderTraversal(root.leftChild);
            Console.WriteLine(root.value);
            inOrderTraversal(root.rightChild);
        }

        public int height()
        {
            return height(root);
        }

        private int height(Node root)
        {
            if (root == null)
            {
                return -1;
            }
            if (root.leftChild == null && root.rightChild == null)
            {
                return 0;
            }

            return 1 + Math.Max(height(root.leftChild), height(root.rightChild));
        }

        //public int Depth()
        //{
        //    return Depth(root);
        //}

        //private int Depth(Node root)
        //{
        //    if (root == null)
        //    {
        //        return -1;
        //    }

        //    if (root.leftChild == null && root.rightChild == null)
        //    {
        //        return 0;
        //    }

        //    var left = root.leftChild;
        //    var right = root.rightChild;
        //    return 1 + Math.Max( Math.Max(Depth(left) ,Depth(right)), Depth(root));
        //}

        private int minBinaryTree(Node root)
        {
            var left = minBinaryTree(root.leftChild);
            var right = minBinaryTree(root.rightChild);

            return Math.Min(Math.Min(left, right), root.value);
        }

    }
}
