using ClassLibrary;
using ClassLibrary.FIgures;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Windows;

namespace ClassLibraryTest
{
    [TestClass]
    public class FigureJudgeTest
    {
        // 三角形の内部に円の中心点が存在 && 三角形の頂点が全て円の外
        [TestMethod]
        public void GetResultTest_1()
        {
            var triangle = new Triangle(new Point(1, 1), new Point(10, 1), new Point(1, 10));
            var circle = new Circle(new Point(3, 3), 1);
            Assert.AreEqual(Result.a_円が三角形に含まれる, FigureJudge.GetResult(triangle, circle));
        }

        // 三角形の内部に円の中心点が存在 && 三角形の頂点が一部円の外
        [TestMethod]
        public void GetResultTest_2()
        {
            var triangle = new Triangle(new Point(2, 2), new Point(10, 1), new Point(2, 10));
            var circle = new Circle(new Point(3, 3), 2);
            Assert.AreEqual(Result.c_一部共通部分がある, FigureJudge.GetResult(triangle, circle));
        }

        // 三角形の内部に円の中心点が存在 && 三角形の頂点が全て円の中
        [TestMethod]
        public void GetResultTest_3()
        {
            var triangle = new Triangle(new Point(3, 4), new Point(4, 3), new Point(2, 3));
            var circle = new Circle(new Point(3, 3), 3);
            Assert.AreEqual(Result.b_三角形が円に含まれる, FigureJudge.GetResult(triangle, circle));
        }

        // 三角形の外部に円の中心点が存在 && 三角形の頂点が全て円の外
        [TestMethod]
        public void GetResultTest_4()
        {
            var triangle = new Triangle(new Point(1, 1), new Point(2, 1), new Point(1, 2));
            var circle = new Circle(new Point(5, 5), 1);
            Assert.AreEqual(Result.d_共通部分がない, FigureJudge.GetResult(triangle, circle));
        }

        // 三角形の外部に円の中心点が存在 && 三角形の頂点が一部円の外
        [TestMethod]
        public void GetResultTest_5()
        {
            var triangle = new Triangle(new Point(1, 1), new Point(2, 1), new Point(4, 4));
            var circle = new Circle(new Point(5, 5), 2);
            Assert.AreEqual(Result.c_一部共通部分がある, FigureJudge.GetResult(triangle, circle));
        }

        // 三角形の外部に円の中心点が存在 && 三角形の頂点が全て円の中
        [TestMethod]
        public void GetResultTest_6()
        {
            var triangle = new Triangle(new Point(4, 4), new Point(4, 5), new Point(5, 4));
            var circle = new Circle(new Point(5, 5), 5);
            Assert.AreEqual(Result.b_三角形が円に含まれる, FigureJudge.GetResult(triangle, circle));
        }
    }
}
