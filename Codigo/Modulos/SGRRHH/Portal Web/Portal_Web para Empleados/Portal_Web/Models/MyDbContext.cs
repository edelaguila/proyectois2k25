using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using MySql.Data.EntityFramework;
using Portal_Web.Models; 


namespace Portal_Web.Models
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]

    public class MyDbContext : DbContext
    {
        public MyDbContext() : base("MySqlConnection") { }

        public DbSet<Users> Usuarios { get; set; }
        public DbSet<Rol> Roles { get; set; }
    }
}