using ClassLibrary;
using ClassLibrary.FIgures;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Windows;

namespace ClassLibraryTest
{
    [TestClass]
    public class FigureManagerTest
    {
        FigureManager _target;

        [TestInitialize]
        public void TestInitialize()
        {
            _target = new FigureManager();
        }

        //[TestMethod]
        //public void GetTargetsTest()
        //{
        //	var target = new FigureManager();

        //	var figure1 = new Triangle(new Point(10, 20), new Point(30, 40), new Point(50, 60));
        //	var figure2 = new Circle(new Point(10, 20), 5);

        //	_target.Add(new FigureHolder(figure1, figure2));

        //	_target.GetTargetFigure(0, out var triangle, out var circle);
        //	Assert.AreEqual(10, triangle.TrianglePoints[0].X);
        //	Assert.AreEqual(20, triangle.TrianglePoints[0].Y);
        //	Assert.AreEqual(30, triangle.TrianglePoints[1].X);
        //	Assert.AreEqual(40, triangle.TrianglePoints[1].Y);
        //	Assert.AreEqual(50, triangle.TrianglePoints[2].X);
        //	Assert.AreEqual(60, triangle.TrianglePoints[2].Y);

        //	Assert.AreEqual(10, circle.CircleCenterPoint.X);
        //	Assert.AreEqual(20, circle.CircleCenterPoint.Y);
        //	Assert.AreEqual(5, circle.CircleRadius);
        //}

        //[TestMethod]
        //public void ResultCount()
        //{
        //	var _target = new FigureManager();
        //	Assert.AreEqual(0, _target.OutputResultCount);

        //	var figure1 = new Triangle(new Point(10, 20), new Point(30, 40), new Point(50, 60));
        //	var figure2 = new Circle(new Point(10, 20), 5);

        //	_target.Add(figure1);
        //	_target.Add(figure2);
        //	Assert.AreEqual(1, _target.OutputResultCount);

        //	_target.Add(figure1);
        //	_target.Add(figure2);
        //	Assert.AreEqual(2, _target.OutputResultCount);
        //}
    }
}
