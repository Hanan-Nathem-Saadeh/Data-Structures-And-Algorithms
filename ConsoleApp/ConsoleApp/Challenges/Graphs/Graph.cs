using NPOI.SS.Formula.Functions;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Challenges.Graphs
{
    public class Graph
    {

        private List<GraphNode> MyGraph { get; set; }


        public GraphNode AddNode(int Value)
        {
            GraphNode newNode = new GraphNode(Value);
            if (MyGraph.Contains(newNode))
            {
                throw new Exception("This node is exist on this Graph !");
            }
            else
            {
                MyGraph.Add(newNode);
            }

            return newNode;
        }

        public void AddEdge(GraphNode First, GraphNode Second)
        {
            if (!MyGraph.Contains(First) || !MyGraph.Contains(Second))
            {
                throw new Exception("This node is not exist");
            }
            First.Neighbors.Add(Second);
        }
        public List<GraphNode> getNodes()
        {
            return MyGraph;
        }
        public List<GraphNode> getNeighbors(GraphNode node)
        {
            return MyGraph.Find(N => N.Value == node.Value).Neighbors;
        }
        public int Size()
        {
            return MyGraph.Count();
        }



    }
}
