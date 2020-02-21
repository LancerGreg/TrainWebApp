using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TrainWebApp.Core;
using TrainWebApp.Domain.Models;
using TrainWebApp.Domain.Repositories;

namespace TrainWebApp.Data.Repositories
{
    public class VehiclesRepo : IVehiclesRepo
    {
        private readonly AppDbContext _appDbContext;

        public VehiclesRepo(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<IEnumerable<Vehicles>> GetUnits() =>
           await _appDbContext.Vehicles.ToListAsync();

        public async Task<IOption<Vehicles>> GetUnitOfName(string Name) =>
           (await _appDbContext.Vehicles.SingleOrDefaultAsync(st => st.Name == Name)).AsOption();

        public async Task<IOption<Vehicles>> GetUnitOfType(string Type) =>
           (await _appDbContext.Vehicles.SingleOrDefaultAsync(st => st.Type.ToString() == Type)).AsOption();
    }
}
