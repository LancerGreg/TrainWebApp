using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using TrainWebApp.Core;
using TrainWebApp.Domain.Models;
using TrainWebApp.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace TrainWebApp.Data.Repositories
{
    public class StormTrooperRepo : IStormTrooperRepo
    {
        private readonly AppDbContext _appDbContext;

        public StormTrooperRepo(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<IEnumerable<StormTrooper>> GetUnits() =>
           await _appDbContext.StormTrooper.ToListAsync();

        public async Task<IOption<StormTrooper>> GetUnitOfName(string Name) =>
           (await _appDbContext.StormTrooper.SingleOrDefaultAsync(st => st.Id == Name)).AsOption();

        public async Task<IOption<StormTrooper>> GetUnitOfType(string Type) =>
           (await _appDbContext.StormTrooper.SingleOrDefaultAsync(st => st.Type.ToString() == Type)).AsOption();
    }
}
