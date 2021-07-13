using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    
    public class LinkedList
    {
        public Node start;
        public DoubleNode startDouble;
        public class Node
        {
            public int data { get; set; }
            public Node NextNode { get; set; }

            public Node(int nodeData, Node _node)
            {
                data = nodeData;
                NextNode = _node;
            }
        }

        public class DoubleNode
        {
            public int data { get; set; }
            public DoubleNode PrevNode { get; set; }
            public DoubleNode NextNode { get; set; }

            public DoubleNode(int nodeData, DoubleNode prevNode, DoubleNode nextNode)
            {
                data = nodeData;
                PrevNode = prevNode;
                NextNode = nextNode;
            }
        }


        public Node reverse()
        {
            Node curr = start, prevNode = null, next;

            if (start == null)
                return null;
            else
            {
                while (curr != null)
                {
                    next = curr.NextNode;
                    curr.NextNode = prevNode;
                    prevNode = curr;                    
                    curr = next;
                }
            }
            return prevNode;
        }

        public LinkedList MergeLinklist(LinkedList l1, LinkedList l2)
        {
            Node lastL1 = l1.LastNode();

            lastL1.NextNode = l2.start;

            return l1;
        }

       

        public void AddDoubleNode(int i)
        {
            DoubleNode n = new DoubleNode(i, null, null);
            if (startDouble == null)
            {
                startDouble = n;
            }
            else
            {
                DoubleNode node = LastDoubleNode();
                node.NextNode = n;
                n.PrevNode = node;
            }

        }
        public DoubleNode LastDoubleNode()
        {
            DoubleNode node = startDouble;
            while (node.NextNode != null)
            {
                node = node.NextNode;
            }

            return node;
        }

        public int CountDoubleNodes()
        {
            int i = 0;
            DoubleNode node = startDouble;
            if (node != null)
                i++;
            while (node.NextNode != null)
            {
                node = node.NextNode;
                i = i + 1;
            }
            return i;
        }

        public DoubleNode ReverseDoubleList()
        {
            DoubleNode curr = startDouble, next = null, prev = null;
            next = new DoubleNode(0,null,null);
            while (curr.NextNode != null)
            {
                next.data = curr.data;
                next.PrevNode = curr.NextNode;
                next.NextNode = curr.PrevNode;


                curr = curr.NextNode;
            }

            startDouble = curr;

            return curr;
        }


        public void AddNode(int i)
        {
            Node n = new Node(i, null);
            if (start == null)
                start = n;
            else
            {
                Node node = LastNode();
                node.NextNode = n;
            }

        }
        public Node LastNode()
        {
            Node node = start ;
            while (node.NextNode != null)
            {
                node = node.NextNode;
            }

            return node;
        }

        public int CountNodes()
        {
            int i = 0;
            Node node = start;
            if (node != null)
                i++;
            while (node.NextNode != null)
            {
                node = node.NextNode;
                i = i + 1;
            }

   

            return i;
        }

        public Node ReverseList()
        {
            Node curr = start, next =null, prev = null;

            while (curr != null)
            {
                next = curr.NextNode;
                curr.NextNode = prev;
                prev = curr;
                curr = next;
            }

            start = prev;

            return start;
        }

        public void DeleteNode(int i)
        {
            Node node = start ,prev = start;

            if (start.data == i)
            {
                start = start.NextNode;
            }
            else
            {
                while (node != null)
                {
                   
                    if (node.data == i)
                    {
                        prev.NextNode = node.NextNode;
                    }
                    prev = node;
                    node = node.NextNode;
                }
            }
        }


        public Node MiddleNode()
        {
            decimal total = CountNodes();
            int mid = (int)Math.Ceiling(total / 2);
            int i = 0;
            Node node = start, midNode = default;
            if (node != null)
                i++;
            while (node.NextNode != null)
            {
                if (i == mid)
                {
                    midNode = node;
                    break;
                }
                node = node.NextNode;
                i = i + 1;
            }

            return midNode;
        }

    }
}
