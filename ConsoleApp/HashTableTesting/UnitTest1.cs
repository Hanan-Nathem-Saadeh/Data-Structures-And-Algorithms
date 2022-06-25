using System;
using Xunit;
using ConsoleApp.Challenges.Hashtable;
using System.Collections.Generic;
using ConsoleApp.Challenges.Trees;
using ConsoleApp.Challenges.Trees;
namespace HashTableTesting
{
    public class UnitTest1
    {
        // Setting a key/value to your hashtable results in the value being in the data structure
        Hashtable MyTable = new Hashtable(1024);
        [Fact]
        public void Test1()
        {
            MyTable.Set("A", "Ahmad");
            Assert.Equal("Ahmad", MyTable.get("A").Value);
        }
        //Retrieving based on a key returns the value stored
        [Fact]
        public void Test2()
        {
            MyTable.Set("H", "Hanan");
            MyTable.Set("N", "Noor");
            Assert.Equal("Hanan", MyTable.get("H").Value);
        }
        //Successfully returns null for a key that does not exist in the hashtable
        [Fact]
        public void Test3()
        {
            MyTable.Set("H", "Hanan");
            MyTable.Set("N", "Noor");
            Assert.Null(MyTable.get("R"));
        }
        //Successfully returns a list of all unique keys that exist in the hashtable
        [Fact]
        public void Test4()
        {
            MyTable.Set("H", "Hanan");
            MyTable.Set("N", "Noor");
            MyTable.Set("E", "Esraa");
            MyTable.Set("H", "Heba");
            List<string> KeyList = new List<string>();
            KeyList.Add("E");
            KeyList.Add("H");
            KeyList.Add("N");
            Assert.Equal(KeyList, MyTable.keys());
        }
        //Successfully handle a collision within the hashtable
        [Fact]
        public void Test5()
        {
            MyTable.Set("H", "Hanan");
            MyTable.Set("N", "Noor");
            MyTable.Set("H", "Heba");
            Assert.Equal("Heba", MyTable.get("H").Value);
        }
        //Successfully retrieve a value from a bucket within the hashtable that has a collision
        [Fact]
        public void Test6()
        {
            MyTable.Set("H", "Hanan");
            MyTable.Set("N", "Noor");
            MyTable.Set("H", "Heba");
            MyTable.Set("E", "Esraa");
            MyTable.Set("E", "Eman");
            MyTable.Set("M", "Muna");
            MyTable.Set("M", "Manar");
            Assert.Equal("Heba", MyTable.get("H").Value);
            Assert.Equal("Manar", MyTable.get("M").Value);
            Assert.Equal("Noor", MyTable.get("N").Value);
            Assert.Equal("Eman", MyTable.get("E").Value);
        }
        //Successfully hash a key to an in-range value
        [Fact]
        public void Test7()
        {
            MyTable.Set("N", "Noor");
            MyTable.Set("H", "Heba");
            MyTable.Set("E", "Esraa");
            MyTable.Set("E", "Eman");
            MyTable.Set("M", "Muna");
            MyTable.Set("M", "Manar");
            MyTable.Set("H", "Hanan Nathem Jalal Saadeh");
            Assert.Equal("Hanan Nathem Jalal Saadeh", MyTable.get("H").Value);

        }
        //Code Challenge 31
        // Case 1 
        [Fact]
        public void Test8()
        {
            string sentence = "Hello word From Hanan";
            Assert.Equal("In this sentence there is no Repeated word !!", MyTable.RepeatedWord(sentence));
        }
        // Case 2
        [Fact]
        public void test9()
        {
            string sentence = "Once upon a time, there was a brave princess who...";
            Assert.Equal("a", MyTable.RepeatedWord(sentence));
        }
        // Case 3
        [Fact]
        public void test10()
        {
            string sentence = "It was the best of times, it was the worst of times, it was the age of wisdom, it was the age of foolishness, it was the epoch of belief, it was the epoch of incredulity, it was the season of Light, it was the season of Darkness, it was the spring of hope, it was the winter of despair, we had everything before us, we had nothing before us, we were all going direct to Heaven, we were all going direct the other way – in short, the period was so far like the present period, that some of its noisiest authorities insisted on its being received, for good or for evil, in the superlative degree of comparison only...";
            Assert.Equal("it", MyTable.RepeatedWord(sentence));
        }
        // Case 4
        [Fact]
        public void test11()
        {
            string sentence = "It was a queer, sultry summer, the summer they electrocuted the Rosenbergs, and I didn’t know what I was doing in New York...";
            Assert.Equal("summer", MyTable.RepeatedWord(sentence));
        }
        // Code challenge 33 
        [Fact]
        public void TestLeftHashtable()
        {
            Hashtable leftHashtable = new Hashtable(10);
            leftHashtable.Set("diligent", "employed");
            leftHashtable.Set("fond", "enamored");
            leftHashtable.Set("guide", "usher");
            leftHashtable.Set("outfit", "garb");
            leftHashtable.Set("wrath", "anger");

            Hashtable rightHashtable = new Hashtable(10);
            rightHashtable.Set("diligent", "idle");
            rightHashtable.Set("fond", "averse");
            rightHashtable.Set("guide", "follow");
            rightHashtable.Set("flow", "jam");
            rightHashtable.Set("wrath", "delight");

            var leftJoin = Hashtable.LeftJoin(leftHashtable, rightHashtable);

            List<string[]> expectedList = new List<string[]> { new string[] { "font", "enamored", "averse" },
                                                       new string[] {"wrath", "anger", "delight"},
                                                       new string[] {"diligent", "employed", "idle"},
                                                       new string[] {"outfit", "garb", null},
                                                       new string[] {"guide", "usher", "follow" }
            };

            Assert.Contains(expectedList.ToString(), leftJoin.ToString());
        }

        [Fact]
        public void TestEmptyLeftHashtable()
        {
            Hashtable leftHashtable = null;
            Hashtable rightHashtable = new Hashtable(2);
            rightHashtable.Set("fond", "enamored");
            rightHashtable.Set("guide", "usher");
            var list = Hashtable.LeftJoin(leftHashtable, rightHashtable);
            Assert.Null(list);
        }

        [Fact]
        public void TestEmptyHashtables()
        {
            Hashtable leftHashtable = null;
            Hashtable rightHashtable = null;
            var result = Hashtable.LeftJoin(leftHashtable, rightHashtable);
            Assert.Null(result);
        }

        // Code challenge 32 
        // test 1
        [Fact]
        public void test15 ()
        {

            BinaryTree MyTree = new BinaryTree();
            
            MyTree.Root = (new ConsoleApp.Challenges.Trees.Node(10));
            MyTree.Root.Left = (new ConsoleApp.Challenges.Trees.Node(20));
            MyTree.Root.Right = (new ConsoleApp.Challenges.Trees.Node(30));
            MyTree.Root.Left.Left = (new ConsoleApp.Challenges.Trees.Node(40));
            MyTree.Root.Left.Right = (new ConsoleApp.Challenges.Trees.Node(50));

            BinaryTree Mytree2 = new BinaryTree();
            Mytree2.Root = (new ConsoleApp.Challenges.Trees.Node(5));
            Mytree2.Root.Left = (new ConsoleApp.Challenges.Trees.Node(10));
            Mytree2.Root.Right = (new ConsoleApp.Challenges.Trees.Node(15));
            Mytree2.Root.Left.Left = (new ConsoleApp.Challenges.Trees.Node(20));
            Mytree2.Root.Left.Right = (new ConsoleApp.Challenges.Trees.Node(25));


            TreeIntersection IntersectionTree = new TreeIntersection();
            List<int> intersections = IntersectionTree.tree_intersection(MyTree, Mytree2);
            List<int> result = new List<int>() { 10,20 };
            Assert.Equal(result, intersections);
        }

        [Fact]
        public void test16()
        {

            BinaryTree tree = new BinaryTree();
            BinaryTree tree2 = new BinaryTree();
            tree.Root = null;
            tree2.Root = (new ConsoleApp.Challenges.Trees.Node(5));
            TreeIntersection Intersection = new TreeIntersection();
            
            Assert.Null( Intersection.tree_intersection(tree, tree2));
        }
        [Fact]
        public void test17()
        {

            BinaryTree MyTree = new BinaryTree();

            MyTree.Root = (new ConsoleApp.Challenges.Trees.Node(2));
            MyTree.Root.Left = (new ConsoleApp.Challenges.Trees.Node(4));
            MyTree.Root.Right = (new ConsoleApp.Challenges.Trees.Node(6));
            MyTree.Root.Left.Left = (new ConsoleApp.Challenges.Trees.Node(8));
            MyTree.Root.Left.Right = (new ConsoleApp.Challenges.Trees.Node(10));

            BinaryTree Mytree2 = new BinaryTree();
            Mytree2.Root = (new ConsoleApp.Challenges.Trees.Node(12));
            Mytree2.Root.Left = (new ConsoleApp.Challenges.Trees.Node(14));
            Mytree2.Root.Right = (new ConsoleApp.Challenges.Trees.Node(16));
            Mytree2.Root.Left.Left = (new ConsoleApp.Challenges.Trees.Node(18));
            Mytree2.Root.Left.Right = (new ConsoleApp.Challenges.Trees.Node(20));


            TreeIntersection IntersectionTree = new TreeIntersection();
            List<int> intersections = IntersectionTree.tree_intersection(MyTree, Mytree2);
            Assert.Empty(IntersectionTree.tree_intersection(MyTree, Mytree2));
        }



    }
}
