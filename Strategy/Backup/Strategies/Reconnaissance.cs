using System;

namespace Strategy.Strategies
{
	/// <summary>
	/// ��������� ��������
	/// </summary>
	public class Reconnaissance : Strategy
	{
		/// <summary>
		/// ��������� ��������
		/// </summary>
		public override void DoIt()
		{
			Console.WriteLine("��-�-��, ���������!");
		}
	}
}
