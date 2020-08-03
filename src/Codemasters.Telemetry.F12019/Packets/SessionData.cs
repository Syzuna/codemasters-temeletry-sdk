using Codemasters.Telemetry.F12019.Structures;

namespace Codemasters.Telemetry.F12019.Packets
{
    /// <summary>
    /// Frequency: 2 per second
    /// Size: 149 bytes
    /// Version: 1
    /// https://forums.codemasters.com/topic/44592-f1-2019-udp-specification/
    /// </summary>
    public class SessionData
    {
        public PacketHeader Header { get; set; } = new PacketHeader();                  // Header

        public byte Weather { get; set; }                // Weather - 0 = clear, 1 = light cloud, 2 = overcast
                                                         // 3 = light rain, 4 = heavy rain, 5 = storm
        public sbyte TrackTemperature { get; set; }       // Track temp. in degrees celsius
        public sbyte AirTemperature { get; set; }          // Air temp. in degrees celsius
        public byte TotalLaps { get; set; }              // Total number of laps in this race
        public ushort TrackLength { get; set; }               // Track length in metres
        public byte SessionType { get; set; }            // 0 = unknown, 1 = P1, 2 = P2, 3 = P3, 4 = Short P
                                                         // 5 = Q1, 6 = Q2, 7 = Q3, 8 = Short Q, 9 = OSQ
                                                         // 10 = R, 11 = R2, 12 = Time Trial
        public sbyte TrackId { get; set; }                 // -1 for unknown, 0-21 for tracks, see appendix
        public byte Formula { get; set; }                    // Formula, 0 = F1 Modern, 1 = F1 Classic, 2 = F2,
                                                             // 3 = F1 Generic
        public ushort SessionTimeLeft { get; set; }       // Time left in session in seconds
        public ushort SessionDuration { get; set; }       // Session duration in seconds
        public byte PitSpeedLimit { get; set; }          // Pit speed limit in kilometres per hour
        public byte GamePaused { get; set; }               // Whether the game is paused
        public byte IsSpectating { get; set; }           // Whether the player is spectating
        public byte SpectatorCarIndex { get; set; }      // Index of the car being spectated
        public byte SliProNativeSupport { get; set; }    // SLI Pro support, 0 = inactive, 1 = active
        public byte NumMarshalZones { get; set; }            // Number of marshal zones to follow
        public MarshalZone[] MarshalZones { get; set; } = new MarshalZone[21];             // List of marshal zones – max 21
        public byte SafetyCarStatus { get; set; }           // 0 = no safety car, 1 = full safety car
                                                            // 2 = virtual safety car
        public byte NetworkGame { get; set; }               // 0 = offline, 1 = online
    }
}
