using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Challenges.Graphs
{
    public class Edge
    {
        private GraphNode start;
        private GraphNode end;
        private int weight;

        public Edge(GraphNode startNode, GraphNode endNode, int Weight)
        {
            this.start = startNode;
            this.end = endNode;
            this.weight =Weight;
        }

        public GraphNode getStart()
        {
            return this.start;
        }

        public GraphNode getEnd()
        {
            return this.end;
        }
        public int getWeight()
        {
            return this.weight;
        }

    }
}
