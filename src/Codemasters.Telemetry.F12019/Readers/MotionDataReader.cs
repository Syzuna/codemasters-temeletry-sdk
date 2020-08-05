using Codemasters.Telemetry.F12019.Packets;
using Codemasters.Telemetry.F12019.Structures;
using System;

namespace Codemasters.Telemetry.F12019.Readers
{
    public class MotionDataReader
	{
		public MotionData Read(Span<byte> input, PacketHeader packetHeader)
		{
			var output = new MotionData
			{
				Header = packetHeader
			};

			for (var i = 0; i < 20; i++)
			{
				output.CarMotion[i] = ReadCarMotion(input);
			}

			return output;
		}

		private CarMotion ReadCarMotion(Span<byte> input)
		{
			return new CarMotion
			{

			};
		}
	}
}
