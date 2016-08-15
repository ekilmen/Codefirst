using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using CodefirstIlkDers.Models.DB.Mdl;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace CodefirstIlkDers.Models.DB.Ctx
{
    public class UserDBContext:DbContext
    {
        public UserDBContext()
        {
            Database.Connection.ConnectionString = "Data Source=.;Initial Catalog=UserDB;Integrated Security=True";
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public DbSet<User> UserList { get; set; }
    }
}