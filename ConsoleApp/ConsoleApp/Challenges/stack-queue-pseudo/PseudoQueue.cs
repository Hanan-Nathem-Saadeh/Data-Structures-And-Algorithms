using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stack_and_queue.Classes
{
    //this class is to implement a psudo queue using stack data structure
    public class PseudoQueue
    {

        Stack FirstStack = new Stack();
        Stack SecondStack = new Stack();
        public void Enqueue(int Value)
        {

            while (!(FirstStack.IsEmpty()))
            {
                SecondStack.Push(FirstStack.Pop());
            }
            FirstStack.Push(Value);
            while (!(SecondStack.IsEmpty()))
            {
                FirstStack.Push(SecondStack.Pop());
            }

        }
        public int Dequeue()
        {
            if (FirstStack.IsEmpty())
            {
                throw new Exception("The Queue Is Empty... ");
            }

            int Value1 = FirstStack.Pop();
            return Value1;
        }
        public int Peek()
        {
            int value1 = FirstStack.peek();
            return value1;

        }

    }
}
