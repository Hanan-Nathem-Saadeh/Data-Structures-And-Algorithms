using System;
using Xunit;
using ConsoleApp.Challenges.Hashtable;
using System.Collections.Generic;

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
            Assert.Equal(KeyList,MyTable.keys());
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

        //    public void Test12()
        //{
        //    Hashtable MyTable1 = new Hashtable(1024);
        //    Hashtable MyTable2 = new Hashtable(1024);
        //    MyTable1.Set("diligent", "employed");
        //    MyTable1.Set("fond", "enamored");
        //    MyTable1.Set("guide", "usher");
        //    MyTable1.Set("outfit", "garb");
        //    MyTable1.Set("wrath", "anger");
        //    ///////////////////////////////////////////
        //    MyTable2.Set("diligent", "idle");
        //    MyTable2.Set("fond", "averse");
        //    MyTable2.Set("guide", "follow");
        //    MyTable2.Set("flow", "jam");
        //    MyTable2.Set("wrath", "delight");
        //    MyTable1.LeftJoin(MyTable1,MyTable2);
        //    List<string> keys = MyTable1.keys();
        //    foreach (var item in keys)
        //    {
        //        Console.WriteLine(map1.GetValue(item));
        //    }
        }



      
}
