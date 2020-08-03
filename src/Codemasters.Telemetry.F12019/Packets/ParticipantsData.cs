using Codemasters.Telemetry.F12019.Structures;

namespace Codemasters.Telemetry.F12019.Packets
{
    /// <summary>
    /// Frequency: Every 5 seconds
    /// Size: 1104 bytes
    /// Version: 1
    /// https://forums.codemasters.com/topic/44592-f1-2019-udp-specification/
    /// </summary>
    public class ParticipantsData
    {
        public PacketHeader Header { get; set; } = new PacketHeader();                  // Header

        public byte NumActiveCars;  // Number of active cars in the data – should match number of
                                // cars on HUD
        public Participant[] Participants = new Participant[20];
    }
}
