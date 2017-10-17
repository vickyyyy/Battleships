///MD Shahrior Shawon Prio
/// ID:101209112

using System;
using System.Collections.Generic;
namespace MyGame
{
	public enum AIOption
	{
		/// <summary>
		/// Easy, total random shooting
		/// </summary>
		Easy,

		/// <summary>
		/// Medium, marks squares around hits
		/// </summary>
		Medium,

		/// <summary>
		/// As medium, but removes shots once it misses
		/// </summary>
		Hard
	}
}
