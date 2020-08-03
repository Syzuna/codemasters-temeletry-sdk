using Codemasters.Telemetry.Core;
using Codemasters.Telemetry.F12019.Structures;

namespace Codemasters.Telemetry.F12019.Packets
{

    /// <summary>
    /// Frequency: When the event occurs
    /// Size: 32 bytes
    /// Version: 1
    /// https://forums.codemasters.com/topic/44592-f1-2019-udp-specification/
    /// </summary>
    public class EventData
    {
        public PacketHeader Header { get; set; } = new PacketHeader();                  // Header
        public F1EventCode EventCode { get; set; }   // Event string code, see below (uint8 m_eventStringCode[4])

        /// <summary>
        /// Used when EventCode = FTLP, RTMT, TMPT & RCWN
        /// </summary>
        public byte VehicleIndex { get; set; }

        /// <summary>
        /// Used when EventCode = FTLP
        /// </summary>
        public float LapTime { get; set; }
    }

}
