using Codemasters.Telemetry.F12019.Structures;

namespace Codemasters.Telemetry.F12019.Packets
{
    /// <summary>
    /// Frequency: Rate as specified in menus
    /// Size: 1343 bytes
    /// Version: 1
    /// https://forums.codemasters.com/topic/44592-f1-2019-udp-specification/
    /// </summary>
    public class MotionData
    {
        public PacketHeader Header { get; set; } = new PacketHeader();                  // Header
        public CarMotion[] CarMotion { get; set; } = new CarMotion[20];      // Data for all cars on track

        // Extra player car ONLY data
        public float[] SuspensionPosition { get; set; } = new float[4];       // Note: All wheel arrays have the following order:
        public float[] SuspensionVelocity { get; set; } = new float[4];      // RL, RR, FL, FR
        public float[] SuspensionAcceleration { get; set; } = new float[4];  // RL, RR, FL, FR
        public float[] WheelSpeed { get; set; } = new float[4];             // Speed of each wheel
        public float[] WheelSlip { get; set; } = new float[4];               // Slip ratio for each wheel
        public float LocalVelocityX { get; set; }             // Velocity in local space
        public float LocalVelocityY { get; set; }             // Velocity in local space
        public float LocalVelocityZ { get; set; }             // Velocity in local space
        public float AngularVelocityX { get; set; }       // Angular velocity x-component
        public float AngularVelocityY { get; set; }            // Angular velocity y-component
        public float AngularVelocityZ { get; set; }            // Angular velocity z-component
        public float AngularAccelerationX { get; set; }        // Angular velocity x-component
        public float AngularAccelerationY { get; set; }   // Angular velocity y-component
        public float AngularAccelerationZ { get; set; }        // Angular velocity z-component
        public float FrontWheelsAngle { get; set; }            // Current front wheels angle in radians
    }
}
