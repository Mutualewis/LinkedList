using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public static class LinkedListHelpers
    {
     
        public class Node<T>
        {
            public T data;
            public Node<T> next;

            public Node(T value)
            {
                data = value;
                next = null;
            }
        }

        public class LinkedList<T>
        {
            public Node<T> head = null;
            public Node<T> tail = null;

            public void addNode(T data)
            {
                if (Count(data.ToString()) < 2)
                {
                    Node<T> newNode = new Node<T>(data);

                    if (head == null)
                    {
                        head = newNode;
                        tail = newNode;
                    }
                    else
                    {
                        tail.next = newNode;
                        tail = newNode;
                    }
                }
            }

            public bool LessThanThree(String letter)
            {
                if (Count(letter) <= 2)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }


            public int Count(String search_for)
            {
                Node<T> current = head;
                int count = 0;
                while (current != null)
                {
                    if (current.data.Equals(search_for))
                        count++;
                    current = current.next;
                }
                return count;
            }

            public void display()
            {
                Node<T> current = head;
                if (head == null)
                {
                    Console.WriteLine("List is empty");
                    return;
                }
                while (current != null)
                {
                    Console.Write(current.data + " ");
                    current = current.next;
                }
                Console.WriteLine();
            }
        }

    }
}