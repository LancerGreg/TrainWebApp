using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrainWebApp.Domain.Services;

namespace TrainWebApp.API.Controllers
{
    [Produces("application/json")]
    [Route("api/detachment")]
    public class DetachmentController
    {
        private readonly IDetachmentSelectStormTrooperService _detachmentSelectStormTrooper;

        public DetachmentController(IDetachmentSelectStormTrooperService detachmentSelectStormTrooper)
        {
            _detachmentSelectStormTrooper = detachmentSelectStormTrooper;
        }

        /// <summary>
        /// The test about working 
        /// </summary>        
        [ProducesResponseType(typeof(string), 200)]
        [ProducesResponseType(500)]
        [HttpGet("storm_trooper_squad")]
        public async Task<IActionResult> GetStormTrooperSquad(IEnumerable<(int Id, int Count)> ListSquad) =>
            await (await _detachmentSelectStormTrooper.GetStormTrooperSquad(ListSquad))
                .MatchAsync<IActionResult>(
                    async o => {
                        return await Task.FromResult(new OkObjectResult(o));
                    },
                    async ex => {
                        return await Task.FromResult(new BadRequestObjectResult(ex.GetType().Name));
                    });
    }
}
