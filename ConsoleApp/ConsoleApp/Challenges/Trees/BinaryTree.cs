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
        List<object> MyList = new List<object>();
        //Create an empty tree without root
        public BinaryTree()
        {
            Root = null;
        }
        // creat a new tree with one node which is the root
        public BinaryTree(int value)
        {
            Root = new Node(value);
        }
        // Pre Order
        public object[] PreOrder(Node Root)
        {
            try {

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

        public object[]  InOrder( Node Root)
        {
            try
            {
            

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

        public object[] PostOrder( Node Root)
        {
            try
            {
               
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
