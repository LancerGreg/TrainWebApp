using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Text;

namespace TrainWebApp.Domain.Models
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum StormTrooperUnit
    {
        StormTrooper,
        Snow_StormTroopers,
        FlameThrowers_StormTrooper,
        Underwater_StormTrooper,
        ImperialStrike_StormTrooper,
        Space_StormTrooper,
        CoastDefense_StormTrooper,
        Grenadier_StormTrooper,
        Patrol_StormTrooper,
        Frontier_StormTrooper,
        Forest_StormTrooper,
        Mimban_StormTrooper,
        Heavy_StormTrooper,
        Flying_StormTrooper,
        Lava_StormTrooper,
        Sand_StormTrooper,
        ScoutTrooper,
        Sniper_StormTrooper,
        Shadow_StormTrooper,
        Commandos_StormTrooper,
        Death_StormTrooper,
        Hunter_StormTrooper
    }
}
