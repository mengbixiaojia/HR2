using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
namespace EFEntity.Config
{
    public class RoleConfig : EntityTypeConfiguration<Role>
    {
        public RoleConfig()
        {
            this.ToTable(nameof(Role));//映射表名
            this.Property(e => e.RoleName).HasMaxLength(50);
            this.Property(e => e.RoleExplain).HasMaxLength(50);
            this.Property(e => e.IsOK).HasMaxLength(50);
        }
    }
}
