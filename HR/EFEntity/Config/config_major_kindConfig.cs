using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;

namespace EFEntity.Config
{
   public class config_major_kindConfig:EntityTypeConfiguration<config_major_kind>
    {
        public config_major_kindConfig()
        {
            this.ToTable(nameof(config_major_kind));
            this.Property(e => e.major_kind_id).HasMaxLength(2);
            this.Property(e => e.major_kind_name).HasMaxLength(60);
        }
    }
}
