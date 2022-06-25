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

        private List<GraphNode> MyGraph;
        public Graph()
        {
            this.MyGraph = new List<GraphNode>();
            
        }
        public GraphNode AddNode(int Value)
        {
            GraphNode newNode = new GraphNode(Value);
            MyGraph.Add(newNode);
            return newNode;
        }

        public void AddEdge(GraphNode First, GraphNode Second)
        {
            if (!MyGraph.Contains(First) || !MyGraph.Contains(Second))
            {
                throw new Exception("This node is not exist");
            }
            Second.addEdge(First);
            First.addEdge(Second);
        }

        public List<GraphNode> getNodes()
        {
            if (MyGraph.Count == 0)
            {
                return null;
            }
            else
            {
                return MyGraph;

            }
        }
        public List<Edge> getNeighbors(GraphNode node)
        {
            return MyGraph.Find(v => v.Value == node.Value).Edges;
        }
        public int Size()
        {
            return MyGraph.Count();
        }
        // Code challenge 36



        public List<GraphNode> BreadthFirst(GraphNode vertex)
        {
            List<GraphNode> visitedVertices = new List<GraphNode>();
            Queue<GraphNode> visitQueue = new Queue<GraphNode>();
            List<GraphNode> visited = new List<GraphNode>();
            visitQueue.Enqueue(vertex);
            visited.Add(vertex);
            if (visitQueue.Count == 0)
            {
                throw new Exception("no nodes added");
            }
            while (visitQueue.Count != 0)
            {
                GraphNode front = visitQueue.Dequeue();
                visitedVertices.Add(front);
                foreach (Edge child in ((GraphNode)front).Edges)
                {
                    GraphNode neighbor = child.getEnd();
                    if (!visited.Contains(neighbor))
                    {
                        visited.Add(neighbor);
                        visitQueue.Enqueue(neighbor);
                    }
                }
            }
            return visitedVertices;
        }



    }
}
