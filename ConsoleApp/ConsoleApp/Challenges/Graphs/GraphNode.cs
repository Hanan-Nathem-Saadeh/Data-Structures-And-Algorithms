using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Challenges.Graphs
{
    public  class GraphNode
    {
        public int Value { get; set; }
        public List<GraphNode> Neighbors { get; set; }

        public GraphNode(int Value)
        {
            Value = Value;
        }
    }
}
