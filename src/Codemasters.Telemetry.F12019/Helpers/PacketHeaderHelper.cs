using Codemasters.Telemetry.Core;
using Codemasters.Telemetry.F12019.Structures;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Codemasters.Telemetry.F12019.Helpers
{
    public static class PacketHeaderHelper
    {
        public static PacketHeader ReadHeader(BinaryReader reader)
        {
            return new PacketHeader
            {
                PacketFormat = reader.ReadUInt16(),    // 2019
                GameMajorVersion = reader.ReadByte(),    // Game major version - "X.00"
                GameMinorVersion = reader.ReadByte(),     // Game minor version - "1.XX"
                PacketVersion = reader.ReadByte(),        // Version of this packet type, all start from 1
                PacketId = GetPacketType(reader.ReadByte()),      // Identifier for the packet type, see below (byte PacketId convert to enum)
                SessionUID = reader.ReadUInt64(),           // Unique identifier for the session
                SessionTime = reader.ReadSingle(),       // Session timestamp
                FrameIdentifier = reader.ReadUInt32(),      // Identifier for the frame the data was retrieved on
                PlayerCarIndex = reader.ReadByte()    // Index of player's car in the array
            };
        }

        public static F1PacketType GetPacketType(byte id)
        {
            return (F1PacketType)id;
        }
    }
}
