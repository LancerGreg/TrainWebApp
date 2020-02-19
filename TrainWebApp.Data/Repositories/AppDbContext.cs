using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TrainWebApp.Domain.Models;

namespace TrainWebApp.Data.Repositories
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        } 

        public DbSet<StormTrooper> StormTrooper { get; set; }
        public DbSet<Fleet> Fleet { get; set; }
        public DbSet<Vehicles> Vehicles { get; set; }
    }
}
