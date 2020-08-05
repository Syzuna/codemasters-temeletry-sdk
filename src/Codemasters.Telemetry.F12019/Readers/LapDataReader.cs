using Codemasters.Telemetry.F12019.Packets;
using Codemasters.Telemetry.F12019.Structures;
using System;

namespace Codemasters.Telemetry.F12019.Readers
{
    public class LapDataReader
	{
		public LapData Read(Span<byte> input, PacketHeader packetHeader)
		{
			var output = new LapData
			{
				Header = packetHeader
            };

			for (var i = 0; i < 20; i++)
			{
				output.CarLaps[i] = ReadCarLap(input);
			}
			return output;
		}

		private CarLap ReadCarLap(Span<byte> input)
		{
			return new CarLap
			{

			};
		}
	}
}
