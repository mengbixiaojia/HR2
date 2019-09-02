using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFEntity.Config
{
    class engage_interviewConfig: EntityTypeConfiguration<engage_interview>
    {
        public engage_interviewConfig()
        {
            ToTable(nameof(engage_interview));
        }
    }
}
