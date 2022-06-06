using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Challenges.Hashtable
{
    public class Hashtable
    {
        public string[] HashTableContent = new string [100];
       
        public void Set (string Key , string Value)
        {
            int KeyAfterHash = Hash(Key);
           if(HashTableContent[KeyAfterHash]==null)
            {
                HashTableContent[KeyAfterHash] = Value;
            }
           else
            {
                int i = KeyAfterHash;
                while (HashTableContent[i]!=null)
                {
                    i = (i + 1) % Hash(Key);
                }
                HashTableContent[i]=Value;

            }
            
        }
        public string get(string Key)
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
        //public List<int> keys()
        //{


        //}
        public int Hash(string Key)
        {
            int num = 0;
            byte [] KeyASCII = Encoding.ASCII.GetBytes(Key);
            foreach (char item in KeyASCII)
            {
                num += item;
            }
            return (num % HashTableContent.Length);
        }


    }
}
