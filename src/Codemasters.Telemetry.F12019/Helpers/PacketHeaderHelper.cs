using Codemasters.Telemetry.Core;
using Codemasters.Telemetry.F12019.Structures;
using System;
using System.Buffers.Binary;

namespace Codemasters.Telemetry.F12019.Helpers
{
    public static class PacketHeaderHelper
    {
        public static PacketHeader ReadHeader(Span<byte> input)
        {
            return new PacketHeader
            {
                PacketFormat = BinaryPrimitives.ReadUInt16LittleEndian(input),    // 2019 2 byte
                GameMajorVersion = input[2],    // Game major version - "X.00" 1 byte
                GameMinorVersion = input[3],     // Game minor version - "1.XX" 1 byte
                PacketVersion = input[4],        // Version of this packet type, all start from 1 1 byte
                PacketId = GetPacketType(input[5]),      // Identifier for the packet type, see below (byte PacketId convert to enum) 1 byte
                SessionUID = BinaryPrimitives.ReadUInt64LittleEndian(input.Slice(6)),           // Unique identifier for the session 8 byte
                SessionTime = BitConverter.ToSingle(input.Slice(14)),       // Session timestamp 4 byte
                FrameIdentifier = BinaryPrimitives.ReadUInt32LittleEndian(input.Slice(18)),      // Identifier for the frame the input was retrieved on 4 byte
                PlayerCarIndex = input[22]    // Index of player's car in the array 1 byte
            };
        }

        private static F1PacketType GetPacketType(byte id)
        {
            return (F1PacketType)id;
        }
    }
}
