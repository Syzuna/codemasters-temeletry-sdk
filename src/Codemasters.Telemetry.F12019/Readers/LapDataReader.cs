using System.IO;
using Codemasters.Telemetry.F12019.Packets;
using Codemasters.Telemetry.F12019.Structures;

namespace Codemasters.Telemetry.F12019.Readers
{
    public class LapDataReader
	{
		public LapData Read(BinaryReader input, PacketHeader packetHeader)
		{
			var output = new LapData
			{
				Header = packetHeader,

			};

			for (var i = 0; i < 20; i++)
			{
				output.CarLaps[i] = ReadCarLap(input);
			}
			return output;
		}

		private CarLap ReadCarLap(BinaryReader reader)
		{
			return new CarLap
			{

			};
		}
	}
}
