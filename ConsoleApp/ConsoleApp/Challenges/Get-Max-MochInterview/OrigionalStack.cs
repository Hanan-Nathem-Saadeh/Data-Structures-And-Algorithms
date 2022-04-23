using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SinglyLinkedList;
using stack_and_queue.Classes;

namespace ConsoleApp.Challenges.Get_Max_MochInterview
{
    public class OrigionalStack 
    {
        public Node Top { get; set; }
        public int MaxValue;
        Stack MaxStack = new Stack();
        

        public OrigionalStack()
        {
            Top = null;
            

        }
        public void Push(int Value)
        {
            int maxValue = Value;
            if (!MaxStack.IsEmpty() && maxValue < MaxStack.peek())
            {
                maxValue = MaxStack.peek();
            }
            Node newNode = new Node(Value);
            newNode.Next = Top;
            Top = newNode;
            
            MaxStack.Push(maxValue);
        }
        public void Pop()
        {
            if (IsEmpty())
            {
                throw new Exception("The Stack Is Empty... ");
            }
            Node temp = Top;
            Top = Top.Next;
            temp.Next = null;
           MaxStack.Pop();
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
        public int GetMax()
        {
            return MaxStack.peek();
        }
      
     


    }
}
