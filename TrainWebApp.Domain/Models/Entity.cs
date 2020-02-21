using System.Runtime.Serialization;

namespace TrainWebApp.Domain.Models
{
    [DataContract]
    public abstract class Entity
    {
        [DataMember(Name = "id")] public int Id { get; set; }
    }
}
