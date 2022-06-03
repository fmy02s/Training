using ClassLibrary.FIgures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ClassLibrary
{
    public class FigureHolder
    {
        public FigureHolder(Triangle triangle,Circle circle)
		{
            _triangle = triangle;
            _circle = circle;
        }

        public Point CircleCenterPoint => _circle.CircleCenterPoint;
        public int CircleRadius => _circle.CircleRadius;

        public Point[] TrianglePoints => _triangle.TrianglePoints;


        private Circle _circle;
        private Triangle _triangle;
    }
}
