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
        public List<Edge> Edges;

        public GraphNode(int value)
        {
            this.Value = value;
            this.Edges = new List<Edge>();
        }
        public void addEdge(GraphNode endVertex)
        {
            this.Edges.Add(new Edge(this, endVertex));
        }

    }
        
    }

