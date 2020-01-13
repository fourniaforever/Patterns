using System;

namespace Strategy
{
	/// <summary>
	/// Класс человеческого стрелка Elf.
	/// </summary>
	public class Dog
	{
		// поле для хранения текущей стратегии
		Strategy.Strategies.Strategy strat;

		/// <summary>
		/// Конструктор. Позволяет создать объект, задав ему текущую 
		/// стратегию поведения
		/// </summary>
		/// <param name="strat">Стратегия поведения</param>
		public Dog(Strategy.Strategies.Strategy strat)
		{
			this.strat = strat;
		}

		/// <summary>
		/// Свойство, позволяющее узнать и задать текущую стретегию поведения.
		/// </summary>
		public Strategy.Strategies.Strategy Strategy
		{
			get { return strat; }
			set { strat = value; }
		}

		/// <summary>
		/// Выполнение текущего действия
		/// </summary>
		public void DoSometring()
		{
			strat.DoIt();
		}
	}
}
