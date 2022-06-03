using ClassLibrary;
using ClassLibrary.FIgures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace TriangleAndCircle
{
    public class MainProgram
    {
        static void Main(string[] args)
        {
            var _figureManager = new FigureManager();
            do
            {
                InputTriangleParameters(out var triangle, out bool isCancleInput);

                if (isCancleInput)
                    break;

                InputCircleParameters(out var circle);
                _figureManager.Add(new FigureHolder(triangle, circle));

            } while (true);

            //判定
            for (int i = 0; i < _figureManager.Count; i++)
                Console.WriteLine(_figureManager.GetResult(i));

            Console.ReadLine();
        }

        private static void InputTriangleParameters(out Triangle triangle, out bool isInputCancle)
        {
            Console.WriteLine(INPUT_TRIANGLE_MESSAGE);
            var points = new List<Point>();
            int pos_X, pos_Y;
            isInputCancle = false;
            int inputCount = 0;

            do
            {
                try
                {
                    var inputStr = Console.ReadLine().Split(' ');

                    if (!(int.TryParse(inputStr[0], out pos_X) && int.TryParse(inputStr[1], out pos_Y)))
                    {
                        throw new FormatException();
                    }

                    if (pos_X == 0 && pos_Y == 0 && points.Count() == 0)
                    {
                        isInputCancle = true;
                        triangle = null;
                        return;
                    }
                    if (!(IsValidValue(pos_X) && IsValidValue(pos_Y)))
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                    points.Add(new Point(pos_X, pos_Y));
                    inputCount++;
                }
                catch (Exception e)
                {
                    Console.WriteLine(INPUT_ERROR_MESSAGE + e.Message);
                }
            } while (inputCount < TRIANGLE_VERTEX);

            triangle = new Triangle(points[0], points[1], points[2]);
        }

        private static void InputCircleParameters(out Circle circle)
        {
            Console.WriteLine(INPUT_CIRCLE_MESSAGE);
            int circle_X, circle_Y, radius;
            do
            {
                try
                {
                    var inputStr = Console.ReadLine().Split(' ');
                    if (!(int.TryParse(inputStr[0], out circle_X) && int.TryParse(inputStr[1], out circle_Y)))
                    {
                        throw new FormatException();
                    }
                    if (!(int.TryParse(Console.ReadLine(), out radius)))
                    {
                        throw new FormatException();
                    }
                    if (!(IsValidValue(circle_X) && IsValidValue(circle_Y) && IsValidValue(radius)))
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                    break;
                }
                catch (FormatException e)
                {
                    Console.WriteLine(INPUT_ERROR_MESSAGE + e);
                }
                catch(ArgumentOutOfRangeException e)
                {
                    Console.WriteLine(INPUT_ERROR_MESSAGE + e);
                }
            } while (true);

            var circlePos = new Point(circle_X, circle_Y);
            circle = new Circle(circlePos, radius);
        }

        private static bool IsValidValue(int inputValue)
        {
            if (MIN_INPUT_VALUE > inputValue || MAX_INPUT_VALUE < inputValue)
            {
                return false;
            }
            return true;
        }

        private const int MIN_INPUT_VALUE = 1;
        private const int MAX_INPUT_VALUE = 10000;
        private const int TRIANGLE_VERTEX = 3;
        private const string INPUT_TRIANGLE_MESSAGE = "3角形の頂点の座標を入力してください";
        private const string INPUT_CIRCLE_MESSAGE = "円の中心座標と半径を入力してください";
        private const string INPUT_ERROR_MESSAGE = "入力値が正しくありません。もう一度入力してください。\n";

    }
}
