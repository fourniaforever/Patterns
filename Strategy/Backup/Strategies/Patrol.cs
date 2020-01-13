using System;

namespace Strategy.Strategies
{
	/// <summary>
	/// Стратегия патрулирования местности войсками.
	/// </summary>
	public class Patrol : Strategy
	{
		/// <summary>
		/// Стратегия патрулирования местности войсками.
		/// </summary>
		public override void DoIt()
		{
			Console.WriteLine("Ходи туда, сюда... Надоело!!!");
		}
	}
}
