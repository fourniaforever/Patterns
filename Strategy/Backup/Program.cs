using System;
using Strategy.Strategies;

namespace Strategy
{
	class Program
	{
		[STAThread]
		static void Main(string[] args)
		{
			// Создаем берсерка с выбранной стратегией поведения
			Berserk bers = new Berserk(new Patrol());

			// Заставляем его 5 раз сходить в патруль
			for(int i = 0 ; i < 5 ; i++)
			{
				bers.DoSometring();
			}

			// меняем стратегию
			bers.Strategy = new HoldPosition();

			// и он удерживает выбранную позицию
			bers.DoSometring();

			// Эльф в это время идет в разведку
			Elf elf = new Elf(new Reconnaissance());
			elf.DoSometring();
			Console.Read();
		}
	}
}
