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
        private bool isWeighted;
        public Graph(bool inputIsWeighted)
        {
            this.MyGraph = new List<GraphNode>();
            this.isWeighted = inputIsWeighted;
        }
        public GraphNode AddNode(string Value)
        {
            GraphNode newNode = new GraphNode(Value);
            MyGraph.Add(newNode);
            return newNode;
        }

        public void AddEdge(GraphNode First, GraphNode Second , int weight)
        {
            if (!this.isWeighted)
            {
                weight = (int)(int?)null;
            }
            First.addEdge(Second, weight);
           

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



        public List<GraphNode> BreadthFirst(GraphNode node)
        {
            List<GraphNode> visitedNodes = new List<GraphNode>();
            Queue<GraphNode> visitQueue = new Queue<GraphNode>();
            List<GraphNode> visited = new List<GraphNode>();
            visitQueue.Enqueue(node);
            visited.Add(node);
            if (visitQueue.Count == 0)
            {
                throw new Exception("no nodes added");
            }
            while (visitQueue.Count != 0)
            {
                GraphNode front = visitQueue.Dequeue();
                visitedNodes.Add(front);
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
            return visitedNodes;
        }

        public int? BusinessTrip(Graph graph, string[] cities)
        {
            var total = 0;
            for (int i = 0; i < cities.Length - 1; i++)
            {
                GraphNode node = graph.GetNodeByValue(cities[i]);
                List<Edge> neighbors = graph.getNeighbors(node);
                for (var j = 0; j < neighbors.Count; j++)
                {
                    if (neighbors[j].getStart().Value == node.Value)
                    {
                        total += neighbors[j].getWeight();
                    }
                }
            }
            if (total == 0)
            {
                return null;
            }
            else
            {
                return total;
            }
        }

        public GraphNode GetNodeByValue(string Value)
        {
            foreach (GraphNode node in MyGraph)

            {
                if (node.Value == Value)
                {
                    return node;
                }
            }
            return null;
        }




    }
}
