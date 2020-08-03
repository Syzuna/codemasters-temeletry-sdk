using Codemasters.Telemetry.F12019.Structures;

namespace Codemasters.Telemetry.F12019.Packets
{
    /// <summary>
    /// Frequency: 2 per second
    /// Size: 843 bytes
    /// Version: 1
    /// https://forums.codemasters.com/topic/44592-f1-2019-udp-specification/
    /// </summary>
    public class CarSetupData
    {
        public static int PacketSize { get; } = 843;

        public PacketHeader Header { get; set; } = new PacketHeader();                  // Header

        public CarSetup[] CarSetups { get; set; } = new CarSetup[20];
    }
}
