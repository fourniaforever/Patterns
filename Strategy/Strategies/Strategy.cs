using System;

namespace Strategy.Strategies
{
	/// <summary>
	/// Абстрактный базовый класс стратегий.
	/// </summary>
	public abstract class Strategy
	{
		/// <summary>
		/// абстрактный метод, который в потомках отвечает за реализацию 
		/// соответствующего им действия
		/// </summary>
		public abstract void DoIt();
	}
}
