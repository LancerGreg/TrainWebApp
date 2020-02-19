using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Text;

namespace TrainWebApp.Domain.Models
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum FleetUnit
    {
        DeathStarI,
        DeathStarII,
        Golan_class_Space_Defense_Platform,
        Supporter_class_Super_Star_Destroyer,
        Eclipse_class_Star_Dreadnought,
        Executor_class_Super_Star_Destroyer,
        Sovereign_class_Dreadnought,
        Star_Super_Destroyer,
        Imperial_I_class_Star_Destroyer,
        Imperial_II_class_Star_Destroyer,
        Imperious_class_Star_Destroyer,
        Prohibiting_class_Star_Destroyer,
        Victory_I_class_Star_Destroyer,
        Victory_II_class_Star_Destroyer,
        Dreadnought_class_Heavy_Cruiser,
        Amplifier_class_Sentinel_Cruiser,
        Immobilizer_418_class_Cruiser,
        Glowing_class_Frigate,
        Frigate_DP20,
        Ulan_class_Frigate,
        Raider_class_Corvette,
        Skiprey_class_Shock_Ship_GAT_12,
        TIE_x1,
        TIE_ad_Star_Fighter,
        TIE_Defender,
        TIE_Interceptor,
        TIE_In,
        TIE_ph,
        TIE_sa_Bomber,
        Lambda_class_Shuttle_T_4a,
        Gamma_class_StormShuttle
    }
}
