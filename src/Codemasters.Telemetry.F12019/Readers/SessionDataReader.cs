using System.IO;
using Codemasters.Telemetry.F12019.Packets;
using Codemasters.Telemetry.F12019.Structures;

namespace Codemasters.Telemetry.F12019.Readers
{
    public class SessionDataReader
	{
		public SessionData Read(BinaryReader input, PacketHeader packetHeader)
		{
			var output = new SessionData
			{
				Header = packetHeader,

			};

			for (var i = 0; i < 21; i++)
			{
				output.MarshalZones[i] = ReadMarshalZones(input);
			}
			return output;
		}

		private MarshalZone ReadMarshalZones(BinaryReader reader)
		{
			return new MarshalZone
			{

			};
		}
	}
}
