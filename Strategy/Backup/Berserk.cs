using System;
using Strategy.Strategies;

namespace Strategy
{
	/// <summary>
	/// ����� ���������� �������
	/// </summary>
	public class Berserk
	{
		// ���� ��� �������� ������� ���������
		Strategy.Strategies.Strategy strat;

		/// <summary>
		/// �����������. ��������� ������� ������, ����� ��� ������� 
		/// ��������� ���������
		/// </summary>
		/// <param name="strat">��������� ���������</param>
		public Berserk(Strategy.Strategies.Strategy strat)
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
