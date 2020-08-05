using Codemasters.Telemetry.F12019.Packets;
using Codemasters.Telemetry.F12019.Structures;
using System;

namespace Codemasters.Telemetry.F12019.Readers
{
    public class CarSetupDataReader
    {

		public CarSetupData Read(Span<byte> input, PacketHeader packetHeader)
		{
			var output = new CarSetupData
			{
				Header = packetHeader
            };

			for (var i = 0; i < 20; i++)
			{
				output.CarSetups[i] = ReadCarSetup(input);
			}

			return output;
		}

		private CarSetup ReadCarSetup(Span<byte> input)
		{
			return new CarSetup
			{
				FrontWing = input[0], // 1 byte
				RearWing = input[1], // 1 byte
				OnThrottle = input[2], // 1 byte
				OffThrottle = input[3], // 1 byte
				FrontCamber = BitConverter.ToSingle(input.Slice(4)), // 4 byte
				RearCamber = BitConverter.ToSingle(input.Slice(8)), // 4 byte
				FrontToe = BitConverter.ToSingle(input.Slice(12)), // 4 byte
				RearToe = BitConverter.ToSingle(input.Slice(16)), // 4 byte
				FrontSuspension = input[17], // 1 byte
				RearSuspension = input[18], // 1 byte
				FrontAntiRollBar = input[19], // 1 byte
				RearAntiRollBar = input[20], // 1 byte
				FrontSuspensionHeight = input[21], // 1 byte
				RearSuspensionHeight = input[22], // 1 byte
				BrakePressure = input[23], // 1 byte
				BrakeBias = input[24], // 1 byte
				FrontTyrePressure = BitConverter.ToSingle(input.Slice(25)), // 4 byte
				RearTyrePressure = BitConverter.ToSingle(input.Slice(29)), // 4 byte
				Ballast = input[30], // 1 byte
				FuelLoad = BitConverter.ToSingle(input.Slice(31)) // 4 byte
			};
		}

		
	}
}
