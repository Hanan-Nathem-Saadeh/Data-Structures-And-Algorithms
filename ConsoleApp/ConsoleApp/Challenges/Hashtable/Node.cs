using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Challenges.Hashtable
{
    public class Node
    {
        public string Key { get; set; }
        public string Value { get; set; }
        public Node(string key,string value)
        {
            this.Key = key;
            this.Value = value;  
        }
    }
}
