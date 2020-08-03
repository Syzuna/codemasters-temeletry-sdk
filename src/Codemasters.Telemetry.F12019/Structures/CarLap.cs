
namespace Codemasters.Telemetry.F12019.Structures
{
    public class CarLap
    {
        public float LastLapTime { get; set; }             // Last lap time in seconds
        public float CurrentLapTime { get; set; }  // Current time around the lap in seconds
        public float BestLapTime { get; set; }         // Best lap time of the session in seconds
        public float Sector1Time { get; set; }         // Sector 1 time in seconds
        public float Sector2Time { get; set; }         // Sector 2 time in seconds
        public float LapDistance { get; set; }         // Distance vehicle is around current lap in metres – could
                                         // be negative if line hasn’t been crossed yet
        public float TotalDistance { get; set; }       // Total distance travelled in session in metres – could
                                         // be negative if line hasn’t been crossed yet
        public float SafetyCarDelta { get; set; }         // Delta in seconds for safety car
        public byte CarPosition { get; set; }     // Car race position
        public byte CurrentLapNum { get; set; }       // Current lap number
        public byte PitStatus { get; set; }               // 0 = none, 1 = pitting, 2 = in pit area
        public byte Sector { get; set; }                  // 0 = sector1, 1 = sector2, 2 = sector3
        public byte CurrentLapInvalid { get; set; }       // Current lap invalid - 0 = valid, 1 = invalid
        public byte Penalties { get; set; }               // Accumulated time penalties in seconds to be added
        public byte GridPosition { get; set; }            // Grid position the vehicle started the race in
        public byte DriverStatus { get; set; }            // Status of driver - 0 = in garage, 1 = flying lap
                                            // 2 = in lap, 3 = out lap, 4 = on track
        public byte ResultStatus { get; set; }           // Result status - 0 = invalid, 1 = inactive, 2 = active
                                       // 3 = finished, 4 = disqualified, 5 = not classified
                                       // 6 = retired
    }
}
