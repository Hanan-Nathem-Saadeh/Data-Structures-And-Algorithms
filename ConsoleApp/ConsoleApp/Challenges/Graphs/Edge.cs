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
       

        public Edge(GraphNode startNode, GraphNode endNode)
        {
            this.start = startNode;
            this.end = endNode;
        }

        public GraphNode getStart()
        {
            return this.start;
        }

        public GraphNode getEnd()
        {
            return this.end;
        }

    }
}
