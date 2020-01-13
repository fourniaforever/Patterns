using System;

namespace Strategy.Strategies
{
	public class Play : Strategy
	{
		/// <summary>
		/// Играть
		/// </summary>
		public override void DoIt()
		{
			Console.WriteLine("игрушка-игрушка!!!");
		}
	}
}
