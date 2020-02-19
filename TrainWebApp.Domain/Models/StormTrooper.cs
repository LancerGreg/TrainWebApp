using System.Runtime.Serialization;

namespace TrainWebApp.Domain.Models
{
    public class StormTrooper : Entity
    {
        [DataMember(Name = "name")] public string Name { get; set; }
        [DataMember(Name = "description")] public string Description { get; set; }
        [DataMember(Name = "type")] public StormTrooperUnit Type { get; set; }
        [IgnoreDataMember] public string MyDescription { get { return MyDescription; } set { MyDescription = "In films, comics, animated series, they are slanting bags of meat"; } }
    }
}
