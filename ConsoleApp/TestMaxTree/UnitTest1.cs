using ConsoleApp.Challenges.Trees;
using System;
using Xunit;

namespace TestMaxTree
{
    public class UnitTest1
    {
        //Test1
        [Fact]
        public void TestZerosVales()
        {
            Node node = new Node(0);
            node.Left = new Node(0);
            node.Left.Left = new Node(0);
            node.Left.Right = new Node(0);
            node.Right = new Node(0);
            BinaryTree tree = new BinaryTree(node);

            Assert.Equal(0, tree.FindMax());
        }
    // Test 2 “Happy Path” 
        [Fact]
        public void TestSameValueInTree()
        {
            Node node = new Node(5);
            node.Left = new Node(6);
            node.Left.Left = new Node(15);
            node.Left.Right = new Node(19);
            node.Right = new Node(4);
            BinaryTree tree = new BinaryTree(node);

            Assert.Equal(19, tree.FindMax());
        }
        // positive and negative values
        [Fact]
        public void TestNegativeAndPositiveValuesInTree()
        {
            Node node = new Node(-9);
            node.Left = new Node(-3);
            node.Left.Left = new Node(-12);
            node.Left.Left = new Node(12);
            node.Right = new Node(4);
            BinaryTree tree = new BinaryTree(node);

            Assert.Equal(12, tree.FindMax());
        }
        [Fact]
        public void Test4()
        {
            Node node = new Node(0);
            node.Left = new Node(150);
            
            node.Left.Left = new Node(120);
            node.Left.Left.Right = new Node(-100);
            node.Left.Left.Right.Right = new Node(12);
            BinaryTree tree = new BinaryTree(node);

            Assert.Equal(150, tree.FindMax());
        }
    }

}
