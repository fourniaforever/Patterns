using System;

namespace Strategy.Strategies
{
	/// <summary>
	/// ��������� ����������� �������
	/// </summary>
	public class HoldPosition : Strategy
	{
		/// <summary>
		/// ��������� ����������� �������
		/// </summary>
		public override void DoIt()
		{
			Console.WriteLine("������ � ���������!");
		}
	}
}
