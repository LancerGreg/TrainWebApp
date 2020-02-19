using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrainWebApp.Domain.Models;
using TrainWebApp.Domain.Repositories;

namespace TrainWebApp.API.Controllers
{
    [Produces("application/json")]
    [Route("api/unit")]
    public class UnitInformationController
    {
        private readonly IStormTrooperRepo _stormTrooperRepo;
        private readonly IFleetRepo _fleetRepo;
        private readonly IVehiclesRepo _vehiclesRepo;

        public UnitInformationController(
            IStormTrooperRepo stormTrooperRepo,
            IFleetRepo fleetRepo,
            IVehiclesRepo vehiclesRepo)
        {
            _stormTrooperRepo = stormTrooperRepo;
            _fleetRepo = fleetRepo;
            _vehiclesRepo = vehiclesRepo;
        }

        /// <summary>
        /// Get all list of the StormTrooper
        /// </summary>
        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<StormTrooper>), 200)]
        [ProducesResponseType(400)]
        [Route("storm_troopers")]
        public async Task<IActionResult> GetStormTroopers() =>
            new OkObjectResult(await _stormTrooperRepo.GetUnits());

        /// <summary>
        /// Get StormTrooper by name
        /// </summary>
        [HttpGet]
        [ProducesResponseType(typeof(StormTrooper), 200)]
        [ProducesResponseType(400)]
        [Route("storm_trooper/{name}")]
        public async Task<IActionResult> GetStormTrooperOfName(string name) =>
            new OkObjectResult(await _stormTrooperRepo.GetUnitOfName(name));

        /// <summary>
        /// Get StormTrooper by type
        /// </summary>
        [HttpGet]
        [ProducesResponseType(typeof(StormTrooper), 200)]
        [ProducesResponseType(400)]
        [Route("storm_trooper/{type}")]
        public async Task<IActionResult> GetStormTrooperOfType(string type) =>
            new OkObjectResult(await _stormTrooperRepo.GetUnitOfType(type));

        /// <summary>
        /// Get all list of the StormTrooper
        /// </summary>
        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<Fleet>), 200)]
        [ProducesResponseType(400)]
        [Route("fleet")]
        public async Task<IActionResult> GetFleet() =>
            new OkObjectResult(await _fleetRepo.GetUnits());

        /// <summary>
        /// Get StormTrooper by name
        /// </summary>
        [HttpGet]
        [ProducesResponseType(typeof(Fleet), 200)]
        [ProducesResponseType(400)]
        [Route("fleet/{name}")]
        public async Task<IActionResult> GetFleetOfName(string name) =>
            new OkObjectResult(await _fleetRepo.GetUnitOfName(name));

        /// <summary>
        /// Get StormTrooper by type
        /// </summary>
        [HttpGet]
        [ProducesResponseType(typeof(Fleet), 200)]
        [ProducesResponseType(400)]
        [Route("fleet/{type}")]
        public async Task<IActionResult> GetFleetOfType(string type) =>
            new OkObjectResult(await _fleetRepo.GetUnitOfType(type));

        /// <summary>
        /// Get all list of the StormTrooper
        /// </summary>
        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<Vehicles>), 200)]
        [ProducesResponseType(400)]
        [Route("vehicles")]
        public async Task<IActionResult> GetVehicles() =>
            new OkObjectResult(await _vehiclesRepo.GetUnits());

        /// <summary>
        /// Get StormTrooper by name
        /// </summary>
        [HttpGet]
        [ProducesResponseType(typeof(Vehicles), 200)]
        [ProducesResponseType(400)]
        [Route("vehicles/{name}")]
        public async Task<IActionResult> GetVehiclesOfName(string name) =>
            new OkObjectResult(await _vehiclesRepo.GetUnitOfName(name));

        /// <summary>
        /// Get StormTrooper by type
        /// </summary>
        [HttpGet]
        [ProducesResponseType(typeof(Vehicles), 200)]
        [ProducesResponseType(400)]
        [Route("vehicles/{type}")]
        public async Task<IActionResult> GetVehiclesOfType(string type) =>
            new OkObjectResult(await _vehiclesRepo.GetUnitOfType(type));
    }
}
