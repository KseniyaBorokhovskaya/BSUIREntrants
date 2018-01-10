using BSUIREntrantsWebSite.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace BSUIREntrantsWebSite.Concrete
{
    public class UniversitiesTreeContext : DbContext
    {
        public UniversitiesTreeContext() : base("UniversityTreeDataBase")
        {
        }
        public DbSet<UniversityNode> UniversityNodes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingEntitySetNameConvention>();
        }
    }
}