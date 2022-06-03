using ClassLibrary.FIgures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class FigureManager
    {
		public FigureManager()
		{
			_figures = new List<Figure>();
		}

		public void Add(Figure figure)
		{
			_figures.Add(figure);
		}

		public void GetTargets(int num, out Triangle triangle, out Circle circle)
		{
			var targets = _figures.Skip(2 * num).Take(2).ToArray();
			triangle = (Triangle)targets[0];
			circle = (Circle)targets[1];
		}

		public int OutputResultCount => _figures.Count() / 2;

		private List<Figure> _figures;
	}
}
