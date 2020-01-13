using System;
using Strategy.Strategies;

namespace Strategy
{
	class Program
	{
		[STAThread]
		static void Main(string[] args)
		{
			// ������� ������ � ��������� ���������� ���������
			Cat cat = new Cat(new Sleep());

			
			for(int i = 0 ; i < 5 ; i++)
			{
				cat.DoSometring();
			}

			// ������ ���������
			cat.Strategy = new Eat();

		    cat.DoSometring();

			// ������� � ��� ����� ������
			Dog elf = new Dog(new Play());
			elf.DoSometring();
			Console.Read();
		}
	}
}
