using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFEntity.Config
{
  public  class salary_standard_detailsConfig : EntityTypeConfiguration<salary_standard_details>
    {
        public salary_standard_detailsConfig()
        {
            this.ToTable(nameof(salary_standard_details));
            //this.Property(e => e.attribute_kind).HasMaxLength(60);
            //this.Property(e => e.attribute_name).HasMaxLength(60);
        }
    }
}
