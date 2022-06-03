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

        // 三角形の内部に円の中心点が存在 && 三角形の頂点が全て円の外
        [TestMethod]
        public void GetResultTest_1()
        {
            var triangle = new Triangle(new Point(1, 1), new Point(10, 1), new Point(1, 10));
            var circle = new Circle(new Point(3, 3), 1);
            _target.Add(new FigureHolder(triangle, circle));
            Assert.AreEqual(Result.a_円が三角形に含まれる, _target.GetResult(0));
        }

        // 三角形の内部に円の中心点が存在 && 三角形の頂点が一部円の外
        [TestMethod]
        public void GetResultTest_2()
        {
            var triangle = new Triangle(new Point(2, 2), new Point(10, 1), new Point(2, 10));
            var circle = new Circle(new Point(3, 3), 2);
            _target.Add(new FigureHolder(triangle, circle));

            Assert.AreEqual(Result.c_一部共通部分がある, _target.GetResult(0));
        }

        // 三角形の内部に円の中心点が存在 && 三角形の頂点が全て円の中
        [TestMethod]
        public void GetResultTest_3()
        {
            var triangle = new Triangle(new Point(3, 4), new Point(4, 3), new Point(2, 3));
            var circle = new Circle(new Point(3, 3), 3);
            _target.Add(new FigureHolder(triangle, circle));

            Assert.AreEqual(Result.b_三角形が円に含まれる, _target.GetResult(0));
        }

        // 三角形の外部に円の中心点が存在 && 三角形の頂点が全て円の外
        [TestMethod]
        public void GetResultTest_4()
        {
            var triangle = new Triangle(new Point(1, 1), new Point(2, 1), new Point(1, 2));
            var circle = new Circle(new Point(5, 5), 1);
            _target.Add(new FigureHolder(triangle, circle));

            Assert.AreEqual(Result.d_共通部分がない, _target.GetResult(0));
        }

        // 三角形の外部に円の中心点が存在 && 三角形の頂点が一部円の外
        [TestMethod]
        public void GetResultTest_5()
        {
            var triangle = new Triangle(new Point(1, 1), new Point(2, 1), new Point(4, 4));
            var circle = new Circle(new Point(5, 5), 2);
            _target.Add(new FigureHolder(triangle, circle));

            Assert.AreEqual(Result.c_一部共通部分がある, _target.GetResult(0));
        }

        // 三角形の外部に円の中心点が存在 && 三角形の頂点が全て円の中
        [TestMethod]
        public void GetResultTest_6()
        {
            var triangle = new Triangle(new Point(4, 4), new Point(4, 5), new Point(5, 4));
            var circle = new Circle(new Point(5, 5), 5);
            _target.Add(new FigureHolder(triangle, circle));

            Assert.AreEqual(Result.b_三角形が円に含まれる, _target.GetResult(0));
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
