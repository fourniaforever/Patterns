using System;

namespace Strategy.Strategies
{
	public class Sleep : Strategy
	{
		/// <summary>
		/// ���
		/// </summary>
		public override void DoIt()
		{
			Console.WriteLine("zzz...");
		}
	}
}
