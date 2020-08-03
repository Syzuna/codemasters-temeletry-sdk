using System.IO;
using Codemasters.Telemetry.F12019.Packets;
using Codemasters.Telemetry.F12019.Structures;

namespace Codemasters.Telemetry.F12019.Readers
{
    public class ParticipantsDataReader
	{
		public ParticipantsData Read(BinaryReader input, PacketHeader packetHeader)
		{
			var output = new ParticipantsData
			{
				Header = packetHeader,

			};

			for (var i = 0; i < 20; i++)
			{
				output.Participants[i] = ReadParticipant(input);
			}

			return output;
		}

		private Participant ReadParticipant(BinaryReader reader)
		{
			return new Participant
			{

			};
		}
	}
}
