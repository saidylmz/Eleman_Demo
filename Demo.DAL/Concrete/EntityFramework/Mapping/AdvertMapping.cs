using Demo.MODEL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.DAL.Concrete.EntityFramework.Mapping
{
    public class AdvertMapping : EntityTypeConfiguration<Advert>
    {
        public AdvertMapping()
        {
            Property(x => x.Name).HasMaxLength(128).IsRequired();
            Property(x => x.Description).HasColumnName("text");
            Property(x => x.PhoneList).IsOptional().HasColumnType("text");
        }
    }
}
