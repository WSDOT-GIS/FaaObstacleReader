using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Faa.Contracts;
using System.Reflection;
using System.IO;

namespace FaaObstructionTest
{
	[TestClass]
	public class UnitTest1
	{
		[TestProperty("path", @"53-WA.Dat")]
		[TestMethod]
		public void TestMethod1()
		{
			List<Obstacle> obstacles;
			DateTime currencyDate;

			// Get test properties as a dictionary.
			var attributes = MethodInfo.GetCurrentMethod().GetCustomAttributes(typeof(TestPropertyAttribute), false).Select(a => (TestPropertyAttribute)a).ToDictionary(a => a.Name, a => a.Value);
			string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), attributes["path"]);

			Assert.IsTrue(File.Exists(path), "File not found: {0}", path);

			using (var reader = new DigitalObstacleFileReader(path))
			{
				currencyDate = reader.CurrencyDate;
				obstacles = reader.ReadObstacles();
			}

			Assert.AreNotEqual<DateTime>(currencyDate, default(DateTime), "The currency date should not be set to the default value. ({0})", currencyDate);

			CollectionAssert.AllItemsAreNotNull(obstacles, "Null obstacle detected.");

		}
	}
}
