using System;

namespace Strategy.Strategies
{
	public class Sleep : Strategy
	{
		/// <summary>
		/// Сон
		/// </summary>
		public override void DoIt()
		{
			Console.WriteLine("zzz...");
		}
	}
}
