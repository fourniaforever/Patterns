using System;
using Strategy.Strategies;

namespace Strategy
{
	class Program
	{
		[STAThread]
		static void Main(string[] args)
		{
			// —оздаем котика с выбранной стратегией поведени€
			Cat cat = new Cat(new Sleep());

			
			for(int i = 0 ; i < 5 ; i++)
			{
				cat.DoSometring();
			}

			// мен€ем стратегию
			cat.Strategy = new Eat();

		    cat.DoSometring();

			// —обачка в это врем€ играет
			Dog elf = new Dog(new Play());
			elf.DoSometring();
			Console.Read();
		}
	}
}
