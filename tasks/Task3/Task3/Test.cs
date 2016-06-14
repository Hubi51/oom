using System;
using NUnit.Framework;

namespace Task3
{
	/*Test für die Klasse Tank*/
	[TestFixture]
	public class TankTest
	{
        [Test]
		public void CanCreateTank()
		{
            var x = new Tank(563, "InYourFace");

			Assert.IsTrue(x.Getseriennummer() == 563);
			Assert.IsTrue(x.Getname() == "InYourFace");

		}

		[Test]
		public void CannotCreateTankWithEmptyName1()
		{
			Assert.Catch(() =>
				{
					var x = new Tank( 543, null);
				});
		}

		[Test]
		public void CannotCreateTankWithEmptyName2()
		{
			Assert.Catch(() =>
				{
					var x = new Tank (543, "");
				});
		}

		[Test]
		public void CannotCreateTankWithNegativeSN()
		{
			Assert.Catch(() =>
				{
					var x = new Tank(-1, "Buble");
				});
		}


		/*Test für die Klasse Heal*/

		public class HealTests
		{

			[Test]
			public void CanCreateHeal()
			{
				var x = new Heal(6047 , "Sona");

				Assert.IsTrue(x.Getseriennummer()== 6047);
				Assert.IsTrue(x.Getname() == "Sona");

			}

			[Test]
			public void CannotCreateHealWithEmptyName1()
			{
				Assert.Catch(() =>
					{
						var x = new Heal( 666, null);
					});
			}

			[Test]
			public void CannotCreateHealWithEmptyName2()
			{
				Assert.Catch(() =>
					{
						var x = new Heal(1234, "");
					});
			}

			[Test]
			public void CannotCreateHealWithNegativeSN()
			{
				Assert.Catch(() =>
					{
						var x = new Heal(-1 , "PalaUndSo");
					});
			}
	    }
    }
}
