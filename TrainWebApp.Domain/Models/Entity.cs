using System.Runtime.Serialization;

namespace TrainWebApp.Domain.Models
{
    [DataContract]
    public abstract class Entity
    {
        [DataMember(Name = "id")] public string Id { get; set; }
    }
}
