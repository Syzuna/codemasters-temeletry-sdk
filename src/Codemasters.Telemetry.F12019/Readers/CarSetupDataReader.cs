using Codemasters.Telemetry.F12019.Packets;
using Codemasters.Telemetry.F12019.Structures;
using System.IO;

namespace Codemasters.Telemetry.F12019.Readers
{
    public class CarSetupDataReader
    {

		public CarSetupData Read(BinaryReader input, PacketHeader packetHeader)
		{
			var output = new CarSetupData
			{
				Header = packetHeader,

			};

			for (var i = 0; i < 20; i++)
			{
				output.CarSetups[i] = ReadCarSetup(input);
			}

			return output;
		}

		private CarSetup ReadCarSetup(BinaryReader reader)
		{
			return new CarSetup
			{
				FrontWing = reader.ReadByte(),
				RearWing = reader.ReadByte(),
				OnThrottle = reader.ReadByte(),
				OffThrottle = reader.ReadByte(),
				FrontCamber = reader.ReadSingle(),
				RearCamber = reader.ReadSingle(),
				FrontToe = reader.ReadSingle(),
				RearToe = reader.ReadSingle(),
				FrontSuspension = reader.ReadByte(),
				RearSuspension = reader.ReadByte(),
				FrontAntiRollBar = reader.ReadByte(),
				RearAntiRollBar = reader.ReadByte(),
				FrontSuspensionHeight = reader.ReadByte(),
				RearSuspensionHeight = reader.ReadByte(),
				BrakePressure = reader.ReadByte(),
				BrakeBias = reader.ReadByte(),
				FrontTyrePressure = reader.ReadSingle(),
				RearTyrePressure = reader.ReadSingle(),
				Ballast = reader.ReadByte(),
				FuelLoad = reader.ReadSingle()
			};
		}

		
	}
}
