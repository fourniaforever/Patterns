using System;

namespace Strategy.Strategies
{
	/// <summary>
	/// Стратегия разведки
	/// </summary>
	public class Reconnaissance : Strategy
	{
		/// <summary>
		/// Стратегия разведки
		/// </summary>
		public override void DoIt()
		{
			Console.WriteLine("Та-а-ак, посмотрим!");
		}
	}
}
