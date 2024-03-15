using lab1_grzebieluch_3;
using System.Security.Cryptography;

// dodac usuniete valuesum i itemsize

namespace test_lab1_grzebieluch
{
	[TestClass]
	public class UnitTest1
	{
		private Item t1, t2, t3, t4;
		//private Item[] lt = { new Item(1, 2), new Item(2, 1) };
	

		[TestMethod]
		public void SetupCheck()
		{
			t1 = new Item(1, 1);
		}

		// poprawiæ, bo tablica przy sortowaniu nie moze byc pusta

		[TestMethod]
		public void NullCheck()
		{
			t2 = new Item(0, 0);
			t3 = new Item(0, 0);
			t4 = new Item(0, 0);

			var capacity = 14;
			var elements = 3;
			var testBag = new Knapsack(elements, capacity);
			testBag.Sort();
			testBag.Fit();
			//testBag.Result();
			Assert.AreEqual(t2.inside, false);
		}

		[TestMethod]
		public void ProportionCheck()
		{
			t1 = new Item(1, 1);
			double a = 1;
			Assert.AreEqual(t1.proportion, a);
		}

		[TestMethod]
		public void RandomCheck_1()
		{
			int seed = 7;	// hardcoded
			Random random = new Random(seed);
			int x = random.Next(10);
			Assert.IsTrue(x >= 1);
		}

		[TestMethod]
		public void RandomCheck_2()
		{
			int seed = 7;   // hardcoded
			Random random = new Random(seed);
			int x = random.Next(10);
			Assert.IsTrue(x <= 10);
		}

		[TestMethod]
		public void GenerateCheck()
		{
			var capacity = 14;
			var elements = 12;
			var testBag = new Knapsack(elements, capacity);
			testBag.Generate();
			Assert.AreEqual(testBag.ItemSize, 12);
		}

		
		[TestMethod]
		public void ValueCheck()
		{
			var capacity = 14;
			var elements = 12;
			var testBag = new Knapsack(elements, capacity);
			testBag.Generate();
			testBag.Sort();
			testBag.Fit();
			testBag.Result();
			Assert.AreEqual(testBag.ValueSum, 31);		// dla c 14, nr 12 i seed 7 wygenerowa³o value sum 31, tw 12
		}
	}
}
