using SinglyLinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stack_and_queue.Classes
{
    public class Stack
    {
        public Node Top { get; set; }
        public Stack()
        {
            Top = null;

        }

        public void Push(int Value)
        {
            Node newNode = new Node(Value);

            newNode.Next = Top;
            Top = newNode;
        }
        public int Pop()
        {

            if (IsEmpty())
            {
                throw new Exception("The Stack Is Empty... ");
            }
            Node temp = Top;
            Top = Top.Next;
            temp.Next = null;
            return temp.Value;
        }
        public int peek()
        {
            if (IsEmpty())
                throw new Exception("The Stack Is Empty... ");
            return Top.Value;
        }
        public bool IsEmpty()
        {
            return Top == null;
        }

    }

}