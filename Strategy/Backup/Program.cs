using System;
using Strategy.Strategies;

namespace Strategy
{
	class Program
	{
		[STAThread]
		static void Main(string[] args)
		{
			// ������� �������� � ��������� ���������� ���������
			Berserk bers = new Berserk(new Patrol());

			// ���������� ��� 5 ��� ������� � �������
			for(int i = 0 ; i < 5 ; i++)
			{
				bers.DoSometring();
			}

			// ������ ���������
			bers.Strategy = new HoldPosition();

			// � �� ���������� ��������� �������
			bers.DoSometring();

			// ���� � ��� ����� ���� � ��������
			Elf elf = new Elf(new Reconnaissance());
			elf.DoSometring();
			Console.Read();
		}
	}
}
