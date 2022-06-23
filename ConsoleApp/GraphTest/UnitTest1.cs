using ConsoleApp.Challenges.Graphs;
using System;
using System.Collections.Generic;
using Xunit;

namespace GraphTest
{

    // Code challenge 35 Graph implementation
    public class UnitTest1
    {
        Graph myGraph = new Graph();

        // Node can be successfully added to the graph
        [Fact]
        public void Test1()
        {
            GraphNode node = myGraph.AddNode(2);
            Assert.Contains(node, myGraph.getNodes());

        }
        //An edge can be successfully added to the graph
        [Fact]
        public void Test2()
        {
            GraphNode node1 = myGraph.AddNode(1);
            GraphNode node2 = myGraph.AddNode(2);

            myGraph.AddEdge(node1, node2);

            Assert.NotNull(node1.Edges);
        }
        // A collection of all nodes can be properly retrieved from the graph
        [Fact]
        public void Test3()
        {
            GraphNode node1 = myGraph.AddNode(1);
            GraphNode node2 = myGraph.AddNode(2);
            GraphNode node3 = myGraph.AddNode(3);
            List<GraphNode> expected = new List<GraphNode>() { node1, node2, node3 };
            Assert.Equal(expected, myGraph.getNodes());
        }
        // All appropriate neighbors can be retrieved from the graph
        [Fact]
        public void Test4()
        {
            GraphNode node1 = myGraph.AddNode(1);
            GraphNode node2 = myGraph.AddNode(2);
            GraphNode node3 = myGraph.AddNode(3);
            myGraph.AddEdge(node1, node2);
            myGraph.AddEdge(node1, node3);
            var result = myGraph.getNeighbors(node1);
            Assert.Equal(2, result.Count);
        }
        // The proper size is returned, representing the number of nodes in the graph
        [Fact]
        public void Test5()
        {
            GraphNode node1 = myGraph.AddNode(1);
            GraphNode node2 = myGraph.AddNode(2);
            GraphNode node3 = myGraph.AddNode(3);
            myGraph.AddEdge(node1, node2);
            myGraph.AddEdge(node1, node3);
            var result = myGraph.Size();
            Assert.Equal(3, result);
        }
        // A graph with only one node and edge can be properly returned

        [Fact]
        public void Test6()
        {
            GraphNode node1 = myGraph.AddNode(10);
            myGraph.AddEdge(node1, node1);
            List<GraphNode> result = myGraph.getNodes();
            Assert.Equal(node1, result.ToArray()[0]);
        }
        // An empty graph properly returns null
        [Fact]
        public void Test7()
        {
            List<GraphNode> result = myGraph.getNodes();
            Assert.Null(result);
        }

    }
    }

