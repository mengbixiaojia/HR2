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
        
        public DbSet<config_file_third_kind> config_file_third_kind { get; set; }
        public DbSet<config_public_char> config_public_char { get; set; }
        public DbSet<config_file_first_kind> config_file_first_kind { get; set; }
        public DbSet<config_file_second_kind> config_file_second_kind { get; set; }
    }
}
