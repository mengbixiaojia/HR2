using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;

namespace EFEntity.Config
{
   public class major_changeConfig : EntityTypeConfiguration<major_change>
    {
        public major_changeConfig()
        {
            this.ToTable(nameof(major_change));//映射表名

        }
    }
}
