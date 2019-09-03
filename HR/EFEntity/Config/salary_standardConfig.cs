using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFEntity.Config
{
   public class salary_standardConfig : EntityTypeConfiguration<salary_standard>
    {
        public salary_standardConfig()
        {
            this.ToTable(nameof(salary_standard));

            //this.Property(e => e.attribute_kind).HasMaxLength(60);
            //this.Property(e => e.attribute_name).HasMaxLength(60);
        }
    }
}
