using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TrainWebApp.Core;
using TrainWebApp.Domain.Models;

namespace TrainWebApp.Domain.Repositories
{
    public interface IVehiclesRepo
    {
        Task<IEnumerable<Vehicles>> GetUnits();
        Task<IOption<Vehicles>> GetUnitOfName(string Name);
        Task<IOption<Vehicles>> GetUnitOfType(string Type);
    }
}
