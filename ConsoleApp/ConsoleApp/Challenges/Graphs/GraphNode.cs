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
        public List<Edge> edges;
        public bool Visited { get; set; }
        public GraphNode(int Value)
        {
           this.Value = Value;
            this.edges = new List<Edge>();
        }
        public void addEdge(GraphNode endVertex)
        {
            this.edges.Add(new Edge(this, endVertex));
        }

    }
        
    }

