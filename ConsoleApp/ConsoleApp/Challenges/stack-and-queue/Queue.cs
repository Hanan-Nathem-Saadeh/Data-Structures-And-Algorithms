using SinglyLinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stack_and_queue.Classes
{
    public class Queue
    {
        public Node Front { get; set; }
        public Node Rear { get; set; }
        public Queue()
        {
            Front = null;

        }

        public void Enqueue(int Value)
        {
            Node NewNode = new Node(Value);
            if (Front == null)
            {
                Front = NewNode;
                Rear = NewNode;
            }
            else
            {
                Rear.Next = NewNode;
                Rear = NewNode;
            }
        }
        public int Dequeue()
        {
            if (IsEmpty())
            {
                throw new Exception("The Queue Is Empty... ");
            }
            Node temp = Front;
            Front = Front.Next;
            temp.Next = null;
            return temp.Value;
        }

        public Node Peek()
        {
            if (IsEmpty())
            {
                throw new Exception("The Queue is empty!");
            }
            else

            {
                return Front;
            }

        }
        public bool IsEmpty()
        {
            return Front == null;
        }
    }
}