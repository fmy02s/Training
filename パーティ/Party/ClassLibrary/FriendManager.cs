using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
	public class FriendManager
	{

		public FriendManager(int studentCount)
		{
			_students = new bool[studentCount, studentCount] ;
			_studentCount = studentCount;
		}

		public void SetFriendshipInfo(int studentNo1, int studentNo2)
		{
			// indexは0から始まるため-1を行う
			_students[studentNo1 - 1, studentNo2 - 1] = true;
			_students[studentNo2 - 1, studentNo1 - 1] = true;
		}

		public int GetInviteCount(int studentNo)
		{
			int inviteCount = 0;
			var addInvitationNo = new List<int>();
			for (int i = 0; i < _studentCount; i++)
			{
				if (!_students[studentNo - 1, i])
					continue;

				inviteCount++;

				//友達の友達のチェック
				for (int j = 0; j < _studentCount; j++)
				{
					if (!_students[i, j])
						continue;

					//既に友達もしくは自身かの確認
					if (_students[studentNo - 1, j] || (studentNo - 1 == j))
						continue;

					if (!addInvitationNo.Contains(j))
						addInvitationNo.Add(j);
				}
			}
			inviteCount += addInvitationNo.Count;
			return inviteCount;
		}

		private bool[,] _students;
		private int _studentCount;
	}
}
