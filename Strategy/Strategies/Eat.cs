using System;

namespace Strategy.Strategies
{
	public class Eat : Strategy
	{
		/// <summary>
		/// ������
		/// </summary>
		public override void DoIt()
		{
			Console.WriteLine("*����� ��������*");
		}
	}
}
