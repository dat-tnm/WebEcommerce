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
    public class ProductVariationConfig : IEntityTypeConfiguration<ProductVariation>
    {
        public void Configure(EntityTypeBuilder<ProductVariation> builder)
        {
            builder.Property(pv => pv.Name).IsRequired().HasMaxLength(100);
            builder.Property(pv => pv.DiscountPrice).HasColumnType("decimal(18,2)");
            builder.Property(pv => pv.Price).HasColumnType("decimal(18,2)");
            builder.Property(pv => pv.QtyInStock).HasColumnType("decimal(18,2)");
            builder.Property(pv => pv.ImageUrl).IsRequired();

            builder.HasOne(pv => pv.Product).WithMany()
                .HasForeignKey(pv => pv.ProductId);
        }
    }
}
