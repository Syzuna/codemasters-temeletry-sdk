using System;
using System.Collections.Generic;
using System.Text;

namespace Codemasters.Telemetry.F12019.Structures
{
    public class CarTelemetry
    {
        public ushort Speed { get; set; }                    // Speed of car in kilometres per hour
        public float Throttle { get; set; }                // Amount of throttle applied (0.0 to 1.0)
        public float Steer { get; set; }                   // Steering (-1.0 (full lock left) to 1.0 (full lock right))
        public float Brake { get; set; }                   // Amount of brake applied (0.0 to 1.0)
        public byte Clutch { get; set; }                   // Amount of clutch applied (0 to 100)
        public sbyte Gear { get; set; }                     // Gear selected (1-8, N=0, R=-1)
        public ushort EngineRPM { get; set; }               // Engine RPM
        public byte DRS { get; set; }                      // 0 = off, 1 = on
        public byte RevLightsPercent { get; set; }         // Rev lights indicator (percentage)
        public ushort[] BrakesTemperature { get; set; } = new ushort[4];     // Brakes temperature (celsius)
        public ushort[] TyresSurfaceTemperature { get; set; } = new ushort[4];  // Tyres surface temperature (celsius)
        public ushort[] TyresInnerTemperature { get; set; } = new ushort[4];  // Tyres inner temperature (celsius)
        public ushort EngineTemperature { get; set; }       // Engine temperature (celsius)
        public float[] TyresPressure { get; set; } = new float[4];          // Tyres pressure (PSI)
        public byte[] SurfaceType { get; set; } = new byte[4];            // Driving surface, see appendices
    }
}
