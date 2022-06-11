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
			_figures = new List<FigureHolder>();
		}

		public void Add(FigureHolder figure)
		{
			_figures.Add(figure);
		}

		public Result GetResult(int index)
		{
			return FigureJudge.GetResult(_figures[index]);
		}

		public int Count => _figures.Count();

		private List<FigureHolder> _figures;
	}
}
