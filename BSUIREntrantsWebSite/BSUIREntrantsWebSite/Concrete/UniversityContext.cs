using BSUIREntrantsWebSite.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace BSUIREntrantsWebSite.Concrete
{
    public class UniversityContext : DbContext
    {
        public UniversityContext() : base("EntrantsDataBase")
        {
        }
        public DbSet<Enrollee> Entranst { get; set; }
        public DbSet<UniversityData> Data { get; set; }
        public DbSet<UniversityNode> Nodes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingEntitySetNameConvention>();
        }
    }
}