using System;

namespace Strategy.Strategies
{
	/// <summary>
	/// ��������� �������������� ��������� ��������.
	/// </summary>
	public class Patrol : Strategy
	{
		/// <summary>
		/// ��������� �������������� ��������� ��������.
		/// </summary>
		public override void DoIt()
		{
			Console.WriteLine("���� ����, ����... �������!!!");
		}
	}
}
