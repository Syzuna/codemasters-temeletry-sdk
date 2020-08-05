using Codemasters.Telemetry.F12019.Packets;
using Codemasters.Telemetry.F12019.Structures;
using System;

namespace Codemasters.Telemetry.F12019.Readers
{
    public class CarStatusDataReader
	{
		public CarStatusData Read(Span<byte> input, PacketHeader packetHeader)
		{
			var output = new CarStatusData
			{
				Header = packetHeader
            };

			for (var i = 0; i < 20; i++)
			{
				output.CarStatuses[i] = ReadCarStatus(input);
			}

			return output;
		}

		private CarStatus ReadCarStatus(Span<byte> input)
		{
			return new CarStatus
			{

			};
		}
	}
}
