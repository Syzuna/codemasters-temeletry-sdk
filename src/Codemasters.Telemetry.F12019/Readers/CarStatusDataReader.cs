using System.IO;
using Codemasters.Telemetry.F12019.Packets;
using Codemasters.Telemetry.F12019.Structures;

namespace Codemasters.Telemetry.F12019.Readers
{
	public class CarStatusDataReader
	{
		public CarStatusData Read(BinaryReader input, PacketHeader packetHeader)
		{
			var output = new CarStatusData
			{
				Header = packetHeader,

			};

			for (var i = 0; i < 20; i++)
			{
				output.CarStatuses[i] = ReadCarStatus(input);
			}

			return output;
		}

		private CarStatus ReadCarStatus(BinaryReader reader)
		{
			return new CarStatus
			{

			};
		}
	}
}
