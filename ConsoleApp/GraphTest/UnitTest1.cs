using ConsoleApp.Challenges.Graphs;
using System;
using System.Collections.Generic;
using Xunit;

namespace GraphTest
{

    // Code challenge 35 Graph implementation
    public class UnitTest1
    {
        Graph myGraph = new Graph(true);

        // Code challenge 37 Business Trip
        [Fact]
        public void BussinesTrip1()
        {

            var ArendelleVertex = myGraph.AddNode("Arendelle");
            var MetrovilleVertex = myGraph.AddNode("Metroville");
            var PandoraVertex = myGraph.AddNode("Pandora");

            myGraph.AddEdge(PandoraVertex, ArendelleVertex, 150);
            myGraph.AddEdge(ArendelleVertex, MetrovilleVertex, 99);

            string[] arr = { "Pandora", "Arendelle", "Metroville" };
            Assert.Equal(249, myGraph.BusinessTrip(myGraph, arr));
        }
        [Fact]
        public void BussinesTrip2()
        {
            var PandoraVertex = myGraph.AddNode("Pandora");
            var ArendelleVertex = myGraph.AddNode("Arendelle");
            myGraph.AddEdge(PandoraVertex, ArendelleVertex, 0);
            string[] arr = { };
            Assert.Null(myGraph.BusinessTrip(myGraph, arr));

        }
        [Fact]
        public void BussinesTrip3()
        {
            var ArendelleVertex = myGraph.AddNode("Arendelle");
            var MetrovilleVertex = myGraph.AddNode("Metroville");
            var PandoraVertex = myGraph.AddNode("Pandora");

            myGraph.AddEdge(PandoraVertex, ArendelleVertex, 150);
            myGraph.AddEdge(ArendelleVertex, MetrovilleVertex, 99);

            string[] arr = { "Pandora", "Arendelle", "Metroville" };
            Assert.NotEqual(250, myGraph.BusinessTrip(myGraph, arr));
        }





        //// Node can be successfully added to the graph
        //[Fact]
        //public void Test1()
        //{
        //    GraphNode node = myGraph.AddNode(2);
        //    Assert.Contains(node, myGraph.getNodes());

        //}
        ////An edge can be successfully added to the graph
        //[Fact]
        //public void Test2()
        //{
        //    GraphNode node1 = myGraph.AddNode(1);
        //    GraphNode node2 = myGraph.AddNode(2);

        //    myGraph.AddEdge(node1, node2);

        //    Assert.NotNull(node1.Edges);
        //}
        //// A collection of all nodes can be properly retrieved from the graph
        //[Fact]
        //public void Test3()
        //{
        //    GraphNode node1 = myGraph.AddNode(1);
        //    GraphNode node2 = myGraph.AddNode(2);
        //    GraphNode node3 = myGraph.AddNode(3);
        //    List<GraphNode> expected = new List<GraphNode>() { node1, node2, node3 };
        //    Assert.Equal(expected, myGraph.getNodes());
        //}
        //// All appropriate neighbors can be retrieved from the graph
        //[Fact]
        //public void Test4()
        //{
        //    GraphNode node1 = myGraph.AddNode(1);
        //    GraphNode node2 = myGraph.AddNode(2);
        //    GraphNode node3 = myGraph.AddNode(3);
        //    myGraph.AddEdge(node1, node2);
        //    myGraph.AddEdge(node1, node3);
        //    var result = myGraph.getNeighbors(node1);
        //    Assert.Equal(2, result.Count);
        //}
        //// The proper size is returned, representing the number of nodes in the graph
        //[Fact]
        //public void Test5()
        //{
        //    GraphNode node1 = myGraph.AddNode(1);
        //    GraphNode node2 = myGraph.AddNode(2);
        //    GraphNode node3 = myGraph.AddNode(3);
        //    myGraph.AddEdge(node1, node2);
        //    myGraph.AddEdge(node1, node3);
        //    var result = myGraph.Size();
        //    Assert.Equal(3, result);
        //}
        //// A graph with only one node and edge can be properly returned

        //[Fact]
        //public void Test6()
        //{
        //    GraphNode node1 = myGraph.AddNode(10);
        //    myGraph.AddEdge(node1, node1);
        //    List<GraphNode> result = myGraph.getNodes();
        //    Assert.Equal(node1, result.ToArray()[0]);
        //}
        //// An empty graph properly returns null
        //[Fact]
        //public void Test7()
        //{
        //    List<GraphNode> result = myGraph.getNodes();
        //    Assert.Null(result);
        //}

        //// code challenge 36
        //[Fact]
        //public void TestBreadthFirst1()
        //{

        //    GraphNode node1 = myGraph.AddNode(1);
        //    myGraph.AddEdge(node1, node1);
        //    List<GraphNode> result = myGraph.BreadthFirst(node1);
        //    Assert.Equal(1, result[0].Edges[0].getEnd().Value);
        //}
        //[Fact]
        //public void TestBreadthFirst2()
        //{

        //    GraphNode node1 = myGraph.AddNode(1);
        //    GraphNode node2 = myGraph.AddNode(2);

        //    myGraph.AddEdge(node1, node2);
        //    List < GraphNode > mylist = myGraph.BreadthFirst(node1);
        //    List<int> res = new List<int>();
        //    for (int i = 0; i < mylist.Count; i++)
        //    {
        //        res.Add( mylist[i].Value);
        //    }
        //    List<int> expected = new List<int> { 1, 2 };
        //    Assert.Equal(expected, res);
        //}
        //[Fact]
        //public void TestBreadthFirst3()
        //{

        //    GraphNode node1 = myGraph.AddNode(1);
        //    GraphNode node2 = myGraph.AddNode(2);
        //    GraphNode node3 = myGraph.AddNode(3);
        //    GraphNode node4 = myGraph.AddNode(4);
        //    GraphNode node5 = myGraph.AddNode(5);

        //    myGraph.AddEdge(node1, node2);
        //    myGraph.AddEdge(node1, node3);
        //    myGraph.AddEdge(node1, node4);
        //    myGraph.AddEdge(node2, node5);
        //    myGraph.AddEdge(node3, node5);
        //    myGraph.AddEdge(node4, node5);
        //    List<GraphNode> mylist = myGraph.BreadthFirst(node1);
        //    List<int> res = new List<int>();
        //    for (int i = 0; i < mylist.Count; i++)
        //    {
        //        res.Add(mylist[i].Value);
        //    }
        //    List<int> expected = new List<int> { 1, 2 ,3,4,5};
        //    Assert.Equal(expected, res);
        //}





        //[Fact]
        //public void TestBreadthFirst4()
        //{

        //    GraphNode vertex = myGraph.AddNode(1);
        //    GraphNode vertex1 = myGraph.AddNode(2);
        //    myGraph.AddEdge(vertex, vertex1);
        //    List<GraphNode> list = myGraph.BreadthFirst(vertex);
        //    List<GraphNode> expected = new List<GraphNode> { vertex, vertex1 };
        //    Assert.Equal(expected, list);
        //}

    }
    }

