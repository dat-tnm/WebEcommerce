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
    public class JTProductAttributeConfig : IEntityTypeConfiguration<JTProductAttribute>
    {
        public void Configure(EntityTypeBuilder<JTProductAttribute> builder)
        {
            builder.Property(jt => jt.Value).IsRequired().HasMaxLength(100);

            builder.HasKey(jt => new { jt.ProductVariationId, jt.AttributeId });
            builder.HasOne(jt => jt.ProductVariation).WithMany()
                .HasForeignKey(jt => jt.ProductVariationId);
            builder.HasOne(jt => jt.Attribute).WithMany()
                .HasForeignKey(jt => jt.AttributeId);
        }
    }
}
