﻿using System;

namespace LinkedList_implementation
{
    class LinkedList
    {
        public Node head = null;
        public Node tail = null;
        public int size = 0;

        public void Add(User user)
        {
            Node newNode = new Node(user);

            if (head == null)
            {
                head = newNode;
            }
            else
            {
                tail.next = newNode;
            }

            tail = newNode;
            size++;
        }

        public void showAll()
        {
            Node node = head;
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(node.value.name);
                node = node.next;
            }
        }

        public bool IsEmpty () 
        {
            if (size == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool remove (User user)
        {
            Node pastNode, currentNode;
            pastNode = currentNode = head;

            for (int i = 0; i < size; i++)
            {
                if (currentNode.value.name == user.name )
                {
                    if (currentNode == head)
                    {
                        head = head.next;
                    }
                    else
                    {
                        pastNode.next = currentNode.next;
                    }
                    size--;
                    return true;
                }
                pastNode = currentNode;
                currentNode = currentNode.next;
            }
            return false;
        }
    }
}
