using System;
using Xunit;
using ConsoleApp.Challenges.Get_Max_MochInterview;
namespace TestGetMaxMethod
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            OrigionalStack MyStack = new OrigionalStack();
            MyStack.Push(2);
            MyStack.Push(4);
            MyStack.Push(6);
            MyStack.Push(8);
            Assert.Equal(8,MyStack.GetMax());

        }
        [Fact]
        public void Test2()
        {
            OrigionalStack MyStack = new OrigionalStack();
            MyStack.Push(2);
            MyStack.Push(4);
            MyStack.Push(6);
            MyStack.Push(8);
            MyStack.Pop();
            Assert.Equal(6, MyStack.GetMax());

        }
        [Fact]
        public void Test3()
        {
            OrigionalStack MyStack = new OrigionalStack();
            MyStack.Push(2);
            MyStack.Push(4);
            MyStack.Push(6);
            MyStack.Push(8);
            MyStack.Pop();
            MyStack.Pop();
            MyStack.Push(0);
            Assert.Equal(4, MyStack.GetMax());

        }
    }
}
