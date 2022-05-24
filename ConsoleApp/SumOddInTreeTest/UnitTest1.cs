using ConsoleApp.Challenges.Trees;
using System;
using Xunit;

namespace SumOddInTreeTest
{
    public class UnitTest1
    {
        [Fact]
        public void TestSumOdd()
        {
            BinarySearchTree MyTree = new BinarySearchTree();
            MyTree.Add(4);
            MyTree.Add(1);
            MyTree.Add(5);
            MyTree.Add(7);
            MyTree.Add(3);
            MyTree.Add(9);
            MyTree.Add(10);
            Assert.Equal(25 , MyTree.SumOddNumber());

        }
    }
}
