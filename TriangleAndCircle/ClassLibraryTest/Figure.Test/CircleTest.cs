using ClassLibrary.FIgures;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Windows;

namespace ClassLibraryTest.Figure.Test
{
    [TestClass]
    public class CircleTest
    {
		[TestMethod]
		public void PointAndRadiusTest()
		{
			var point = new Point(10, 20);
			var radius = 5;
			var target = new Circle(point, radius);

			Assert.AreEqual(10, target.CircleCenterPoint.X);
			Assert.AreEqual(20, target.CircleCenterPoint.Y);
			Assert.AreEqual(5, target.CircleRadius);
		}
	}
}
