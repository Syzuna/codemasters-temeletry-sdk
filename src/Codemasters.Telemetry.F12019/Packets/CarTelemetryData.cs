using Codemasters.Telemetry.F12019.Structures;
namespace Codemasters.Telemetry.F12019.Packets
{
    /// <summary>
    /// Frequency: Rate as specified in menus
    /// Size: 1347 bytes
    /// Version: 1
    /// https://forums.codemasters.com/topic/44592-f1-2019-udp-specification/
    /// </summary>
    public class CarTelemetryData
    {
        public PacketHeader Header { get; set; } = new PacketHeader();                  // Header

        public Structures.CarTelemetry[] CarTelemetries { get; set; } = new Structures.CarTelemetry[20];

        public int ButtonStatus { get; set; }      // Bit flags specifying which buttons are being pressed
                                                   // currently - see appendices
    }
}
