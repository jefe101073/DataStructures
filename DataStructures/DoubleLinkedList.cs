using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class DNode
    {
        public int data;
        public DNode prev;
        public DNode next;
        public DNode(int d)
        {
            data = d;
            prev = null;
            next = null;
        }
    }
    public class DoubleLinkedList
    {
        public DNode? head;

        public void InsertFront(int data)
        {
            DNode newNode = new DNode(data);
            newNode.next = head;
            newNode.prev = null;
            if (head != null)
            {
                head.prev = newNode;
            }
            head = newNode;
        }

        public DNode GetLastNode()
        {
            DNode temp = head;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            return temp;
        }

        public void InsertLast(int data)
        {
            DNode newNode = new DNode(data);
            if (head == null)
            {
                newNode.prev = null;
                head = newNode;
                return;
            }
            DNode lastNode = GetLastNode();
            lastNode.next = newNode;
            newNode.prev = lastNode;
        }

        public void InsertAfter(DNode prev_node, int data)
        {
            if (prev_node == null)
            {
                Console.WriteLine("The given prevoius node cannot be null");
                return;
            }
            DNode newNode = new DNode(data);
            newNode.next = prev_node.next;
            prev_node.next = newNode;
            newNode.prev = prev_node;
            if (newNode.next != null)
            {
                newNode.next.prev = newNode;
            }
        }

        public void DeleteNodebyKey(int key)
        {
            DNode temp = head;
            if (temp != null && temp.data == key)
            {
                head = temp.next;
                head.prev = null;
                return;
            }
            while (temp != null && temp.data != key)
            {
                temp = temp.next;
            }
            if (temp == null)
            {
                return;
            }
            if (temp.next != null)
            {
                temp.next.prev = temp.prev;
            }
            if (temp.prev != null)
            {
                temp.prev.next = temp.next;
            }
        }

        public int GetCount()
        {
            int count = 1;
            DNode temp = head;
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

            DNode temp = head;
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
