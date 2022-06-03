﻿using ClassLibrary.FIgures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ClassLibrary
{
    public static class FigureJudge
    {
        public static Result GetResult(Triangle triangle, Circle circle)
        {
            var position = IsPointsInnerCircle(triangle, circle);
            var isPointInnerTriagle = IsPointInnerTriagle(triangle, circle.Point);

            if (position == 三角形の頂点位置.全て円の中)
                return Result.b_三角形が円に含まれる;

            if (position == 三角形の頂点位置.全て円の外)
            {
                if (isPointInnerTriagle)
                    return Result.a_円が三角形に含まれる;
                else
                    return Result.d_共通部分がない;
            }

            return Result.c_一部共通部分がある;
        }

        // 三角形の各頂点：A, B, C
        // 円の中心点：P
        // 三角形の内側に点があるか
        private static bool IsPointInnerTriagle(Triangle triangle, Point posP)
        {
            var posA = triangle.Points[0];
            var posB = triangle.Points[1];
            var posC = triangle.Points[2];

            var vecAB = new Vector(posB.X - posA.X, posB.Y - posA.Y);
            var vecBP = new Vector(posP.X - posB.X, posP.Y - posB.Y);

            var vecBC = new Vector(posC.X - posB.X, posC.Y - posB.Y);
            var vecCP = new Vector(posP.X - posC.X, posP.Y - posC.Y);

            var vecCA = new Vector(posA.X - posC.X, posA.Y - posC.Y);
            var vecAP = new Vector(posP.X - posA.X, posP.Y - posA.Y);

            //外積
            var c1 = vecAB.X * vecBP.Y - vecAB.Y * vecBP.X;
            var c2 = vecBC.X * vecCP.Y - vecBC.Y * vecCP.X;
            var c3 = vecCA.X * vecAP.Y - vecCA.Y * vecAP.X;

            if ((c1 > 0 && c2 > 0 && c3 > 0) || (c1 < 0 && c2 < 0 && c3 < 0))
                return true;

            return false;
        }

        // 円と点の位置関係
        // 三角形の頂点が円の内側にあるか
        private static 三角形の頂点位置 IsPointsInnerCircle(Triangle triangle, Circle circle)
        {
            int count = 0;
            foreach (var pos in triangle.Points)
            {
                var distance = Math.Sqrt(Math.Pow(pos.X - circle.Point.X, 2) + Math.Pow(pos.Y - circle.Point.Y, 2));
                if (circle.Radius < distance)
                    count++;
            }

            if (count == 3)
                return 三角形の頂点位置.全て円の外;
            else if (count != 0)
                return 三角形の頂点位置.一部円の中;
            else
                return 三角形の頂点位置.全て円の中;
        }
    }
}