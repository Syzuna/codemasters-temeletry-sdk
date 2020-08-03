using Codemasters.Telemetry.Core;

namespace Codemasters.Telemetry.F12019.Structures
{
    public class PacketHeader
    {
        public ushort PacketFormat { get; set; }         // 2019
        public byte GameMajorVersion { get; set; }     // Game major version - "X.00"
        public byte GameMinorVersion { get; set; }    // Game minor version - "1.XX"
        public byte PacketVersion { get; set; }        // Version of this packet type, all start from 1
        public F1PacketType PacketId { get; set; }       // Identifier for the packet type, see below (byte PacketId convert to enum)
        public ulong SessionUID { get; set; }           // Unique identifier for the session
        public float SessionTime { get; set; }         // Session timestamp
        public uint FrameIdentifier { get; set; }      // Identifier for the frame the data was retrieved on
        public byte PlayerCarIndex { get; set; }       // Index of player's car in the array
    }
}
