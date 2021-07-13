using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Node : ICloneable
    {
        public Node Left { get; set; }
        public Node Right { get; set; }
        public int Data { get; set; }
        
        public Node (int data)
        {
            Left = null;
            Right = null;
            Data = data;
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }

    public class Trees
    {
        int lheight = 0, rheight = 0;
        Node _root = null;
        public Node RootNode { get { return (Node)_root.Clone(); } }
        public void Insert(int data)
        {
            // 1. If the tree is empty, return a new, single node 
            if (_root == null)
            {
                _root = new Node(data);
                return;
            }
            // 2. Otherwise, recur down the tree 
            InsertRec(_root, new Node(data));
        }
        private void InsertRec(Node root, Node newNode)
        {
            if (root == null)
                root = newNode;

            if (newNode.Data < root.Data)
            {
                if (root.Left == null)
                    root.Left = newNode;
                else
                    InsertRec(root.Left, newNode);

            }
            else
            {
                if (root.Right == null)
                    root.Right = newNode;
                else
                    InsertRec(root.Right, newNode);
            }
        }

        public void PreOrder(Node node)
        {
            if (node == null)
            {
                return;
            }

            Console.WriteLine(node.Data);
            PreOrder(node.Left);
            PreOrder(node.Right);
        }
        public void InOrder(Node node)
        {
            if (node == null)
            {
                return;
            }
            
            InOrder(node.Left);
            Console.WriteLine(node.Data);
            InOrder(node.Right);
        }
        public void PostOrder(Node node)
        {
            if (node == null)
                return;

            // first recur on left subtree
            PostOrder(node.Left);

            // then recur on right subtree
            PostOrder(node.Right);

            // now deal with the node
            Console.Write(node.Data + " ");
        }
        public int Height(Node node)
        {
            Node lStartNode, rStartNode;
            lStartNode = node.Clone() as Node;
            rStartNode = node.Clone() as Node;
            if (node == null)
                return -1;

            while (lStartNode.Left != null)
            {
                lheight++;
                lStartNode.Left = lStartNode.Left.Left;
            }

            while (rStartNode.Right != null)
            {
                rheight++;
                rStartNode.Right = rStartNode.Right.Right;
            }
            if (lheight > rheight)
            {
                return (lheight + 1);
            }
            else
            {
                return (rheight + 1);
            }
        }


    }
}
