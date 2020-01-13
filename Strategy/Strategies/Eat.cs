using System;

namespace Strategy.Strategies
{
	public class Eat : Strategy
	{
		/// <summary>
		/// Кушать
		/// </summary>
		public override void DoIt()
		{
			Console.WriteLine("*звуки чавканья*");
		}
	}
}
