using SinglyLinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Challenges.SinglyLinkedList
{
    public class LinkedList
    {

        public Node Head { get; set; }

        public LinkedList()
        {
            Head = null;



        }
        //Adds a new node with value to the head of the list with an O(1) Time performance.
        public void Insert(int value)
        {
            try
            {
                Node newNode = new Node(value); ;
                if (IsEmpty())
                {
                    Head = newNode;
                }
                else
                {
                    Node NewNode = new Node(value);
                    NewNode.Next = Head;
                    Head = NewNode;
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }
        //Indicates whether the lest is empty or not
        public bool IsEmpty()
        {
            return Head == null;
        }
        //Indicates whether that value exists as a Node’s value somewhere within the list.
        public bool Includes(int Value)
        {
            try
            {
                if (IsEmpty())
                {
                    return false;
                }
                else
                {
                    Node current = Head;
                    while (current != null)
                    {
                        if (current.Value == Value)
                        {
                            return true;
                        }
                        current = current.Next;

                    }
                    return false;

                }
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }

        }
        // Returns: a string representing all the values in the Linked List, formatted as: "[ a ] -> [ b ] -> [ c ] -> NULL"
        public String toString()
        {
            try
            {
                String StringValues = "";
                Node current = Head;
                while (current != null)
                {
                    StringValues += "[ " + current.Value + " ] -> ";
                    current = current.Next;
                }
                StringValues += "NULL";
                return StringValues;
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }

        public void Append(int value)
        {
            Node newNode = new Node(value);
            if (IsEmpty())
            {
                Head = newNode;
            }
            else
            {

                Node temp = Head;
                while (temp.Next != null)
                {
                    temp = temp.Next;
                }
                newNode.Next = null;
                temp.Next = newNode;

            }

        }
        public void InsertBefore(int value, int newValue)
        {
            Node newNode = new Node(newValue);

            if (IsEmpty())
            {
                Head = newNode;
            }
            else
            {
                Node temp = Head;

                if (temp.Value == value)
                {
                    Insert(newValue);
                    return;
                }
                else
                {
                    while (temp.Next != null)
                    {
                        if (temp.Next.Value == value)
                        {
                            newNode.Next = temp.Next;
                            temp.Next = newNode;

                            return;
                        }

                        temp = temp.Next;
                    }

                }
            }
        }
        public void InsertAfter(int value, int newValue)
        {
            Node newNode = new Node(newValue);

            if (IsEmpty())
            {
                Head = newNode;
            }
            else
            {
                Node temp = Head;

                if (temp.Value == value)
                {
                    newNode.Next = temp.Next;

                    temp.Next = newNode;
                }

                while (temp.Next != null)
                {
                    if (temp.Value == value)
                    {
                        newNode.Next = temp.Next;
                        temp.Next = newNode;
                        return;
                    }

                    temp = temp.Next;

                }
                //the new code to fix insertAfter function
                if (temp.Value == value)
                {
                    newNode.Next = temp.Next;
                    temp.Next = newNode;
                    return;
                }
            }
        }

        public object kthFromEnd(int k)
        {

            try
            {
                if (IsEmpty())
                {
                    throw new Exception();
                }
                if (k < 0)
                {
                    throw new Exception();
                }

                Node temp = Head;
                int counter = 0;
                while (temp.Next != null)
                {
                    counter++;
                    temp = temp.Next;
                }
                if (k > counter)
                {
                    throw new Exception();
                }
                temp = Head;
                while (counter > k)
                {

                    temp = temp.Next;
                    counter--;

                }
                return temp.Value;


            }
            catch (Exception)
            {
                if (k < 0)
                    return ("Invalid Key, It is less than zero .....");
                else if (IsEmpty())
                    return ("The linked list is empty .....");
                else
                    return ("Invalid Key...It is Out Of Range");
            }
        }

        // Zip two linked lists Method

        public LinkedList zipLists(LinkedList list1, LinkedList list2)
        {

            LinkedList MyNewList = new LinkedList();
            Node current1 = list1.Head;
            Node current2 = list2.Head;

            while (current1 != null || current2 != null)
            {
                if (current1 == null)
                {
                    MyNewList.Append(current2.Value);
                    current2 = current2.Next;
                }
                else if (current2 == null)
                {
                    MyNewList.Append(current1.Value);
                    current1 = current1.Next;
                }
                else
                {
                    MyNewList.Append(current1.Value);
                    MyNewList.Append(current2.Value);
                    current1 = current1.Next;
                    current2 = current2.Next;
                }
            }

            return MyNewList;




        }
        // Code Challenge: Class 09
        // Mock Interviews

        public bool palindromeLinkeList(LinkedList OriginalLinkedList)
        {

            if (Head == null || Head.Next == null)
                return true;
            LinkedList Reversed = new LinkedList();
            Node current = OriginalLinkedList.Head;
            while (current != null)
            {
                Reversed.Insert(current.Value);
                current = current.Next;
            }
            Console.WriteLine(Reversed.toString());

            Node current1 = OriginalLinkedList.Head;
            Node current2 = Reversed.Head;
            while (current1 != null)
            {
                if (current1.Value != current2.Value)
                {
                    return false;
                }
                current1 = current1.Next;
                current2 = current2.Next;
            }
            return true;

        }

    }

}
