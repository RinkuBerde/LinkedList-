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
        //For adding the node at the first position
        internal void Add(int data)
        {
            Node newNode = new Node(data);

            //Checking if head is pointing to null value or not
            if (this.head == null)
            {
                //If head is pointing to null then add the entered element as first element
                this.head = newNode;
            }
            else
            {
                //Assigning newNode's next to the head (i.e. at first position)
                newNode.next = this.head;

                //Now head is pointing to newNode
                head = newNode;
            }
            Console.WriteLine(newNode.data + " added to the Linked List");
        }
        internal void AddAtPosition(int position, int data)
        {
            Node newNode = new Node(data);

            if (position < 1)
            {
                Console.WriteLine("Invalid position");
            }
            //If we want node to be inserted at first position
            if (position == 1)
            {
                newNode.next = head;
                head = newNode;
            }
            else
            {
                //Declaring count to count starting from 2 the position
                int currentPosition = 1;
                //Declaring temporary head tempHead to parse throu the list
                Node tempHead = head;
                //while count does not get to the entered position where we want to add our node
                while (currentPosition++ != position)
                {
                    //If our count variable is at entered position
                    if (currentPosition == position)
                    {
                        //Assigning newNode's next to tempHead's next, the position at which we want to insert node
                        newNode.next = tempHead.next;

                        //Assigning previous node's (here tempHead) next to newNode
                        tempHead.next = newNode;
                        Console.WriteLine(newNode.data + " is added at position " + position);
                        break;
                    }
                    //Moving the position of tempHead to the next node
                    tempHead = tempHead.next;
                }
                if (currentPosition != position)
                {
                    Console.WriteLine("Position is out of range");
                }
            }
        }
        //For deleting the first node
        internal void Pop()
        {
            if (head == null)
            {
                Console.WriteLine("Linked List is empty");
                return;
            }
            //Moving head to next position
            Console.WriteLine("The first node having data " + head.data + " is deleted from the list");
            head = head.next;
        }
        internal void PopLast()
        {
            Node newNode = head;
            if (head == null)
            {
                Console.WriteLine("Linked List is empty");
                return;
            }
            if (head.next == null)
            {
                this.head = null;
            }
            while (newNode.next.next != null)
            {
                //Move newNode to the next node
                newNode = newNode.next;
            }
            //Remove the reference of the last but one node's next to make it the new last node
            newNode.next = null;
        }
        ////For searching a node
        internal void Search(int value)
        {
            Node temp = this.head;
            while (temp != null)
            {
                if (temp.data == value)
                {
                    Console.WriteLine("Given value: " + value + " is present in Linked list");
                    return;
                }
                temp = temp.next;
            }
            if (temp == null)
                Console.WriteLine("Given value: " + value + " is not present in Linked list");
        }
        //To insert node after a specific node we have to find/search that node in our list
        internal void AddAfter(int value, int data)
        {
            Node tempHead = head;
            Node newNode = new Node(data);
            if (head == null)
            {
                Console.WriteLine("Linked List is empty");
                return;
            }
            while (tempHead.next != null)
            {
                //If our desired value is found in the list after which we want to insert our node
                if (tempHead.data == value)
                {
                    Console.WriteLine(newNode.data + " is inserted after " + tempHead.data);
                    newNode.next = tempHead.next;
                    tempHead.next = newNode;
                    break;
                }
                tempHead = tempHead.next;
            }
        }
        //To delete a specific node we have to find/search the node present before the node we want to delete
        internal void DeleteValue(int value)
        {
            Node tempHead = head;

            if (head == null)
            {
                Console.WriteLine("Linked List is empty");
                return;
            }
            //while temporary head's (tempHead) next node's data is not entered value
            while (tempHead.next != null)
            {
                //If our desired value is found in the list after which we want to insert our node
                if (tempHead.next.data == value)
                {
                    tempHead.next = tempHead.next.next;
                    Console.WriteLine("The value " + value + " is deleted from the list");
                }
                tempHead = tempHead.next;
            }
        }

        //To find size of the list
        internal void Size()
        {
            //Declaring variable size to count nodes
            int size = 0;

            Node tempHead = head;
            while (tempHead != null)
            {
                tempHead = tempHead.next;
                size++;
            }
            Console.WriteLine("Linked List size is : " + size);
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
