using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace TrainWebApp.Domain.Models
{
    public class Vehicles : Entity
    {
        [DataMember(Name = "name")] public string Name { get; set; }
        [DataMember(Name = "description")] public string Description { get; set; }
        [DataMember(Name = "type")] public VehiclesUnit Type { get; set; }
        [IgnoreDataMember] public string MyDescription { get { return MyDescription; } set { MyDescription = "In a word walking and shoot blasters canned food"; } }
    }
}
