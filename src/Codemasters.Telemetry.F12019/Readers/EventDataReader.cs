using Codemasters.Telemetry.F12019.Packets;
using Codemasters.Telemetry.F12019.Structures;
using System;

namespace Codemasters.Telemetry.F12019.Readers
{
    public class EventDataReader
	{
		public EventData Read(Span<byte> input, PacketHeader packetHeader)
		{
			var output = new EventData
			{
				Header = packetHeader
            };

			return output;
		}

	}
}
