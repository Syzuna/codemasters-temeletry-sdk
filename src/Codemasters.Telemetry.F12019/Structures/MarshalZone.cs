
namespace Codemasters.Telemetry.F12019.Structures
{
    public class MarshalZone
    {
        public float ZoneStart { get; set; }   // Fraction (0..1) of way through the lap the marshal zone starts
        public byte ZoneFlag { get; set; }    // -1 = invalid/unknown, 0 = none, 1 = green, 2 = blue, 3 = yellow, 4 = red
    }
}
