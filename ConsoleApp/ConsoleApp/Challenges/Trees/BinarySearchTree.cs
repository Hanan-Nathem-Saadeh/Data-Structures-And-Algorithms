using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Challenges.Trees
{
    public class BinarySearchTree : BinaryTree
    {
        public void Add(int Value)
        {
            Node parent = null;
            Node current = Root;
            
            // if we will add the first node in the tree 
            if (Root == null)
            {
                Root = new Node(Value);
                return;

            }
            else
            {
                current = Root;
                while(true)
                {
                    parent = current;
                    if (Value <= current.Value)
                    {
                        current = current.Left;
                        if (current == null)
                        {
                            parent.Left = new Node(Value);
                            return;

                        }
                    }
                    else
                    {
                        current = current.Right;
                        if (current == null)
                        {
                            parent.Right = new Node(Value);
                            return;
                        }
                    }
                }
                

                }
           

        }
        public bool Contains(int Value)
        {
            Node Current = Root;
            while(Current != null)
            {

                if (Current.Value == Value)
                    return true;
                else if (Value <= Current.Value)
                {
                    Current = Current.Left;

                }
                else
                {
                    Current = Current.Right;
                }
            }
            return false;
        }
    }
}
