using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ClassLibrary.FIgures
{
	public class Circle : Figure
	{
		public Circle(Point pos, int radius)
		{
			_pos = pos;
			_radius = radius;
		}

		public Point Point => _pos;

		public int Radius => _radius;

		private Point _pos;
		private int _radius;
	}
}
