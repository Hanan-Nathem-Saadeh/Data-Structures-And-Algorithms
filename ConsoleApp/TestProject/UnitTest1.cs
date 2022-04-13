using System;
using Xunit;

namespace TestStackAndQueue
{


    //public class UnitTest1
    //{
    //    //Can successfully push onto a stack

    //    [Fact]
    //    public void Can_Successfully_Push_Into_A_Stack()
    //    {
    //        Stack NewStack = new Stack();
    //        NewStack.Push(10);
    //        Assert.False(NewStack.IsEmpty());
    //    }
    //    [Fact]

    //    // Can successfully push multiple values onto a stack
    //    public void Can_Successfully_Push_Mulitple_Values_Into_A_Stack()
    //    {
    //        Stack NewStack = new Stack();
    //        NewStack.Push(10);
    //        NewStack.Push(20);
    //        NewStack.Push(30);
    //        NewStack.Push(40);
    //        Assert.Equal(40, NewStack.Top.Value);
    //    }

    //    //Can successfully pop off the stack

    //    [Fact]
    //    public void Test_Pop_Off_Stack()
    //    {
    //        Stack NewStack = new Stack();
    //        NewStack.Push(100);
    //        Assert.Equal(100, NewStack.Pop());
    //    }
    //    //Can successfully empty a stack after multiple pops
    //    [Fact]
    //    public void Test_Empty_Stack_After_Pops()
    //    {
    //        Stack NewStack = new Stack();
    //        NewStack.Push(100);
    //        NewStack.Push(200);
    //        NewStack.Push(300);
    //        NewStack.Push(400);
    //        NewStack.Pop();
    //        NewStack.Pop();
    //        NewStack.Pop();
    //        NewStack.Pop();
    //        Assert.True(NewStack.IsEmpty());
    //    }
    //    //Can successfully peek the next item on the stack
    //    [Fact]
    //    public void Test_Peek_Next_Item()
    //    {

    //        Stack NewStack = new Stack();
    //        NewStack.Push(15);
    //        Assert.Equal(15, NewStack.peek());
    //    }
    //    //Can successfully instantiate an empty stack
    //    [Fact]
    //    public void Test_Instantiate_Empty_Stack()
    //    {
    //        Stack NewStack = new Stack();

    //        Assert.Null(NewStack.Top);
    //    }
    //    // Calling peek on empty stack raises exception
    //    [Fact]
    //    public void Test_Peek_Empty_Stack()
    //    {
    //        Stack NewStack = new Stack();

    //        Exception ex = Assert.Throws<System.Exception>(() => NewStack.peek());
    //        Assert.Equal("The Stack Is Empty... ", ex.Message);
    //    }
    //    // Calling pop on empty stack raises exception
    //    [Fact]
    //    public void Test_Pop_Empty_Stack()
    //    {
    //        Stack NewStack = new Stack();

    //        Exception ex = Assert.Throws<System.Exception>(() => NewStack.Pop());
    //        Assert.Equal("The Stack Is Empty... ", ex.Message);
    //    }
    //    //Can successfully enqueue into a queue
    //    [Fact]
    //    public void Test_Enqueue()
    //    {
    //        Queue NewQueue = new Queue();
    //        NewQueue.Enqueue(5);
    //        Assert.Equal(5, NewQueue.Front.Value);

    //    }
    //    //Can successfully enqueue multiple values into a queue
    //    [Fact]
    //    public void Test_Multiple_Enqueue()
    //    {
    //        Queue NewQueue = new Queue();
    //        NewQueue.Enqueue(1);
    //        NewQueue.Enqueue(2);
    //        NewQueue.Enqueue(3);
    //        NewQueue.Enqueue(4);
    //        Assert.Equal(1, NewQueue.Front.Value);
    //    }
    //    //Can successfully dequeue out of a queue the expected value
    //    [Fact]
    //    public void Dequeue_Out_Queue_Expected_Value()
    //    {
    //        Queue NewQueue = new Queue();
    //        NewQueue.Enqueue(1);
    //        NewQueue.Enqueue(2);
    //        NewQueue.Enqueue(3);
    //        NewQueue.Enqueue(4);
    //        Assert.Equal(1, NewQueue.Dequeue());
    //    }
    //    //Can successfully peek into a queue, seeing the expected value

    //    [Fact]
    //    public void Test_PeekInToQueue()
    //    {
    //        Queue NewQueue = new Queue();
    //        NewQueue.Enqueue(1);
    //        Assert.Equal(1, NewQueue.Peek().Value);
    //    }
    //    //Can successfully empty a queue after multiple dequeues

    //    [Fact]
    //    public void Test_Empty_aQueue()
    //    {
    //        Queue NewQueue = new Queue();
    //        NewQueue.Enqueue(1);
    //        NewQueue.Enqueue(2);
    //        NewQueue.Enqueue(3);
    //        NewQueue.Dequeue();
    //        NewQueue.Dequeue();
    //        NewQueue.Dequeue();
    //        Assert.True(NewQueue.IsEmpty());
    //    }
    //    //Can successfully instantiate an empty queue
    //    [Fact]
    //    public void Test_Instantiate_EmptyQueue()
    //    {
    //        Queue NewQueue = new Queue();
    //        Assert.Null(NewQueue.Front);
    //    }
    //    //Calling dequeue on empty queue raises exception

    //    [Fact]
    //    public void Test_Dequeue_Empty()
    //    {
    //        Queue NewQueue = new Queue();
    //        Exception ex = Assert.Throws<System.Exception>(() => NewQueue.Dequeue());
    //        Assert.Equal("The Queue Is Empty... ", ex.Message);
    //    }

    //}

}