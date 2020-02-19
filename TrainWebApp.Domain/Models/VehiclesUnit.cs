using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Text;

namespace TrainWebApp.Domain.Models
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum VehiclesUnit
    {
        AT_AT,
        Elite_AT_AT,
        AT_ACT,
        AT_DP,
        AT_DT,
        AT_ST,
        Anti_Gravity_2_M_tank,
        Speedbike_74_Z,
        Gravicycle_614_AvA,
        C_PH_Patrol_Speeder,
        StormTank,
        Imperial_Combat_Speeder,
        ITT,
        StormTank_TX_225_GAVr,
        Turbo_Tank_HCVw_A9,
        TX_225_GAVw_Invader
    }
}
