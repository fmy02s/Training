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

		[TestMethod]
		public void GetTargetsTest()
		{
			var target = new FigureManager();

			var figure1 = new Triangle(new Point(10, 20), new Point(30, 40), new Point(50, 60));
			var figure2 = new Circle(new Point(10, 20), 5);

			_target.Add(figure1);
			_target.Add(figure2);

			_target.GetTargets(0, out var triangle, out var circle);
			Assert.AreEqual(10, triangle.Points[0].X);
			Assert.AreEqual(20, triangle.Points[0].Y);
			Assert.AreEqual(30, triangle.Points[1].X);
			Assert.AreEqual(40, triangle.Points[1].Y);
			Assert.AreEqual(50, triangle.Points[2].X);
			Assert.AreEqual(60, triangle.Points[2].Y);

			Assert.AreEqual(10, circle.Point.X);
			Assert.AreEqual(20, circle.Point.Y);
			Assert.AreEqual(5, circle.Radius);
		}

		[TestMethod]
		public void ResultCount()
		{
			var _target = new FigureManager();
			Assert.AreEqual(0, _target.OutputResultCount);

			var figure1 = new Triangle(new Point(10, 20), new Point(30, 40), new Point(50, 60));
			var figure2 = new Circle(new Point(10, 20), 5);

			_target.Add(figure1);
			_target.Add(figure2);
			Assert.AreEqual(1, _target.OutputResultCount);

			_target.Add(figure1);
			_target.Add(figure2);
			Assert.AreEqual(2, _target.OutputResultCount);
		}
	}
}
