using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ClassLibraryTest
{
	[TestClass]
	public class FriendManagerTest
	{
		[TestMethod]
		public void GetInviteCountTest1()
		{
			var target = new FriendManager(3);
			Assert.AreEqual(0, target.GetInviteCount(1));

			target.SetFriendshipInfo(1, 2);
			Assert.AreEqual(1, target.GetInviteCount(1));
		}

		// 友達の友達も招待するかどうか
		[TestMethod]
		public void GetInviteCountTest2()
		{
			var target = new FriendManager(3);
			Assert.AreEqual(0, target.GetInviteCount(1));

			target.SetFriendshipInfo(1, 2);
			target.SetFriendshipInfo(2, 3);
			Assert.AreEqual(2, target.GetInviteCount(1));
		}

		// 友達の友達も招待するかどうか
		// 友達(2,4)の友達（3(共通の友達))重複しないか
		[TestMethod]
		public void GetInviteCountTest3()
		{
			var target = new FriendManager(4);
			Assert.AreEqual(0, target.GetInviteCount(1));

			target.SetFriendshipInfo(1, 2);
			target.SetFriendshipInfo(1, 4);
			target.SetFriendshipInfo(2, 3);
			target.SetFriendshipInfo(3, 4);

			Assert.AreEqual(3, target.GetInviteCount(1));
		}
	}
}
