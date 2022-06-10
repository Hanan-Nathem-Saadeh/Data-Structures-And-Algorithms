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

    }
}
