using System.IO;
using Codemasters.Telemetry.F12019.Packets;
using Codemasters.Telemetry.F12019.Structures;

namespace Codemasters.Telemetry.F12019.Readers
{
    public class EventDataReader
	{
		public EventData Read(BinaryReader input, PacketHeader packetHeader)
		{
			var output = new EventData
			{
				Header = packetHeader,

			};

			return output;
		}

	}
}
