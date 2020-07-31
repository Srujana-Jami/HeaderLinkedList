﻿using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace HeaderLinkedList
{
    class HeaderLinkedList
    {

        private Node head;
        public HeaderLinkedList()
        {
            head = new Node(0);
        }
        public void DisplayList()
        {
            if (head.link == null)
            {
                Console.WriteLine(" List is Empty\n ");
                return;
            }
            Node p = head.link;
            Console.Write(" List is :\n");
            while (p != null)
            {
                Console.Write(p.info + " ");
                p = p.link;

            }

            Console.WriteLine();

        }
        public void InsertAtEnd(int data)
        {
            Node temp = new Node(data);
            Node p = head;
            while (p.link != null)
                p = p.link;
            p.link = temp;
            temp.link = null;
        }
        public void CreateList()
        {
            int i, n, data;
            Console.Write("Enter the number of nodes ");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= n; i++)
            {
                Console.Write("enter the element to be inserted ");
                data = Convert.ToInt32(Console.ReadLine());
                InsertAtEnd(data);
            }
        }
        public void InsertBefore(int data, int x)
        {
            Node temp;
            Node p = head;
            while (p.link != null)
            {
                if (p.link.info == x)
                    break;
                p = p.link;
            }
            if (p.link == null)
                Console.WriteLine(x + " Not present in the list ");
            else
            {
                temp = new Node(data);
                temp.link = p.link;
                p.link = temp;
            }

        }
        public void InsertAtPosition(int data, int k)
        {
            Node temp;
            int i;

            Node p = head;
            for (i = 1; i <= k - 1 && p != null; i++)
                p = p.link;
            if (p == null)
                Console.WriteLine(" You can insert only upto " + (i - 1) + "th position\n");
            else
            {
                temp = new Node(data);
                temp.link = p.link;
                p.link = temp;
            }
        }

        public void DeleteNode(int data)
        {
            Node p = head;
            while (p.link != null)
            {
                if (p.link.info == data)
                    break;
                p = p.link;
            }
            if (p.link == null)
                Console.WriteLine(data + "Element %d not found ");
            else
                p.link = p.link.link;

        }

        
    }

    }
        

    




