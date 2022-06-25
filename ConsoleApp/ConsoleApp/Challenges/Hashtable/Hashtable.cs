using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Challenges.Hashtable
{
    public class Hashtable
    {

        private int size { get; set; }
        private Node[] HashTableContent { get; set; }
        public Hashtable(int size)
        {
        this.size = size;
       HashTableContent = new Node[size];
        }
        
       
        public void Set (string Key , string Value)
        {
            int KeyAfterHash = Hash(Key);
            Node newNode = new Node(Key,Value);
            HashTableContent[KeyAfterHash] = newNode;
        }
        public Node get(string Key)
        {
            int HashedKey = Hash(Key);
            if (contains(Key))
            {
                return HashTableContent[HashedKey];
            }
            else
                return null;
        }

        public bool contains(string Key)
        {
            int KeyAfterHash = Hash(Key);

            if (HashTableContent[KeyAfterHash] != null)
            {
                return true;
            }
            return false;
        }
        public List<string> keys()
        {
            List<string> KeyList = new List<string>();
            for (int i = 0; i < HashTableContent.Length; i++)
            {
                if (HashTableContent[i] !=null)
                {
                    KeyList.Add(HashTableContent[i].Key);
                }
            }
            return KeyList;

        }
        public int Hash(string Key)
        {
            int num = 0;
            byte[] KeyASCII = Encoding.ASCII.GetBytes(Key);
            foreach (char item in KeyASCII)
            {
                num += item;
            }
            return (num % HashTableContent.Length);
        }
        public string RepeatedWord(string sentence)
        {
            string[] stringArray = sentence.Split(' ', '-', '.', ',');
            for (int i = 0; i < stringArray.Length; i++)
            {
                if (stringArray[i] != "")
                {
                    if (contains(stringArray[i].ToUpper()))
                    {
                        return stringArray[i];
                    }
                    else
                    {
                       Set(stringArray[i].ToUpper(),null);
                    }
                }
            }
            return "In this sentence there is no Repeated word !!";

        }
        public static List<string[]> LeftJoin(Hashtable left, Hashtable right)
        {
            if ((left == null && right == null) || (left == null))
            { return null; }

            if (right == null)
            {
                List<string[]> leftList = new List<string[]>();
                for (int i = 0; i < left.HashTableContent.Length; i++)
                {
                    Node temp = left.HashTableContent[i];
                    while (temp != null)
                    {
                        leftList.Add(new string[] { $"{temp.Key}", $"{temp.Value}" });
                        temp = temp.Next;
                    }
                }
                return leftList;
            }

            List<string[]> arrayList = new List<string[]>();
            for (int i = 0; i < left.HashTableContent.Length; i++)
            {

                Node temp = left.HashTableContent[i];
                while (temp != null)
                {
                    arrayList.Add(new string[] { $"{temp.Key}", $"{temp.Value}", $"{right.get($"{temp.Key}")}" });
                    temp = temp.Next;
                }
            }

            return arrayList;
        }





    }
}
