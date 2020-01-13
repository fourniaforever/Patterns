using System;

namespace Strategy.Strategies
{
	/// <summary>
	/// ����������� ������� ����� ���������.
	/// </summary>
	public abstract class Strategy
	{
		/// <summary>
		/// ����������� �����, ������� � �������� �������� �� ���������� 
		/// ���������������� �� ��������
		/// </summary>
		public abstract void DoIt();
	}
}
