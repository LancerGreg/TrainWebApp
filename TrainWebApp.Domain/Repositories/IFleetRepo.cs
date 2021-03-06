﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TrainWebApp.Core;
using TrainWebApp.Domain.Models;

namespace TrainWebApp.Domain.Repositories
{
    public interface IFleetRepo
    {
        Task<IEnumerable<Fleet>> GetUnits();
        Task<IOption<Fleet>> GetUnitOfName(string Name);
        Task<IOption<Fleet>> GetUnitOfType(string Type);
    }
}
