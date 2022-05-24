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
            Node parent;
            Node current;
            Node newNode = new Node(Value);
            // if we will add the first node in the tree 
            if (Root != null)
            {
                current = Root;

                while (true)
                {
                    parent = current;
                    if (Value < current.Value)
                    {
                        current = current.Left;
                        if (current == null)
                        {
                            parent.Left = newNode;
                            break;
                        }
                    }
                    else
                    {
                        current = current.Right;
                        if (current == null)
                        {
                            parent.Right = newNode;
                            break;
                        }
                    }
                }
            }
            else
            {
                Root = newNode;
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
        public int SumOddNumber()
        {
            return SumOddNumberHelper(Root);
        }
        public int SumOddNumberHelper(Node root)
        {
            int[] MyArray = InOrder();
            int SumOddNumbers = 0;
            for (int i = 0; i < MyArray.Length; i++)
            {
                if (MyArray[i] % 2 != 0)
                    SumOddNumbers +=  MyArray[i];
            }
            return SumOddNumbers;
        }
    }
}
