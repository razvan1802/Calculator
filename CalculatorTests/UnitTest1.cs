using System;
using NUnit.Framework;
using Calculator;

namespace CalculatorTests
{
	[TestFixture]
	public class PlusTests
	{
		[TestCase("", 0)]
		[TestCase("1,2", 3)]
		[TestCase("1 2", 3)]
		[TestCase("1.2,2.1", 3.3)]
		[TestCase("12", 0)]
		[TestCase("a,3", 0)]
		[TestCase("1,-1", 0)]
		public void Plus1Test(string argStr, double result)
		{
			Plus a = new Plus();
			Assert.AreEqual(result, a.Plus1(argStr));
		}



		[TestCase("", 0)]
		[TestCase("1,2", 3)]
		[TestCase("1 2", 3)]
		[TestCase("1.2,2.1", 3.3)]
		[TestCase("12", 0)]
		[TestCase("a,3", 0)]
		[TestCase("1,1,1", 3)]
		[TestCase("1,-2.3,1.9", 0.6)]
		[TestCase("0.3,1.1,2.1", 3.5)]
		[TestCase("1,-1", 0)]
		public void Plus2Test(string argStr, double result)
		{
			Plus a = new Plus();
			Assert.AreEqual(result, a.Plus2(argStr));

		}
		

		[TestCase("", 0)]
		[TestCase("1,2", 3)]
		[TestCase("1 2", 3)]
		[TestCase("1.2,2.1", 3.3)]
		[TestCase("12", 0)]
		[TestCase("a,3", 0)]
		[TestCase("1,1,1", 3)]
		[TestCase("1,-2.3,1.9", 0.6)]
		[TestCase("0.3,1.1,2.1", 3.5)]
		[TestCase("1,-1", 0)]
		[TestCase("1 -1", 0)]
		[TestCase("1&-1", 0)]
		[TestCase("1--1", 0)]
		[TestCase("1@-1", 0)]
		[TestCase("1!-1", 0)]
		[TestCase("1~-1", 0)]
		[TestCase("1	-1", 0)]
		public void Plus3Test(string argStr, double result)
		{
			Plus a = new Plus();
			Assert.AreEqual(result, a.Plus3(argStr));
		}
		

		[TestCase("", 0)]
		[TestCase("1,2", 3)]
		[TestCase("1 2", 3)]
		[TestCase("1.2,2.1", 3.3)]
		[TestCase("12", 0)]
		[TestCase("a,3", 0)]
		[TestCase("1,1,1", 3)]
		[TestCase("1,-2.3,1.9", 0.6)]
		[TestCase("0.3,1.1,2.1", 3.5)]
		[TestCase("1,-1", 0)]
		[TestCase("1 -1", 0)]
		[TestCase("1&-1", 0)]
		[TestCase("1--1", 0)]
		[TestCase("1@-1", 0)]
		[TestCase("1!-1", 0)]
		[TestCase("1~-1", 0)]
		[TestCase("1~1", 2)]
		[TestCase("1	-1", 0)]
		public void Plus4Test(string argStr, double result)
		{
			Plus a = new Plus();
			Assert.AreEqual(result, a.Plus4(argStr));
		}


		[TestCase("", 0)]
		[TestCase("1,2", 3)]
		[TestCase("1 2", 3)]
		[TestCase("1.2,2.1", 3.3)]
		[TestCase("12", 0)]
		[TestCase("a,3", 0)]
		[TestCase("1,1,1", 3)]
		[TestCase("1,-2.3,1.9", 5.2)]
		[TestCase("0.3,1.1,2.1", 3.5)]
		[TestCase("1,-1", 2)]
		[TestCase("1!-1", 2)]
		[TestCase("1~-1", 2)]
		[TestCase("1~1", 2)]
		[TestCase("1~  1", 2)]
		[TestCase("1~ $1", 2)]
		[TestCase("1~+-1", 2)]
		[TestCase("1~!1", 2)]
		[TestCase("1	-1", 2)]
		[TestCase("1!!!-1", 2)]
		[TestCase("1!!!!1", 2)]
		public void Plus5Test(string argStr, double result)
		{
			Plus a = new Plus();
			Assert.AreEqual(result, a.Plus5(argStr));
		}
	}
}
