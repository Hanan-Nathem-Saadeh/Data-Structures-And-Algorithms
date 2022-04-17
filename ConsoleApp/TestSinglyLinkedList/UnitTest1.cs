using System;
using Xunit;
using SinglyLinkedList;
using ConsoleApp.Challenges.SinglyLinkedList;
namespace TestSinglyLinkedList
{
    public class UnitTest1
    {
        //Can successfully instantiate an empty linked list
        [Fact]
        public void NulllinkedList()
        {
            LinkedList newList = new LinkedList();
            Assert.Null(newList.Head);
            // LinkedList list = new LinkedList();
            //Assert.Equal("NULL", list.ToString());
        }
        // Can Insert new Node 
        [Fact]
        public void TestCreatesNewNode()
        {
            int value = 5;
            Node testNode = new Node(value);
            Assert.Equal(value, testNode.Value);
        }
        // head will point to first node
        [Fact]
        public void TestHeadPointer()
        {
            LinkedList newList = new LinkedList();

            newList.Insert(10);
            newList.Insert(13);
            Node nodeVal = newList.Head;
            //the head pinter now point in the new node because we insert at the start of the linked list
            Assert.Equal(13, nodeVal.Value);

        }

        // can properly insert multiple nodes into the linked list
        [Fact]

        public void TestMultyInsert()
        {
            LinkedList newList = new LinkedList();

            newList.Insert(10);
            newList.Insert(20);
            Node nodeVal = newList.Head;
            Assert.Equal(20, nodeVal.Value);
            Assert.Equal(10, nodeVal.Next.Value);

        }
        //Will return true when finding a value within the linked list that exists
        [Fact]
        public void TestReturnTrueToExistValue()

        {
            LinkedList newList = new LinkedList();
            newList.Insert(30);
            newList.Insert(20);
            newList.Insert(10);
            bool IsInclude = newList.Includes(20);
            Assert.True(IsInclude);

        }
        //Will return false when searching for a value in the linked list that does not exist

        [Fact]
        public void TestReturnFalseToExistValue()

        {
            LinkedList newList = new LinkedList();
            newList.Insert(30);
            newList.Insert(20);
            newList.Insert(10);
            bool IsInclude = newList.Includes(50);
            Assert.False(IsInclude);

        }
        //Can properly return a collection of all the values that exist in the linked list
        [Fact]
        public void ReturnStringValues()
        {
            LinkedList newList = new LinkedList();
            newList.Insert(30);
            newList.Insert(20);
            newList.Insert(10);
            Assert.Equal("[ 10 ] -> [ 20 ] -> [ 30 ] -> NULL", newList.toString());

        }
        //Can successfully add a node to the end of the linked list
        [Fact]
        public void TestAppendToEndList()
        {
            LinkedList newList = new LinkedList();
            newList.Insert(30);
            newList.Insert(20);
            newList.Insert(10);
            newList.Append(1);
            Assert.Equal("[ 10 ] -> [ 20 ] -> [ 30 ] -> [ 1 ] -> NULL", newList.toString());
        }
        //Can successfully add multiple nodes to the end of a linked list
        [Fact]
        public void TestMultyAppend()
        {
            LinkedList newList = new LinkedList();
            newList.Insert(30);
            newList.Insert(20);
            newList.Insert(10);
            newList.Append(0);
            newList.Append(-10);
            newList.Append(-20);

            Assert.Equal("[ 10 ] -> [ 20 ] -> [ 30 ] -> [ 0 ] -> [ -10 ] -> [ -20 ] -> NULL", newList.toString());
        }
        // Can successfully insert a node before a node located i the middle of a linked list
        [Fact]
        public void TestInsertBefore()
        {
            LinkedList newList = new LinkedList();
            newList.Insert(30);
            newList.Insert(20);
            newList.Insert(10);
            newList.InsertBefore(20, 5);

            Assert.Equal("[ 10 ] -> [ 5 ] -> [ 20 ] -> [ 30 ] -> NULL", newList.toString());
        }
        //Can successfully insert a node before the first node of a linked list

        [Fact]
        public void TestInsertBFirst()
        {
            LinkedList newList = new LinkedList();
            newList.Insert(30);
            newList.Insert(20);
            newList.Insert(10);
            newList.InsertBefore(10, 5);

            Assert.Equal("[ 5 ] -> [ 10 ] -> [ 20 ] -> [ 30 ] -> NULL", newList.toString());
        }
        //Can successfully insert after a node in the middle of the linked list
        [Fact]
        public void TestInsertAfter()
        {
            LinkedList newList = new LinkedList();
            newList.Insert(30);
            newList.Insert(20);
            newList.Insert(10);
            newList.InsertAfter(20, 5);

            Assert.Equal("[ 10 ] -> [ 20 ] -> [ 5 ] -> [ 30 ] -> NULL", newList.toString());
        }
        //Can successfully insert a node after the last node of the linked list
        [Fact]
        public void TestInsertAfterLast()
        {
            LinkedList newList = new LinkedList();
            newList.Insert(30);
            newList.Insert(20);
            newList.Insert(10);
            newList.InsertAfter(30, 5);

            Assert.Equal("[ 10 ] -> [ 20 ] -> [ 30 ] -> [ 5 ] -> NULL", newList.toString());
        }
        //Where k is greater than the length of the linked list
        [Fact]
        public void TestKGraterTheLength()
        {

            LinkedList newList = new LinkedList();
            newList.Insert(30);
            newList.Insert(20);
            newList.Insert(10);
            Assert.Equal("[ 10 ] -> [ 20 ] -> [ 30 ] -> NULL", newList.toString());
            //the next statement proove that an exeption thrown if the key greater than linked lish length
            Assert.Equal("Invalid Key...It is Out Of Range", newList.kthFromEnd(9));
        }
        // Where k and the length of the list are the same
        [Fact]
        public void TestKEquallLength()
        {
            LinkedList newList = new LinkedList();
            newList.Insert(30);
            newList.Insert(20);
            newList.Insert(10);
            Assert.Equal("[ 10 ] -> [ 20 ] -> [ 30 ] -> NULL", newList.toString());
            //the length of the linked list =3
            // the key =3
            Assert.Equal("Invalid Key...It is Out Of Range", newList.kthFromEnd(3));

        }
        //Where k is not a positive integer
        [Fact]
        public void TestNotPoInteger()
        {
            LinkedList newList = new LinkedList();
            newList.Insert(30);
            newList.Insert(20);
            newList.Insert(10);
            Assert.Equal("[ 10 ] -> [ 20 ] -> [ 30 ] -> NULL", newList.toString());

            Assert.Equal("Invalid Key, It is less than zero .....", newList.kthFromEnd(-4));
        }
        //Where the linked list is of a size 1
        [Fact]
        public void TestLinkLOfSize1()
        {
            LinkedList newList = new LinkedList();
            newList.Insert(30);
            Assert.Equal("[ 30 ] -> NULL", newList.toString());
            Assert.Equal(30, newList.kthFromEnd(0));
        }
        [Fact]
        //“Happy Path” where k is not at the end, but somewhere in the middle of the linked list
        public void TestKAtMiddile()
        {
            LinkedList newList = new LinkedList();
            newList.Insert(30);
            newList.Insert(20);
            newList.Insert(10);
            Assert.Equal("[ 10 ] -> [ 20 ] -> [ 30 ] -> NULL", newList.toString());
            Assert.Equal(20, newList.kthFromEnd(1));
        }
        [Fact]
        //Test when list1 = list2
        public void TestEqualSize()
        {
            LinkedList newList1 = new LinkedList();
            LinkedList newList2 = new LinkedList();
            LinkedList newList3 = new LinkedList();

            newList1.Insert(30);
            newList1.Insert(20);
            newList1.Insert(10);
            newList2.Insert(25);
            newList2.Insert(15);
            newList2.Insert(5);
            newList3 = newList1.zipLists(newList1, newList2);

            Assert.Equal("[ 10 ] -> [ 5 ] -> [ 20 ] -> [ 15 ] -> [ 30 ] -> [ 25 ] -> NULL", newList3.toString());

        }
        [Fact]
        //Test when list1 > list2
        public void TestLargerSize()
        {
            LinkedList newList1 = new LinkedList();
            LinkedList newList2 = new LinkedList();
            LinkedList newList3 = new LinkedList();

            newList1.Insert(30);
            newList1.Insert(20);
            newList1.Insert(10);
            newList1.Insert(0);
            newList1.Insert(-10);

            newList2.Insert(25);
            newList2.Insert(15);
            newList2.Insert(5);
            newList3 = newList1.zipLists(newList1, newList2);

            Assert.Equal("[ -10 ] -> [ 5 ] -> [ 0 ] -> [ 15 ] -> [ 10 ] -> [ 25 ] -> [ 20 ] -> [ 30 ] -> NULL", newList3.toString());

        }
        [Fact]
        //Test when list1 < list2
        public void TestSmallerSize()
        {
            LinkedList newList1 = new LinkedList();
            LinkedList newList2 = new LinkedList();
            LinkedList newList3 = new LinkedList();

            newList1.Insert(30);
            newList1.Insert(20);
            newList1.Insert(10);


            newList2.Insert(25);
            newList2.Insert(15);
            newList2.Insert(5);
            newList2.Insert(0);
            newList2.Insert(-10);
            newList3 = newList1.zipLists(newList1, newList2);

            Assert.Equal("[ 10 ] -> [ -10 ] -> [ 20 ] -> [ 0 ] -> [ 30 ] -> [ 5 ] -> [ 15 ] -> [ 25 ] -> NULL", newList3.toString());

        }
        // if list 2 is empty
        [Fact]

        public void TestList2IsEmpty()
        {
            LinkedList newList1 = new LinkedList();
            LinkedList newList2 = new LinkedList();
            LinkedList newList3 = new LinkedList();

            newList1.Insert(30);
            newList1.Insert(20);
            newList1.Insert(10);


            newList3 = newList1.zipLists(newList1, newList2);

            Assert.Equal("[ 10 ] -> [ 20 ] -> [ 30 ] -> NULL", newList3.toString());

        }
        // if list 1 is empty
        [Fact]

        public void TestList1IsEmpty()
        {
            LinkedList newList1 = new LinkedList();
            LinkedList newList2 = new LinkedList();
            LinkedList newList3 = new LinkedList();

            newList2.Insert(30);
            newList2.Insert(20);
            newList2.Insert(10);


            newList3 = newList1.zipLists(newList1, newList2);

            Assert.Equal("[ 10 ] -> [ 20 ] -> [ 30 ] -> NULL", newList3.toString());

        }
    }
}
