using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Reflection;

namespace EFEntity
{
    public class MyDBContext:DbContext
    {

        public MyDBContext() :  base("name=sql")
        {
            Database.SetInitializer<MyDBContext>(null);
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.AddFromAssembly(Assembly.GetExecutingAssembly());
        }
        public DbSet<config_file_first_kind> first_kind { get; set; }
        public DbSet<config_major_kind> major_kind { get; set; }
        public DbSet<config_major> config_major { get; set; }
        public DbSet<users> users { get; set; }
        public DbSet<config_public_char> public_char { get; set; }
    }
}
