using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace TrainWebApp.Domain.Models
{
    public class Fleet : Entity
    {
        [DataMember(Name = "name")] public string Name { get; set; }
        [DataMember(Name = "description")] public string Description { get; set; }
        [DataMember(Name = "type")] public FleetUnit Type { get; set; }
        [IgnoreDataMember] public string MyDescription { get { return MyDescription; } set { MyDescription = "There are a lot of them, very, but they all lost one to the resistance"; } }
    }
}
