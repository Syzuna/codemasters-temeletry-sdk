using System.IO;
using Codemasters.Telemetry.F12019.Packets;
using Codemasters.Telemetry.F12019.Structures;

namespace Codemasters.Telemetry.F12019.Readers
{
    public class CarTelemetryDataReader
	{
		public CarTelemetryData Read(BinaryReader input, PacketHeader packetHeader)
		{
			var output = new CarTelemetryData
			{
				Header = packetHeader,

			};

			for (var i = 0; i < 20; i++)
			{
				output.CarTelemetries[i] = ReadCarTelemetry(input);
			}

			return output;
		}

		private CarTelemetry ReadCarTelemetry(BinaryReader reader)
		{
			return new CarTelemetry
			{

			};
		}
	}
}
