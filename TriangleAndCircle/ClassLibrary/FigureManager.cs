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
			var target = _figures[index];
			var position = FigureJudge.IsPointsInnerCircle(target.TrianglePoints, target.CircleCenterPoint, target.CircleRadius);
			var isPointInnerTriagle = FigureJudge.IsPointInnerTriagle(target.TrianglePoints, target.CircleCenterPoint);

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

		public int Count => _figures.Count();

		private List<FigureHolder> _figures;
	}
}
