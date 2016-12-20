using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class SearchTree<T> where T : IComparable
    {
        public Node<T> head;
        public SearchTree()
        {
            head = null;
        }

        public void AddNode(ref Node<T> currentNode, Node<T> newNode)
        {
            if (currentNode == null)
            {
                currentNode = newNode;
            }
            else
            {
                if (newNode.value.CompareTo(currentNode.value) < 0)
                {
                    if (currentNode.left == null)
                    {
                        currentNode.left = newNode;
                    }
                    else
                    {
                        AddNode(ref currentNode.left, newNode);
                    }
                }
                else if (newNode.value.CompareTo(currentNode.value) > 0)
                {
                    if (currentNode.right == null)
                    {
                        currentNode.right = newNode;
                    }
                    else
                    {
                        AddNode(ref currentNode.right, newNode);
                    }
                }
            }
        }
        public void Add(T value)
        {
            Node<T> newNode = new Node<T>(value);
            AddNode(ref head, newNode);
        }
        public void Display()
        {
            if (head == null)
            {
                Console.WriteLine("Null Tree.");
            }
            else
            {
                Node<T> currentNode = head;
                DisplayNode(head);
            }
        }
        public void DisplayNode(Node<T> node)
        {
            if (node != null)
            {
                Console.WriteLine("Value: {0}", node.value);
                DisplayNode(node.left);
                DisplayNode(node.right);
            }
        }
        public Node<T> Search(T value)
        {
            Console.WriteLine("Searching for {0}",value);
            if (head == null)
            {
                Console.WriteLine("Null tree.");
                return head;
            }
            else
            {
                if (head.value.CompareTo(value) == 0)
                {
                    Console.WriteLine("{0} found at head of tree.", value);
                    return head;
                }
                else
                {
                    return SearchNode(head, value);
                }
            }
        }
        
        public Node<T> SearchNode(Node<T> currentNode, T value)
        {
            if (currentNode == null)
            {
                Console.WriteLine("End of tree reached. Value not found.");
                return currentNode;
            }
            else
            {
                if (currentNode.value.CompareTo(value) == 0)
                {
                    Console.WriteLine("{0} found!", value);
                    return currentNode;
                }
                else if (currentNode.value.CompareTo(value) < 0)
                {
                    Console.WriteLine("Going right.");
                    return SearchNode(currentNode.right, value);
                }
                else
                {
                    Console.WriteLine("Going left.");
                    return SearchNode(currentNode.left, value);
                }
            }
        }
    }

}
