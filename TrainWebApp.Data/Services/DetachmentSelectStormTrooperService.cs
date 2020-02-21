using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using TrainWebApp.Core;
using TrainWebApp.Domain.Models;
using TrainWebApp.Domain.Repositories;
using TrainWebApp.Domain.Services;
using TrainWebApp.Core.ExceptionError;

namespace TrainWebApp.Data.Services
{
    public class DetachmentSelectStormTrooperService : IDetachmentSelectStormTrooperService
    {
        private readonly IStormTrooperRepo _stormTrooperRepo;

        public DetachmentSelectStormTrooperService(IStormTrooperRepo stormTrooperRepo)
        {
            _stormTrooperRepo = stormTrooperRepo;
        }

        public async Task<ITry<IEnumerable<StormTrooper>>> GetStormTrooperSquad(IEnumerable<(int Id, int Count)> ListSquad)
        {
            if (ListSquad == null || ListSquad.Count() == 0)
                return await Task.FromResult(
                    new Failure<IEnumerable<StormTrooper>>(new EmptyList()));

            var stormTrooperSquad = new List<StormTrooper>();
            (await _stormTrooperRepo.GetUnits()).ToList().ForEach(unit => ListSquad.ToList().ForEach(s =>
                {
                    if (s.Id == unit.Id)
                    {
                        for (int i = 0; i < s.Count; i++)
                        {
                            stormTrooperSquad.Add(unit);
                        }
                    }
                }));

            return Try.Enclose(() => stormTrooperSquad);
        }
    }
}
