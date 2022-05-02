using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Challenges.Trees
{
    public class BinaryTree
    {
        public Node Root;
        public List<int> MyList = new List<int>();
        //Create an empty tree without root
        public BinaryTree()
        {
            Root = null;
            
        }
        // creat a new tree with one node which is the root
        public BinaryTree(Node newNode)
        {
            Root = newNode;

        }
       
        //Code Challenge 16 Find Max Value 
        public int FindMax()
        {
            var ValuesArray = PreOrder(Root);
            int MaxValue = (int)ValuesArray[0];
            foreach (var Value in ValuesArray)
            {
                if ((int)Value > MaxValue)
                {
                    MaxValue = (int)Value;
                }
            }
            return MaxValue;
        }


        // Pre Order
        public int[] PreOrder(Node Root)
        {
            try {
                if (Root == null)
                {
                    throw new Exception("Empty Tree ....");
                }
                MyList.Add(Root.Value);
          
            if (Root.Left != null)
            {
                PreOrder(Root.Left);
            }
            if (Root.Right != null)
            {
                PreOrder(Root.Right);
            }
            return MyList.ToArray();
            }
            catch( Exception ex)
            
            {
                throw new Exception(ex.Message);
            }
        }
        // In Order

        public int[]  InOrder( Node Root)
        {
            try
            {
                if (Root == null)
                {
                    throw new Exception("Empty Tree ....");
                }
                if (Root.Left != null)
                {
                    InOrder(Root.Left);
                }
                MyList.Add(Root.Value);
                if (Root.Right != null)
                {
                    InOrder(Root.Right);
                }
                return MyList.ToArray();
            }
            catch (Exception ex)

            {
                throw new Exception(ex.Message);
            }
        }
        // Post Order

        public int[] PostOrder( Node Root)
        {
            try
            {
                if (Root == null)
                {
                    throw new Exception("Empty Tree ....");
                }
                if (Root.Left != null)
                {
                    PostOrder(Root.Left);
                }

                if (Root.Right != null)
                {
                    PostOrder(Root.Right);
                }
                MyList.Add(Root.Value);
                return MyList.ToArray();
            }
            catch (Exception ex)

            {
                throw new Exception(ex.Message);
            }
        }
    }
}
