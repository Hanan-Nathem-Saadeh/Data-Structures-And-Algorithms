using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Challenges.Graphs
{
    public  class GraphNode
    {
        public string Value { get; set; }
        public List<Edge> Edges;

        public GraphNode(string value)
        {
            this.Value = value;
            this.Edges = new List<Edge>();
        }
        public void addEdge(GraphNode endNode, int weight)
        {
            this.Edges.Add(new Edge(this, endNode, weight));
        }

    }
        
    }

