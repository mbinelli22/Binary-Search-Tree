using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class BinarySearchTree
    {
        //member variables
        public Node head;

        //constructor
        public BinarySearchTree()
        {


        }

        //member methods
        public class LinkedList
        {
            private Node head;
        }

            public void printAllNodes() 
            {
                Node current = head;
                while (current != null)
                {
                    Console.WriteLine(current.data);
                    current = current.next;
                }
            }

            public void AddFirst(int data)
            {
                Node toAdd = new Node();

                toAdd.data = data;
                toAdd.next = head;

                head = toAdd;
            }

            public void AddLast(int data)
            {
                if (head == null)
                {
                    head = new Node();

                    head.data = data;
                    head.next = null;
                }
                else
                {
                    Node toAdd = new Node();
                    toAdd.data = data;

                    Node current = head;
                //make a for loop to loop through the list so that it carrys the node that we want through
                for (int i = head; i < ; i++) 
                    {
                    if (data > current.data)
                        {
                            if (current.right == null)
                            {
                                current.right = toAdd;
                            break;
                            }
                            else
                            {
                                current = current.right;
                                AddLast(data);
                            }
                        }
                        else (data < current.data)
                        {
                            if (current.left == null)
                            {
                                current.left = toAdd;
                            break;
                            }
                            else
                            {
                                current = current.left;
                                AddLast(data);
                            }
                        }
                    }
                }                        
            }
               
    }
}
    

