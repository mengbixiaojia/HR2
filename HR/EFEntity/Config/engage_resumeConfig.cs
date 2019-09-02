using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFEntity.Config
{
    class engage_resumeConfig : EntityTypeConfiguration<engage_resume>
    {
        public engage_resumeConfig()
        {
            this.ToTable(nameof(engage_resume));
        }
    }
}
