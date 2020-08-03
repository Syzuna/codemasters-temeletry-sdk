using Codemasters.Telemetry.F12019.Helpers;
using Codemasters.Telemetry.F12019.Packets;
using Codemasters.Telemetry.F12019.Structures;
using System.IO;

namespace Codemasters.Telemetry.F12019.Readers
{
    public class CarSetupDataReader
    {
		public bool TryRead(byte[] input, out CarSetupData? output)
		{
			try
			{
				output = Read(input);
				return output != null;
			}
			catch
			{
				output = null;
				return false;
			}
		}

		public CarSetupData? Read(byte[] input)
		{
			var output = new CarSetupData();
			using (MemoryStream stream = new MemoryStream(input))
			using (BinaryReader reader = new BinaryReader(stream))
			{
				output.Header = PacketHeaderHelper.ReadHeader(reader);

				if (output.Header.PacketId != Core.F1PacketType.CarSetups)
					return null;

				for (var i = 0; i< 20; i++)
                {
					output.CarSetups[i] = ReadCarSetup(reader);
                }
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
