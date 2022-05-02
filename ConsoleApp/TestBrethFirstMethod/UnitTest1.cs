using ConsoleApp.Challenges.Trees;
using System;
using System.Collections.Generic;
using Xunit;

namespace TestBrethFirstMethod
{
    public class UnitTest1
    {
        BreadthFirst MyBF = new BreadthFirst();
        //Test 1
        [Fact]
        public void Test1()
        {
            BinaryTree NewTree = new BinaryTree();
            NewTree.Root = (new Node(5));
            NewTree.Root.Left = (new Node(10));
            NewTree.Root.Right = (new Node(15));
            NewTree.Root.Left.Left = (new Node(20));
            NewTree.Root.Left.Right = (new Node(25));
            NewTree.Root.Right.Left = (new Node(30));
            NewTree.Root.Right.Right = (new Node(35));
            NewTree.Root.Left.Left.Right = (new Node(1));
            List<int> MyList = new List<int> { 5, 10, 15, 20, 25, 30,35, 1 };
            Assert.Equal(MyList, MyBF.BreadthFirstMethod(NewTree));
        }
        
        //Test 2
        [Fact]
        public void Test2()
        {
            BinaryTree NewTree = new BinaryTree();
            NewTree.Root = (new Node(-9));
            NewTree.Root.Left = (new Node(-100));
            NewTree.Root.Right = (new Node(15));
            NewTree.Root.Left.Left = (new Node(2));
          
            NewTree.Root.Right.Left = (new Node(30));
            NewTree.Root.Right.Left .Left= (new Node(35));
            NewTree.Root.Left.Left.Right = (new Node(1));
            List<int> MyList = new List<int> { -9, -100, 15, 2, 30, 1, 35};
            Assert.Equal(MyList, MyBF.BreadthFirstMethod(NewTree));
        }
        //Test 3
        [Fact]
        public void Test3()
        {
            BinaryTree NewTree = new BinaryTree();

            Exception ex = Assert.Throws<Exception>(() => MyBF.BreadthFirstMethod(NewTree));
            Assert.Equal("OPPPPs....This Tree Is Empty !!", ex.Message);
        }
    }
}
