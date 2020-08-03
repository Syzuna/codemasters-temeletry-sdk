namespace Codemasters.Telemetry.F12019.Structures
{
    public class CarStatus
    {
        public byte TractionControl { get; set; }          // 0 (off) - 2 (high)
        public byte AntiLockBrakes { get; set; }           // 0 (off) - 1 (on)
        public byte FuelMix { get; set; }                  // Fuel mix - 0 = lean, 1 = standard, 2 = rich, 3 = max
        public byte FrontBrakeBias { get; set; }           // Front brake bias (percentage)
        public byte PitLimiterStatus { get; set; }         // Pit limiter status - 0 = off, 1 = on
        public float FuelInTank { get; set; }               // Current fuel mass
        public float FuelCapacity { get; set; }             // Fuel capacity
        public float FuelRemainingLaps { get; set; }        // Fuel remaining in terms of laps (value on MFD)
        public ushort MaxRPM { get; set; }                   // Cars max RPM, point of rev limiter
        public ushort IdleRPM { get; set; }                  // Cars idle RPM
        public byte MaxGears { get; set; }                 // Maximum number of gears
        public byte DrsAllowed { get; set; }               // 0 = not allowed, 1 = allowed, -1 = unknown
        public byte[] TyresWear { get; set; } = new byte[4];             // Tyre wear percentage
        public byte ActualTyreCompound { get; set; }    // F1 Modern - 16 = C5, 17 = C4, 18 = C3, 19 = C2, 20 = C1
                                                        // 7 = inter, 8 = wet
                                                        // F1 Classic - 9 = dry, 10 = wet
                                                        // F2 – 11 = super soft, 12 = soft, 13 = medium, 14 = hard
                                                        // 15 = wet
        public byte TyreVisualCompound { get; set; }       // F1 visual (can be different from actual compound)
                                                           // 16 = soft, 17 = medium, 18 = hard, 7 = inter, 8 = wet
                                                           // F1 Classic – same as above
                                                           // F2 – same as above
        public byte[] TyresDamage { get; set; } = new byte[4];        // Tyre damage (percentage)
        public byte FrontLeftWingDamage { get; set; }      // Front left wing damage (percentage)
        public byte FrontRightWingDamage { get; set; }     // Front right wing damage (percentage)
        public byte RearWingDamage { get; set; }           // Rear wing damage (percentage)
        public byte EngineDamage { get; set; }             // Engine damage (percentage)
        public byte GearBoxDamage { get; set; }            // Gear box damage (percentage)
        public sbyte VehicleFiaFlags { get; set; }    // -1 = invalid/unknown, 0 = none, 1 = green
                                                      // 2 = blue, 3 = yellow, 4 = red
        public float ErsStoreEnergy { get; set; }           // ERS energy store in Joules
        public byte ErsDeployMode { get; set; }            // ERS deployment mode, 0 = none, 1 = low, 2 = medium
                                                           // 3 = high, 4 = overtake, 5 = hotlap
        public float ErsHarvestedThisLapMGUK { get; set; }  // ERS energy harvested this lap by MGU-K
        public float ErsHarvestedThisLapMGUH { get; set; }  // ERS energy harvested this lap by MGU-H
        public float ErsDeployedThisLap { get; set; }       // ERS energy deployed this lap
    }
}
