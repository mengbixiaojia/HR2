using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFEntity.Config
{
    public class human_fileConfig : EntityTypeConfiguration<human_file>
    {
        public human_fileConfig()
        {
            this.ToTable(nameof(human_file));

        }
    }
}
