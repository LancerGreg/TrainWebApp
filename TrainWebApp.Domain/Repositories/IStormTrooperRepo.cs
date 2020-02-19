using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TrainWebApp.Core;
using TrainWebApp.Domain.Models;

namespace TrainWebApp.Domain.Repositories
{
    public interface IStormTrooperRepo
    {
        Task<IEnumerable<StormTrooper>> GetUnits();
        Task<IOption<StormTrooper>> GetUnitOfName(string Name);
        Task<IOption<StormTrooper>> GetUnitOfType(string Type);
    }
}
