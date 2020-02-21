using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TrainWebApp.Core;
using TrainWebApp.Domain.Models;

namespace TrainWebApp.Domain.Services
{
    public interface IDetachmentSelectStormTrooperService
    {
        Task<ITry<IEnumerable<StormTrooper>>> GetStormTrooperSquad(IEnumerable<(int Id, int Count)> ListSquad);
    }
}
