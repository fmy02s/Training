﻿using ClassLibrary.FIgures;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Windows;

namespace ClassLibraryTest.Figure.Test
{
    [TestClass]
    public class TriangleTest
    {
		[TestMethod]
		public void PointsTest()
		{
			var point1 = new Point(10, 20);
			var point2 = new Point(30, 40);
			var point3 = new Point(50, 60);

			var target = new Triangle(point1, point2, point3);

			Assert.AreEqual(3, target.Points.Length);
			Assert.AreEqual(10, target.Points[0].X);
			Assert.AreEqual(20, target.Points[0].Y);
			Assert.AreEqual(30, target.Points[1].X);
			Assert.AreEqual(40, target.Points[1].Y);
			Assert.AreEqual(50, target.Points[2].X);
			Assert.AreEqual(60, target.Points[2].Y);
		}
	}
}
