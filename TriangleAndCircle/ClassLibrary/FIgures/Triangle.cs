using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ClassLibrary.FIgures
{
	public class Triangle 
	{
		public Triangle(Point pos1, Point pos2, Point pos3)
		{
			_points = new Point[] { pos1, pos2, pos3 };
		}

		public Point[] TrianglePoints => _points;

		private Point[] _points;
	}
}
