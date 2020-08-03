using System;
using System.Collections.Generic;
using System.Text;

namespace Codemasters.Telemetry.F12019.Helpers
{
    public static class SurfaceHelper
    {
        public static string GetSurfaceById(int id)
        {
            switch (id)
            {
                case 0: return "Tarmac";
                case 1: return "Rumble strip";
                case 2: return "Concrete";
                case 3: return "Rock";
                case 4: return "Gravel";
                case 5: return "Mud";
                case 6: return "Sand";
                case 7: return "Grass";
                case 8: return "Water";
                case 9: return "Cobblestone";
                case 10: return "Metal";
                case 11: return "Ridged";
                default:
                    break;
            }
            return "";
        }
    }
}
