using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Party
{
	class MainProblem
	{
		private const int MIN_STUDENTS = 1;
		private const int MAX_STUDENTS = 500;
		private const int MIN_LIST_LENGTH = 1;
		private const int MAX_LIST_LENGTH = 10000;

		static void Main(string[] args)
		{
			Console.WriteLine("生徒数を入力してください");
			var studentCount = GetInputNumericalValue(MIN_STUDENTS, MAX_STUDENTS);

			Console.WriteLine("リストの長さを入力してください");
			var listLength = GetInputNumericalValue(MIN_LIST_LENGTH, MAX_LIST_LENGTH);

			var friendManager = new FriendManager(studentCount);

			for (var i = 0; i < listLength; i++)
			{
				InputFriendshipInfo(studentCount, out int studentNo1, out int studentNo2);
				friendManager.SetFriendshipInfo(studentNo1, studentNo2);
			}

			Console.WriteLine(friendManager.GetInviteCount(1));
			Console.ReadLine();
		}

		private static int GetInputNumericalValue(int minValue, int maxValue)
		{
			int value;
			bool isValid = false;
			do
			{
				isValid = int.TryParse(Console.ReadLine(), out value);

				if (!isValid)
					continue;

				if (value < minValue || maxValue < value)
					isValid = false;

			} while (!isValid);

			return value;
		}

		private static void InputFriendshipInfo(int studentCount, out int studentNo1, out int studentNo2)
		{
			bool isValid = false;
			int no1 = 0;
			int no2 = 0;
			do
			{
				var inputValue = Console.ReadLine().Split(' ');

				if (!int.TryParse(inputValue[0], out no1))
					continue;

				if (!int.TryParse(inputValue[1], out no2))
					continue;

				isValid = ValidStudentNo(no1, no2, studentCount);
			} while (!isValid);

			studentNo1 = no1;
			studentNo2 = no2;
		}

		private static bool ValidStudentNo(int studentNo1, int studentNo2, int studentCount)
		{
			if (studentNo2 <= studentNo1)
				return false;

			if (studentNo1 < MIN_STUDENTS || studentCount < studentNo1)
				return false;

			if (studentNo2 < MIN_STUDENTS || studentCount < studentNo2)
				return false;

			return true;
		}
	}
}
