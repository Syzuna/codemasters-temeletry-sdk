using System;
using System.Collections.Generic;
using System.Text;

namespace Codemasters.Telemetry.F12019.Structures
{
    public class Participant
    {
        public byte AiControlled { get; set; }          // Whether the vehicle is AI (1) or Human (0) controlled
        public byte DriverId { get; set; }      // Driver id - see appendix
        public byte TeamId { get; set; }                // Team id - see appendix
        public byte RaceNumber { get; set; }            // Race number of the car
        public byte Nationality { get; set; }           // Nationality of the driver
        public string Name { get; set; } = string.Empty;    // Name of participant in UTF-8 format – null terminated [48 bytes long
                                          // Will be truncated with … (U+2026) if too long
        public byte YourTelemetry { get; set; }         // The player's UDP setting, 0 = restricted, 1 = public
    }
}
