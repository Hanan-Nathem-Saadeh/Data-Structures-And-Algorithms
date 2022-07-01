//using System;
//using Xunit;
//using ConsoleApp.Challenges.Trees;
//namespace TestBST
//{
//    public class UnitTest1
//    {
//        BinaryTree MyBinaryTree = new BinaryTree();
//        //1- Can successfully instantiate an empty tree
//        [Fact]
//        public void TestCreateEmptyTree() 
//        {
//            BinarySearchTree MyBST = new BinarySearchTree();
//            BinaryTree MyBinaryTree = new BinaryTree();
//            Assert.Null(MyBinaryTree.Root);
//            Assert.Null(MyBST.Root);
//        }
//        //2- Can successfully instantiate a tree with a single root node

//        //[Fact]
//        //public void TestInstantiateTreeWithSingleRoot() 
//        //{
//        //    BinaryTree MyBinaryTree = new BinaryTree();
//        //    MyBinaryTree.Root.Value = 50;

//        //    Assert.Equal(50, MyBinaryTree.Root.Value);
//        //}
//        // 3-a- For a Binary Search Tree, can successfully add a left child properly to a node


//        [Fact]
//        public void TestAddLeftChild()
//        {
//            BinarySearchTree MyBST = new BinarySearchTree();
//            MyBST.Add(5);
//            MyBST.Add(3);
//            MyBST.Add(2);
            
//            Assert.Equal(2, MyBST.Root.Left.Left.Value) ;

//        }
//        // 3-b- For a Binary Search Tree, can successfully add a Right child properly to a node


//        [Fact]
//        public void TestRightLeftChild()
//        {
//            BinarySearchTree MyBST = new BinarySearchTree();
//            MyBST.Add(5);
//            MyBST.Add(10);
//            MyBST.Add(12);

//            Assert.Equal(12, MyBST.Root.Right.Right.Value);

//        }
//         // 4- Can successfully return a collection from a preorder traversal
//        [Fact]
//        public void TestPreOrderTraversal() //Test preorder traversal
//        {
//            BinaryTree testTree = new BinaryTree();
//            testTree.Root = new Node(2);
//            testTree.Root.Left = new Node(4);
//            testTree.Root.Right = new Node(6);
//            testTree.Root.Left.Left = new Node(8);
//            testTree.Root.Left.Right = new Node(10);
//            int[] ArrayOfObject = new int[] { 2, 4, 8, 10, 6 };
//            Assert.Equal(ArrayOfObject, testTree.PreOrder());
//        }
//        // 5- Can successfully return a collection from an inorder traversal
//        [Fact]
//        public void TestInOrderTraversal() 
//        {
//            BinaryTree testTree = new BinaryTree();
//            testTree.Root = new Node(2);
//            testTree.Root.Left = new Node(4);
//            testTree.Root.Right = new Node(6);
//            testTree.Root.Left.Left = new Node(8);
//            testTree.Root.Left.Right = new Node(10);
//            int[] ArrayOfObject = new int[] { 8, 4, 10, 2, 6 };
//            Assert.Equal(ArrayOfObject, testTree.InOrder());
//        }
//        // 6- Can successfully return a collection from a postorder traversal
//        [Fact]
//        public void TestPostOrderTraversal()
//        {
//            BinaryTree testTree = new BinaryTree();
//            testTree.Root = new Node(2);
//            testTree.Root.Left = new Node(4);
//            testTree.Root.Right = new Node(6);
//            testTree.Root.Left.Left = new Node(8);
//            testTree.Root.Left.Right = new Node(10);
//            int[] ArrayOfObject = new int[] { 8, 10, 4, 6, 2 };
//            Assert.Equal(ArrayOfObject, testTree.PostOrder());
//        }



//        // 7-a Returns true	 for the contains method, given an existing or node value
//        [Fact]
//        public void TestContainsReturnTrue() 
//        {
//            BinarySearchTree MyBST = new BinarySearchTree();
//            MyBST.Add(100);
//            MyBST.Add(150);
//            MyBST.Add(200);
//            MyBST.Add(250);
//            MyBST.Add(300);
//            MyBST.Add(1000);

//            Assert.True(MyBST.Contains(250));
//        }
//        // 7-b Returns false for the contains method, given an not existing node value
//        [Fact]
//        public void TestContainsReturnFalse() 
//        {
//            BinarySearchTree MyBST = new BinarySearchTree();
//            MyBST.Add(100);
//            MyBST.Add(150);
//            MyBST.Add(200);
//            MyBST.Add(250);
//            MyBST.Add(300);
//            MyBST.Add(1000);
//            Assert.False(MyBST.Contains(0));
//        }

//    }
//}
