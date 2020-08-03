﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Codemasters.Telemetry.Core
{
    public enum F1PacketType
    {
        Motion = 0,
        Session = 1,
        LapData = 2,
        Event = 3,
        Participants = 4,
        CarSetups = 5,
        CarTelemetry = 6,
        CarStatus = 7,
    }
}
