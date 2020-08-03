using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using Codemasters.Telemetry.Core;
using Codemasters.Telemetry.F12019.Helpers;
using Codemasters.Telemetry.F12019.Packets;
using Codemasters.Telemetry.F12019.Readers;
using Codemasters.Telemetry.Udp;

namespace Codemasters.Telemetry.F12019
{
	public class ForzaDataListener : UdpStreamListener,
		IObservable<CarSetupData>,
		IObservable<CarStatusData>,
		IObservable<CarTelemetryData>,
		IObservable<EventData>,
		IObservable<LapData>,
		IObservable<MotionData>,
		IObservable<ParticipantsData>,
		IObservable<SessionData>
	{
		private readonly ICollection<IObserver<CarSetupData>> _carSetupObservers;
		private readonly ICollection<IObserver<CarStatusData>> _carStatusObservers;
		private readonly ICollection<IObserver<CarTelemetryData>> _carTelemetryObservers;
		private readonly ICollection<IObserver<EventData>> _eventDataObservers;
		private readonly ICollection<IObserver<LapData>> _lapDataObservers;
		private readonly ICollection<IObserver<MotionData>> _motionDataObservers;
		private readonly ICollection<IObserver<ParticipantsData>> _participantsDataObservers;
		private readonly ICollection<IObserver<SessionData>> _sessionDataObservers;

		private readonly CarSetupDataReader _carSetupDataReader;
		private readonly CarStatusDataReader _carStatusDataReader;
		private readonly CarTelemetryDataReader _carTelemetryDataReader;
		private readonly EventDataReader _eventDataReader;
		private readonly LapDataReader _lapDataReader;
		private readonly MotionDataReader _motionDataReader;
		private readonly ParticipantsDataReader _participantsDataReader;
		private readonly SessionDataReader _sessionDataReader;

		public ForzaDataListener(int port, IPAddress serverIpAddress) : base(port, serverIpAddress)
		{
			_carSetupObservers = new List<IObserver<CarSetupData>>();
			_carStatusObservers = new List<IObserver<CarStatusData>>();
			_carTelemetryObservers = new List<IObserver<CarTelemetryData>>();
			_eventDataObservers = new List<IObserver<EventData>>();
			_lapDataObservers = new List<IObserver<LapData>>();
			_motionDataObservers = new List<IObserver<MotionData>>();
			_participantsDataObservers = new List<IObserver<ParticipantsData>>();
			_sessionDataObservers = new List<IObserver<SessionData>>();

			_carSetupDataReader = new CarSetupDataReader();
			_carStatusDataReader = new CarStatusDataReader();
			_carTelemetryDataReader = new CarTelemetryDataReader();
			_eventDataReader = new EventDataReader();
			_lapDataReader = new LapDataReader();
			_motionDataReader = new MotionDataReader();
			_participantsDataReader = new ParticipantsDataReader();
			_sessionDataReader = new SessionDataReader();
		}

		public IDisposable Subscribe(IObserver<CarSetupData> observer)
		{
			if (!_carSetupObservers.Contains(observer))
			{
				_carSetupObservers.Add(observer);
			}
			return new F1Unsubscriber2019<CarSetupData>(_carSetupObservers, observer);
		}

		public IDisposable Subscribe(IObserver<CarStatusData> observer)
		{
			if (!_carStatusObservers.Contains(observer))
			{
				_carStatusObservers.Add(observer);
			}
			return new F1Unsubscriber2019<CarStatusData>(_carStatusObservers, observer);
		}

		public IDisposable Subscribe(IObserver<CarTelemetryData> observer)
		{
			if (!_carTelemetryObservers.Contains(observer))
			{
				_carTelemetryObservers.Add(observer);
			}
			return new F1Unsubscriber2019<CarTelemetryData>(_carTelemetryObservers, observer);
		}

		public IDisposable Subscribe(IObserver<EventData> observer)
		{
			if (!_eventDataObservers.Contains(observer))
			{
				_eventDataObservers.Add(observer);
			}
			return new F1Unsubscriber2019<EventData>(_eventDataObservers, observer);
		}

		public IDisposable Subscribe(IObserver<LapData> observer)
		{
			if (!_lapDataObservers.Contains(observer))
			{
				_lapDataObservers.Add(observer);
			}
			return new F1Unsubscriber2019<LapData>(_lapDataObservers, observer);
		}

		public IDisposable Subscribe(IObserver<MotionData> observer)
		{
			if (!_motionDataObservers.Contains(observer))
			{
				_motionDataObservers.Add(observer);
			}
			return new F1Unsubscriber2019<MotionData>(_motionDataObservers, observer);
		}

		public IDisposable Subscribe(IObserver<ParticipantsData> observer)
		{
			if (!_participantsDataObservers.Contains(observer))
			{
				_participantsDataObservers.Add(observer);
			}
			return new F1Unsubscriber2019<ParticipantsData>(_participantsDataObservers, observer);
		}

		public IDisposable Subscribe(IObserver<SessionData> observer)
		{
			if (!_sessionDataObservers.Contains(observer))
			{
				_sessionDataObservers.Add(observer);
			}
			return new F1Unsubscriber2019<SessionData>(_sessionDataObservers, observer);
		}

		protected override void NotifyData(byte[] data)
		{
			base.NotifyData(data);

			try
			{
				using (MemoryStream stream = new MemoryStream(data))
				using (BinaryReader reader = new BinaryReader(stream))
				{
					var packetHeader = PacketHeaderHelper.ReadHeader(reader);

					switch (packetHeader.PacketId)
                    {
						case Core.F1PacketType.CarSetups: NotifyData(_carSetupDataReader.Read(reader, packetHeader)); break;
						case Core.F1PacketType.CarStatus: NotifyData(_carStatusDataReader.Read(reader, packetHeader)); break;
						case Core.F1PacketType.CarTelemetry: NotifyData(_carTelemetryDataReader.Read(reader, packetHeader)); break;
						case Core.F1PacketType.Event: NotifyData(_eventDataReader.Read(reader, packetHeader)); break;
						case Core.F1PacketType.LapData: NotifyData(_lapDataReader.Read(reader, packetHeader)); break;
						case Core.F1PacketType.Motion: NotifyData(_motionDataReader.Read(reader, packetHeader)); break;
						case Core.F1PacketType.Participants: NotifyData(_participantsDataReader.Read(reader, packetHeader)); break;
						case Core.F1PacketType.Session: NotifyData(_sessionDataReader.Read(reader, packetHeader)); break;
					}

				}
			}
			catch (Exception ex)
			{
				// read exception: notified to observers
				NotifyError(new DataException("An error occured while trying to read data", ex));
			}
		}

		protected void NotifyData(CarSetupData data)
		{
			foreach (var observer in _carSetupObservers)
			{
				observer.OnNext(data);
			}
		}

		protected void NotifyData(CarStatusData data)
		{
			foreach (var observer in _carStatusObservers)
			{
				observer.OnNext(data);
			}
		}

		protected void NotifyData(CarTelemetryData data)
		{
			foreach (var observer in _carTelemetryObservers)
			{
				observer.OnNext(data);
			}
		}

		protected void NotifyData(EventData data)
		{
			foreach (var observer in _eventDataObservers)
			{
				observer.OnNext(data);
			}
		}

		protected void NotifyData(LapData data)
		{
			foreach (var observer in _lapDataObservers)
			{
				observer.OnNext(data);
			}
		}

		protected void NotifyData(MotionData data)
		{
			foreach (var observer in _motionDataObservers)
			{
				observer.OnNext(data);
			}
		}

		protected void NotifyData(ParticipantsData data)
		{
			foreach (var observer in _participantsDataObservers)
			{
				observer.OnNext(data);
			}
		}

		protected void NotifyData(SessionData data)
		{
			foreach (var observer in _sessionDataObservers)
			{
				observer.OnNext(data);
			}
		}

		protected void NotifyError(DataException error)
		{
			foreach (var observer in _carSetupObservers)
			{
				observer.OnError(error);
			}
			foreach (var observer in _carStatusObservers)
			{
				observer.OnCompleted();
			}
			foreach (var observer in _carTelemetryObservers)
			{
				observer.OnCompleted();
			}
			foreach (var observer in _eventDataObservers)
			{
				observer.OnCompleted();
			}
			foreach (var observer in _lapDataObservers)
			{
				observer.OnCompleted();
			}
			foreach (var observer in _motionDataObservers)
			{
				observer.OnCompleted();
			}
			foreach (var observer in _participantsDataObservers)
			{
				observer.OnCompleted();
			}
			foreach (var observer in _sessionDataObservers)
			{
				observer.OnCompleted();
			}
		}

		protected override void NotifyCompletion()
		{
			base.NotifyCompletion();

			foreach (var observer in _carSetupObservers)
			{
				observer.OnCompleted();
			}
			foreach (var observer in _carStatusObservers)
			{
				observer.OnCompleted();
			}
			foreach (var observer in _carTelemetryObservers)
			{
				observer.OnCompleted();
			}
			foreach (var observer in _eventDataObservers)
			{
				observer.OnCompleted();
			}
			foreach (var observer in _lapDataObservers)
			{
				observer.OnCompleted();
			}
			foreach (var observer in _motionDataObservers)
			{
				observer.OnCompleted();
			}
			foreach (var observer in _participantsDataObservers)
			{
				observer.OnCompleted();
			}
			foreach (var observer in _sessionDataObservers)
			{
				observer.OnCompleted();
			}
		}
	}
}
