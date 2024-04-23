using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EasyTool.Tests
{
	[TestClass]
	public class IdUtilTests
	{
		[TestMethod]
		public void NextSequenceUUID_AreGreaterThan()
		{
			var uuid1 = IdUtil.UUID(UUIDStyle.Sequence);
			Thread.Sleep(10);
			var uuid2 = IdUtil.UUID(UUIDStyle.Sequence);

			Assert.IsTrue(uuid2.ToString().CompareTo(uuid1.ToString()) > 0);
		}

		[TestMethod]
		public void NextSnowflakeId_AreGreaterThan()
		{
			var snowflakeId1 = IdUtil.SnowflakeId();
			Thread.Sleep(10);
			var snowflakeId2 = IdUtil.SnowflakeId();

			Assert.IsTrue(snowflakeId1 > 0 && snowflakeId1 < snowflakeId2);
		}
	}
}