using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class LinkedListStack
    {
        public Node top;

        public LinkedListStack()
        {
            top = null;
        }

        public void Push(int value)
        {
            Node newNode = new Node(value);
            if (top == null)
            {
                newNode.next = null;
            }
            else
            {
                newNode.next = top;
            }
            top = newNode;
        }

        public void Pop()
        {
            if (top == null)
            {
                Console.WriteLine("Stack Underflow. Deletion not possible");
                return;
            }

            top = top.next;
        }

        public int? Peek()
        {
            if (top == null)
            {
                Console.WriteLine("Stack Underflow.");
                return null;
            }

            return this.top.data;
        }
    }
}
