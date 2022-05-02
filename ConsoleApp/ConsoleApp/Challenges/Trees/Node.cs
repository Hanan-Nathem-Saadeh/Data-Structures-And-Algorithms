using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Challenges.Trees
{
    public class Node
    {
        public int Value { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }
        public Node(int value)
        {
            this.Value = value;
            this.Right = null;
            this.Left = null;
           
        }
        public Node(int value , Node Left , Node node)

        {
            this.Value = value;
            this.Right = Right;
            this.Left = Left;

        }

    }
}
