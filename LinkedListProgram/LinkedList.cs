﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListProgram
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

        //For adding node at a specific position
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
