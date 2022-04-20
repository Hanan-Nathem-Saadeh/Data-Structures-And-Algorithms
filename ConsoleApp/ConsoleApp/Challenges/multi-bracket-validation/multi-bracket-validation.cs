using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using stack_and_queue.Classes;
namespace ConsoleApp.Challenges.multi_bracket_validation
{
    public class multi_bracket_validation
    {
        public static bool multiBracketValidation(String StringInput)
        {
            Stack MyStack = new Stack();
            if (StringInput == null)
                return true;
            for (int i = 0; i < StringInput.Length; i++)
            {

                char temp = StringInput[i];
                if (temp=='('||temp=='{'||temp=='[')
                {
                    MyStack.Push(temp);
                }
                if (temp == ')' || temp == '}' || temp == ']')
                {
                    if (MyStack.IsEmpty())
                    {
                        return false;
                    }
                    char temp2 = (char)MyStack.peek();
                    if (temp == '}' && temp2 == '{' || temp == ']' && temp2 == '[' || temp == ')' && temp2 == '(')
                    {
                        MyStack.Pop();
                    }
                    else 
                        return false;
                }
            }
            bool Result = MyStack.IsEmpty();
            return Result;
        }
    }
}
