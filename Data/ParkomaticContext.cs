#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using UnitTesting_Lab2_MoqFramework.Models;

namespace UnitTesting_Lab2_MoqFramework.Data
{
    public class ParkomaticContext : DbContext
    {
        public ParkomaticContext()
        {
        }
        public ParkomaticContext (DbContextOptions<ParkomaticContext> options)
            : base(options)
        {
        }

        //the mock data/methods shoudld be virtual!!!
        public virtual DbSet<Vehicle> Vehicle { get; set; }
        public virtual DbSet<Pass> Passes { get; set; }
        public virtual DbSet<ParkingSpot> ParkingSpot { get; set; }
        public virtual DbSet<Reservation> Reservation { get; set; }
    }
}
