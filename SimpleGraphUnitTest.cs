using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using AlgorithmsDataStructures;
using System.Collections.Generic;
using CodeFuMonastery;
using AlgorithmsDataStructures2;

namespace MSTest
{
    [TestClass]
    public class SimpleGraphUnitTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var sg1 = new SimpleGraph<int>(8);
            sg1.AddVertex(1);
            sg1.AddVertex(2);
            sg1.AddVertex(3);
            sg1.AddVertex(4);
            sg1.AddVertex(5);
            sg1.AddVertex(6);
            sg1.AddVertex(7);
            sg1.AddVertex(8);

            sg1.AddEdge(0,1);
            sg1.AddEdge(0,2);
            sg1.AddEdge(0,3);
            sg1.AddEdge(1,3);
            sg1.AddEdge(2,3);
            sg1.AddEdge(3,4);
            sg1.AddEdge(2,7);
            sg1.AddEdge(4,5);
            sg1.AddEdge(4,6);

            var way1 = sg1.DepthFirstSearch(0,6);
            

            sg1.RemoveEdge(3,4);
            
            var way2 = sg1.DepthFirstSearch(0, 6);

            var way3 = sg1.DepthFirstSearch(0, 7);

            sg1.RemoveVertex(7);
            var way4 = sg1.DepthFirstSearch(0, 7);
            var keke = "";
        }

    }
}
