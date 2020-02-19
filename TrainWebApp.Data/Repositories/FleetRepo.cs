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
    public class FleetRepo : IFleetRepo
    {
        private readonly AppDbContext _appDbContext;

        public FleetRepo(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<IEnumerable<Fleet>> GetUnits() =>
           await _appDbContext.Fleet.ToListAsync();

        public async Task<IOption<Fleet>> GetUnitOfName(string Name) =>
           (await _appDbContext.Fleet.SingleOrDefaultAsync(st => st.Id == Name)).AsOption();

        public async Task<IOption<Fleet>> GetUnitOfType(string Type) =>
           (await _appDbContext.Fleet.SingleOrDefaultAsync(st => st.Type.ToString() == Type)).AsOption();
    }
}
