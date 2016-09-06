using CodeFirstRelations.Models.DB.Mdl;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace CodeFirstRelations.Models.DB.Ctx
{
    public class UserDBContext : DbContext
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
        public DbSet<UserAuth> UserAuth { get; set; }
        public DbSet<UserMsg> UserMsg { get; set; }
    }
}