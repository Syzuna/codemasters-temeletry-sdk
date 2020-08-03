using Codemasters.Telemetry.F12019.Structures;

namespace Codemasters.Telemetry.F12019.Packets
{
    /// <summary>
    /// Frequency: Rate as specified in menus
    /// Size: 1143 bytes
    /// Version: 1
    /// https://forums.codemasters.com/topic/44592-f1-2019-udp-specification/
    /// </summary>
    public class CarStatusData
    {
        public PacketHeader Header { get; set; } = new PacketHeader();                  // Header

        public CarStatus[] CarStatuses { get; set; } = new CarStatus[20];
    }
}
