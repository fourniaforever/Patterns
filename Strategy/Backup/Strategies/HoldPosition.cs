using System;

namespace Strategy.Strategies
{
	/// <summary>
	/// Стратегия удерживания позиции
	/// </summary>
	public class HoldPosition : Strategy
	{
		/// <summary>
		/// Стратегия удерживания позиции
		/// </summary>
		public override void DoIt()
		{
			Console.WriteLine("Залечь и окопаться!");
		}
	}
}
