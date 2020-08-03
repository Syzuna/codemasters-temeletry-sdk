using System;
using System.Collections.Generic;

namespace Codemasters.Telemetry.F12019
{
	internal class F1Unsubscriber2019<T> : IDisposable
	{
		private readonly ICollection<IObserver<T>> _observers;
		private readonly IObserver<T> _observer;

		internal F1Unsubscriber2019(ICollection<IObserver<T>> observers, IObserver<T> observer)
		{
			_observers = observers;
			_observer = observer;
		}

		public void Dispose()
		{
			if (_observers.Contains(_observer))
			{
				_observers.Remove(_observer);
			}
		}
	}
}
