using System;

namespace Strategy.Strategies
{
	public class Play : Strategy
	{
		/// <summary>
		/// ������
		/// </summary>
		public override void DoIt()
		{
			Console.WriteLine("�������-�������!!!");
		}
	}
}
