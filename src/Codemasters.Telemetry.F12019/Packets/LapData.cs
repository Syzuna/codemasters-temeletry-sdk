using Codemasters.Telemetry.F12019.Structures;

namespace Codemasters.Telemetry.F12019.Packets
{
    /// <summary>
    /// Frequency: Rate as specified in menus
    /// Size: 843 bytes
    /// Version: 1
    /// https://forums.codemasters.com/topic/44592-f1-2019-udp-specification/
    /// </summary>
    public class LapData
    {
        public PacketHeader Header { get; set; } = new PacketHeader();                  // Header

        public CarLap[] CarLaps { get; set; } = new CarLap[20];         // Lap data for all cars on track
         
    }
}
