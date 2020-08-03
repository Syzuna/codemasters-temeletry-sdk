using System;
using System.Collections.Generic;
using System.Text;

namespace Codemasters.Telemetry.Core
{
    public enum F1EventCode
    {
        SSTA, // Session Started “SSTA” Sent when the session starts
        SEND, // Session Ended “SEND” Sent when the session ends
        FTLP, // Fastest Lap “FTLP” When a driver achieves the fastest lap
        RTMT, // Retirement “RTMT” When a driver retires
        DRSE, // DRS enabled “DRSE” Race control have enabled DRS
        DRSD, // DRS disabled “DRSD” Race control have disabled DRS
        TMPT, // Team mate in pits “TMPT” Your team mate has entered the pits
        CHQF, // Chequered flag “CHQF” The chequered flag has been waved
        RCWN // Race Winner “RCWN” The race winner is announced
    }
}
