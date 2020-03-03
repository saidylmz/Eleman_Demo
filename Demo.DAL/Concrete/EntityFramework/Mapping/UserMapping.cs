using Demo.MODEL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.DAL.Concrete.EntityFramework.Mapping
{
    public class UserMapping : EntityTypeConfiguration<User>
    {
        public UserMapping()
        {
            Property(x => x.Email).HasMaxLength(64).IsRequired();
            Property(x => x.Name).HasMaxLength(128).IsRequired();
            Property(x => x.Password).HasMaxLength(32).IsRequired();
            HasIndex(x => x.Name).IsUnique();
            Property(x => x.Logo).HasMaxLength(128).IsOptional();
        }
    }
}
