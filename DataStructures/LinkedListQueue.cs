using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class LinkListQueue
    {
        Node front;
        Node rear;

        public LinkListQueue()
        {
            this.front = this.rear = null;
        }

        public void Enqueue(int item)
        {
            Node newNode = new Node(item);

            // If queue is empty, then new node is front and rear both  
            if (this.rear == null)
            {
                this.front = this.rear = newNode;
            }
            else
            {
                // Add the new node at the end of queue and change rear  
                this.rear.next = newNode;
                this.rear = newNode;
            }
        }

        public void Dequeue()
        {
            // If queue is empty, return NULL.  
            if (this.front == null)
            {
                Console.WriteLine("The Queue is empty");
                return;
            }

            // Store previous front and move front one node ahead  
            Node temp = this.front;
            this.front = this.front.next;

            // If front becomes NULL, then change rear also as NULL  
            if (this.front == null)
            {
                this.rear = null;
            }
        }

        public List<int> ToList()
        {
            var list = new List<int>();

            Node temp = front;
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
