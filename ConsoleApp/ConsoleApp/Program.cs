using System;
using ConsoleApp.Challenges.SinglyLinkedList;
using ConsoleApp.Challenges.stack_queue_animal_shelter;
using ConsoleApp.Challenges.Get_Max_MochInterview;
using ConsoleApp.Challenges.Trees;
using ConsoleApp.Challenges;
using System.Collections.Generic;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("******************************************************");
                Console.WriteLine("********** Welcome To My Singly Linked List **********");
                Console.WriteLine("**************** HANAN NATHEM SAADEH *****************");
                Console.WriteLine("******************************************************");
                Console.WriteLine();

                BinaryTree NewTree  = new BinaryTree();
                NewTree.Root = (new Node(5));
                NewTree.Root.Left = (new Node(10));
                NewTree.Root.Right = (new Node(15));
                NewTree.Root.Left.Left = (new Node(20));
                NewTree.Root.Left.Right = (new Node(25));
                NewTree.Root.Right.Left = (new Node(30));
                NewTree.Root.Right.Right = (new Node(35));
               

               BreadthFirst MyBF = new BreadthFirst();
                List<int> MyNewList = new List<int>();

                
            MyNewList=MyBF.BreadthFirstMethod(NewTree);

                foreach (int x in MyNewList)
                {
                    Console.Write(x + " - ");
                }

                // Can successfully instantiate an empty linked list :)
                //LinkedList list = new LinkedList();

                //Can properly insert into the linked list:)
                // Can properly insert multiple nodes into the linked list:)
                //list.Insert(2);
                //list.Insert(4);
                //list.Insert(6);
                //list.Insert(8);
                //list.Insert(10);
                //list.Insert(-20);
                //list.Append(1);
                // list.InsertBefore(6, 7);
                //list.InsertAfter(10, 9);
                //list.InsertAfter(2,1);
                //Console.WriteLine(list.toString());

                //Console.WriteLine(" the node’s value is " + list.kthFromEnd(0));
                // Console.WriteLine("The Node is Found ? " + list.Includes(22));
                ////Will return true when finding a value within the linked list that exists :)
                //Console.WriteLine($"includes 6 ? { list.Includes(6)}");
                //Console.WriteLine($"includes 2 ? { list.Includes(2)}");
                //Console.WriteLine($"includes -20 ? { list.Includes(-20)}");
                ////Will return false when searching for a value in the linked list that does not exist :)
                //Console.WriteLine($"includes 100 ? { list.Includes(100)}");
                //Console.WriteLine($"includes -32 ? { list.Includes(-32)}");
                ////Can properly return a collection of all the values that exist in the linked list :)
                //Console.WriteLine($"The Contant of the linked list is : {list.toString()}");
                ////The head property will properly point to the first node in the linked list :)
                //Console.WriteLine("The Head property point to the first node in the linked list... So the Head Value = " + list.Head.Value);
                //LinkedList linke1 = new LinkedList();
                //LinkedList link2 = new LinkedList();
                //linke1.Insert(2);
                //linke1.Insert(4);
                //linke1.Insert(6);
                //linke1.Insert(8);
                //link2.Insert(1);
                //link2.Insert(3);
                //link2.Insert(5);
                //Console.WriteLine(linke1.toString());
                //Console.WriteLine(link2.toString());
                // LinkedList newList1 = new LinkedList();
                //LinkedList newList2 = new LinkedList();
                //newList1.Insert(2);
                //newList1.Insert(5);

                //newList1.Insert(3);
                //newList1.Insert(5);
                //newList1.Insert(0);

                //Console.WriteLine(newList1.toString());
                //if (newList1.palindromeLinkeList(newList1))
                //{
                //    Console.WriteLine(" Linked list is palindrome");
                //}
                //else
                //{
                //    Console.WriteLine(" Linked list is not palindrome");
                //}


                //newList2.Insert(4);
                //newList2.Insert(9);
                //newList2.Insert(5);
                //newList2.Insert(0);
                //newList2.Insert(-10);



                // Console.WriteLine(newList2.toString());
                //LinkedList link3 = new LinkedList();

                //link3 = newList1.zipLists(newList1, newList2);
                //Console.WriteLine(link3.toString());



            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }


        }
    }
}
