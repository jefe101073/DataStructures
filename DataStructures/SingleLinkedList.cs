using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class Node
    {
        public int data;
        public Node? next;
        public Node(int d)
        {
            data = d;
            next = null;
        }
    }

    public class SingleLinkedList
    {
        public Node head;

        public void InsertFront(int new_data)
        {
            Node new_node = new Node(new_data);
            new_node.next = head;
            head = new_node;
        }

        public void DeleteFront()
        {
            Node temp = head;
            if (temp != null && temp.next != null)
            {
                head = temp.next;
                return;
            }
        }

        public Node GetLastNode()
        {
            Node temp = head;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            return temp;
        }

        public void DeleteAt(int position)
        {
            if (head == null)
                return;

            Node temp = head;
            if (position == 0)
            {
                head = temp.next;
                return;
            }

            for (int i = 0; temp != null && i < position - 1; i++)
            {
                temp = temp.next;
            }

            if (temp == null || temp.next == null)
            {
                return;
            }
            Node next = temp.next.next;
            temp.next = next;
        }

        public Node GetFirstNode()
        {
            return head;
        }

        public void InsertLast(int new_data)
        {
            Node new_node = new Node(new_data);
            if (head == null)
            {
                head = new_node;
                return;
            }
            Node lastNode = GetLastNode();
            lastNode.next = new_node;
        }

        public void InsertAfter(Node prev_node, int new_data)
        {
            if (prev_node == null)
            {
                Console.WriteLine("The given previous node Cannot be null");
                return;
            }
            Node new_node = new Node(new_data);
            new_node.next = prev_node.next;
            prev_node.next = new_node;
        }

        public void DeleteNodebyKey(int key)
        {
            Node temp = head;
            Node? prev = null;
            if (temp != null && temp.data == key)
            {
                head = temp.next;
                return;
            }
            while (temp != null && temp.data != key)
            {
                prev = temp;
                temp = temp.next;
            }
            if (temp == null)
            {
                return;
            }
            prev.next = temp.next;
        }

        public void ReverseLinkedList()
        {
            Node? prev = null;
            Node current = head;
            Node? temp = null;
            while (current != null)
            {
                temp = current.next;
                current.next = prev;
                prev = current;
                current = temp;
            }
            head = prev;
        }

        public int GetCount()
        {
            int count = 1;
            Node temp = head;
            while (temp.next != null)
            {
                temp = temp.next;
                count++;
            }
            return count;
        }

        public List<int> ToList()
        {
            var list = new List<int>();

            Node temp = head;
            list.Add(temp.data);
            while (temp.next != null)
            {
                temp = temp.next;
                list.Add(temp.data);
            }
            return list;
        }
    }
}
