using System;
using NUnit.Framework;

namespace MyGame
{
	[TestFixture()]
	public class SpecialSkillTest
	{

		[Test()]
		public void ActivateSkillTest ()
		{
			// When SpaceBar is tap, the special skill is activated.
			BattleShipsGame b = new BattleShipsGame ();

			BattleShipsGame.isSpecialSkill (true);

			Assert.AreEqual (b.SpecialSKill, true);
		}

		[Test ()]
		public void SpecialSkillShotsTest ()
		{
			BattleShipsGame b = new BattleShipsGame ();

			BattleShipsGame.isSpecialSkill (true);

			b.Shoot ();

			Assert.AreEqual (b.NumberHit, 5);

			// Once used, the special skill should back to false
			Assert.AreEqual (b.SpecialSKill, false);
		}
	}
}
