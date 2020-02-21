using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Moq;
using NUnit.Framework;
using TrainWebApp.API.Controllers;
using TrainWebApp.Core;
using TrainWebApp.Core.ExceptionError;
using TrainWebApp.Data.Services;
using TrainWebApp.Domain.Models;
using TrainWebApp.Domain.Repositories;
using TrainWebApp.Domain.Services;

namespace TrainWebApp.Test.DetachmentSelect
{
    [TestFixture]
    public class DetachmentSelectStormTrooperTest
    {
        private Mock<IDetachmentSelectStormTrooperService> _detachmentSelectStormTrooper = new Mock<IDetachmentSelectStormTrooperService>();
        private Mock<IStormTrooperRepo> _stormTrooperRepo = new Mock<IStormTrooperRepo>();
        [Test]
        public async void GetStormTrooperSquad_ReturnsAViewResult()
        {
            // Arrange
            IEnumerable<(int Id, int Count)> ListSquad = new List<(int Id, int Count)>()
                {
                    (1, 2),
                    (5, 3),
                    (6, 1),
                    (7, 2),
                    (10, 1),
                    (11, 2)
                };

            _stormTrooperRepo.Setup(repo => repo.GetUnits())
                .Returns(GetMockOkStormTroopers());
            var expected = await GetStormTrooperSquad();
            var service = new DetachmentSelectStormTrooperService(_stormTrooperRepo.Object);

            // Act
            var result = await service.GetStormTrooperSquad(ListSquad);

            // Assert
            Assert.NotNull(result);

            Assert.AreEqual(result, expected);
        }

        private Task<IEnumerable<StormTrooper>> GetStormTrooperSquad()
        {
            IEnumerable<StormTrooper> stq = new List<StormTrooper>
            {
                new StormTrooper() { Id = 1, Name = "StormTrooper", Description = "EmpireТs main strike force in the galaxy. The equipment consisted of E-11 blaster rifles and specialized composite armor, which consisted of 18 plastoid plates.", Type = StormTrooperUnit.StormTrooper },
                new StormTrooper() { Id = 1, Name = "StormTrooper", Description = "EmpireТs main strike force in the galaxy. The equipment consisted of E-11 blaster rifles and specialized composite armor, which consisted of 18 plastoid plates.", Type = StormTrooperUnit.StormTrooper },
                new StormTrooper() { Id = 5, Name = "ImperialStrike StormTrooper", Description = "High-class stormtroopers, recruited from the Corps elite and used mainly as support fighters and personal protection of the Emperor.", Type = StormTrooperUnit.ImperialStrike_StormTrooper },
                new StormTrooper() { Id = 5, Name = "ImperialStrike StormTrooper", Description = "High-class stormtroopers, recruited from the Corps elite and used mainly as support fighters and personal protection of the Emperor.", Type = StormTrooperUnit.ImperialStrike_StormTrooper },
                new StormTrooper() { Id = 5, Name = "ImperialStrike StormTrooper", Description = "High-class stormtroopers, recruited from the Corps elite and used mainly as support fighters and personal protection of the Emperor.", Type = StormTrooperUnit.ImperialStrike_StormTrooper },
                new StormTrooper() { Id = 6, Name = "Space StormTrooper", Description = "Specialized stormtroopers equipped for operation in open space.", Type = StormTrooperUnit.Space_StormTrooper },
                new StormTrooper() { Id = 7, Name = "CoastDefense StormTrooper", Description = "Specialized stormtroopers equipped for combat in tropical conditions.", Type = StormTrooperUnit.CoastDefense_StormTrooper },
                new StormTrooper() { Id = 7, Name = "CoastDefense StormTrooper", Description = "Specialized stormtroopers equipped for combat in tropical conditions.", Type = StormTrooperUnit.CoastDefense_StormTrooper },
                new StormTrooper() { Id = 10, Name = "Frontier StormTrooper", Description = "Are a special type of stormtrooper, one of the most severe and experienced fighters in the Imperial Army.", Type = StormTrooperUnit.Frontier_StormTrooper },
                new StormTrooper() { Id = 11, Name = "Forest StormTrooper", Description = "Stormtroopers with impressive camouflage skills and trained combat tactics among dense forests.", Type = StormTrooperUnit.Forest_StormTrooper },
                new StormTrooper() { Id = 11, Name = "Forest StormTrooper", Description = "Stormtroopers with impressive camouflage skills and trained combat tactics among dense forests.", Type = StormTrooperUnit.Forest_StormTrooper },
            };

            return Task.FromResult(stq);
        }

        private Task<IEnumerable<StormTrooper>> GetMockOkStormTroopers()
        {
            IEnumerable<StormTrooper> stq = new List<StormTrooper>
            {
                new StormTrooper() { Id = 1, Name = "StormTrooper", Description = "EmpireТs main strike force in the galaxy. The equipment consisted of E-11 blaster rifles and specialized composite armor, which consisted of 18 plastoid plates.", Type = StormTrooperUnit.StormTrooper },
                new StormTrooper() { Id = 2, Name = "Snow StormTroopers", Description = "The more famous imperial snow stormtroopers - fighters prepared for warfare in the Arctic", Type = StormTrooperUnit.Snow_StormTroopers },
                new StormTrooper() { Id = 3, Name = "FlameThrowers StormTrooper", Description = "Are soldiers of the Empire, armed with flamethrowers and used to combat the enemy that has strengthened its position.", Type = StormTrooperUnit.FlameThrowers_StormTrooper },
                new StormTrooper() { Id = 4, Name = "Underwater StormTrooper", Description = "Empire soldiers trained and equipped to conduct combat operations in the aquatic environment.", Type = StormTrooperUnit.Underwater_StormTrooper },
                new StormTrooper() { Id = 5, Name = "ImperialStrike StormTrooper", Description = "High-class stormtroopers, recruited from the Corps elite and used mainly as support fighters and personal protection of the Emperor.", Type = StormTrooperUnit.ImperialStrike_StormTrooper },
                new StormTrooper() { Id = 6, Name = "Space StormTrooper", Description = "Specialized stormtroopers equipped for operation in open space.", Type = StormTrooperUnit.Space_StormTrooper },
                new StormTrooper() { Id = 7, Name = "CoastDefense StormTrooper", Description = "Specialized stormtroopers equipped for combat in tropical conditions.", Type = StormTrooperUnit.CoastDefense_StormTrooper },
                new StormTrooper() { Id = 8, Name = "Grenadier StormTrooper", Description = "Specialized stormtroopers armed with grenade launchers.", Type = StormTrooperUnit.Grenadier_StormTrooper },
                new StormTrooper() { Id = 9, Name = "Patrol StormTrooper", Description = "A unit of stormtrooper, ranked as self-defense forces of many planets in order to maintain imperial power there.", Type = StormTrooperUnit.Patrol_StormTrooper },
                new StormTrooper() { Id = 10, Name = "Frontier StormTrooper", Description = "Are a special type of stormtrooper, one of the most severe and experienced fighters in the Imperial Army.", Type = StormTrooperUnit.Frontier_StormTrooper },
                new StormTrooper() { Id = 11, Name = "Forest StormTrooper", Description = "Stormtroopers with impressive camouflage skills and trained combat tactics among dense forests.", Type = StormTrooperUnit.Forest_StormTrooper },
                new StormTrooper() { Id = 12, Name = "Mimban StormTrooper", Description = "Stormtroopers equipped for long-term operations amid constant rains and slush.", Type = StormTrooperUnit.Mimban_StormTrooper },
            };

            return Task.FromResult(stq);
        }
    }
}
