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
            try
            {
                if (Root == null)
                {
                    throw new Exception("Empty ....");
                }
                else
                    return MaxHelper(this.Root);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
         
        }
        public int MaxHelper(Node Root)
        {
            
            if (Root == null)
            {
                return int.MinValue;
            }

                    int MaxValue = Root.Value;
                    int MaxLeftValue = MaxHelper( Root.Left);
                    int MaxRightValue = MaxHelper(Root.Right);
                    if (MaxLeftValue > MaxValue)
                    {
                        MaxValue = MaxLeftValue;
                    }
                    if (MaxRightValue > MaxValue)
                    {
                        MaxValue = MaxRightValue;
                    }
                    return MaxValue;
        }
        // Pre Order
        public int[] PreOrder()
        {
            try
            {
                if (Root == null)
                {
                    throw new Exception("Empty Tree ....");
                }
                else 
                return PreOrderHelper(this.Root);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        public int[] PreOrderHelper(Node node)
        {
            List<int> MyList = new List<int>();
         
            try
            {

                if (node != null)
                {
                MyList.Add(node.Value);
                    MyList.AddRange(PreOrderHelper(node.Left));
                    MyList.AddRange(PreOrderHelper(node.Right));
                }
                 
                return MyList.ToArray();
            }
            catch (Exception ex)

            {
                throw new Exception(ex.Message);
            }
        }
        // In Order

        public int[] InOrder()
        {
            try
            {
                if (Root == null)
                {
                    throw new Exception("Empty Tree ....");
                }
                else
                    return InOrderHelper(this.Root);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public int[] InOrderHelper(Node node)
        {
            List<int> MyList = new List<int>();
            try
            {

                if (node != null)
                {
                    MyList.AddRange(InOrderHelper(node.Left));
                    MyList.Add(node.Value);
                    MyList.AddRange(InOrderHelper(node.Right));
                }
                return MyList.ToArray();
            }
            catch (Exception ex)

            {
                throw new Exception(ex.Message);
            }
        }

        // Post Order

        public int[] PostOrder()
        {
            try
            {
                if (Root == null)
                {
                    throw new Exception("Empty Tree ....");
                }
                else
                    return PostOrderHelper(this.Root);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public int[] PostOrderHelper(Node node)
        {
            List<int> MyList = new List<int>();
            try
            {

                if (node != null)
                {
                    MyList.AddRange(PostOrderHelper(node.Left));

                    MyList.AddRange(PostOrderHelper(node.Right));
                    MyList.Add(node.Value);
                }
                return MyList.ToArray();
            }
            catch (Exception ex)

            {
                throw new Exception(ex.Message);
            }
        }

    }
}

