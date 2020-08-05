using Codemasters.Telemetry.F12019.Packets;
using Codemasters.Telemetry.F12019.Structures;
using System;

namespace Codemasters.Telemetry.F12019.Readers
{
    public class CarTelemetryDataReader
	{
		public CarTelemetryData Read(Span<byte> input, PacketHeader packetHeader)
		{
			var output = new CarTelemetryData
			{
				Header = packetHeader
            };

			for (var i = 0; i < 20; i++)
			{
				output.CarTelemetries[i] = ReadCarTelemetry(input);
			}

			return output;
		}

		private CarTelemetry ReadCarTelemetry(Span<byte> input)
		{
			return new CarTelemetry
			{

			};
		}
	}
}
