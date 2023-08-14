using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Config
{
    public class AttributeConfig : IEntityTypeConfiguration<Core.Entities.Attribute>
    {
        public void Configure(EntityTypeBuilder<Core.Entities.Attribute> builder)
        {
            builder.Property(v => v.Name).IsRequired().HasMaxLength(100);

            builder.HasOne(v => v.Category).WithMany()
                .HasForeignKey(v => v.CategoryId);
        }
    }
}
