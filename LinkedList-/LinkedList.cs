using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LinkedList_
{
    internal class LinkedList
    {
        //For storing the address of first element
        internal Node head;
        //For adding node at the last position
        internal void Append(int data)
        {
            Node node = new Node(data);

            //Checking if head is pointing to null value or not
            if (this.head == null)
            {
                //If head is pointing to null then add the entered element as first element
                this.head = node;
            }
            else
            {
                //Declared temporary node temp pointing head
                Node temp = head;

                //while we dont't get next value of node as null
                while (temp.next != null)
                {
                    //temp is moving to next node
                    temp = temp.next;
                }
                //assigning next of last element (here temp) to newly added "node"
                temp.next = node;
            }
            Console.WriteLine(node.data + " appended to the Linked List");
        }
        //For displaying all elements in Linked List
        internal void Display()
        {
            //Temporary node currNode is declared and it is pointing to head
            Node currentNode = head;

            //Linked List empty condition
            if (head == null)
            {
                Console.WriteLine("Linked List is empty");
                return;
            }
            else
            {
                Console.Write("Linked List is : head");

                //while currentNode's value does not become null
                while (currentNode != null)
                {
                    //Printing the data to which currentNode is pointing
                    Console.Write(" -> " + currentNode.data);

                    //we are moving current node to next position/address
                    currentNode = currentNode.next;
                }
                Console.WriteLine();
            }
        }
    }
}
