using System;

namespace Strategy
{
	/// <summary>
	/// ����� ������������� ������� Elf.
	/// </summary>
	public class Dog
	{
		// ���� ��� �������� ������� ���������
		Strategy.Strategies.Strategy strat;

		/// <summary>
		/// �����������. ��������� ������� ������, ����� ��� ������� 
		/// ��������� ���������
		/// </summary>
		/// <param name="strat">��������� ���������</param>
		public Dog(Strategy.Strategies.Strategy strat)
		{
			this.strat = strat;
		}

		/// <summary>
		/// ��������, ����������� ������ � ������ ������� ��������� ���������.
		/// </summary>
		public Strategy.Strategies.Strategy Strategy
		{
			get { return strat; }
			set { strat = value; }
		}

		/// <summary>
		/// ���������� �������� ��������
		/// </summary>
		public void DoSometring()
		{
			strat.DoIt();
		}
	}
}
