using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    public class StoreContextSeed
    {
        public static async Task SeedAsync(StoreContext context)
        {
            if (!context.Categories.Any())
            {
                var categoriesData = File.ReadAllText("../Infrastructure/Data/SeedData/categories.json");
                var categories = JsonSerializer.Deserialize<List<Category>>(categoriesData);
                if (categories != null)
                    context.Categories.AddRange(categories);

                await context.SaveChangesAsync();
            }


            if (!context.Products.Any())
            {
                var productsData = File.ReadAllText("../Infrastructure/Data/SeedData/products.json");
                var products = JsonSerializer.Deserialize<List<Product>>(productsData);
                if (products != null)
                    context.Products.AddRange(products);

                await context.SaveChangesAsync();
            }

            if (!context.ProductVariations.Any())
            {
                var productVariationsData = File.ReadAllText("../Infrastructure/Data/SeedData/productVariations.json");
                var productVariations = JsonSerializer.Deserialize<List<ProductVariation>>(productVariationsData);
                if(productVariations != null)
                    context.ProductVariations.AddRange(productVariations);

                await context.SaveChangesAsync();
            }

            if (!context.Attributes.Any())
            {
                var attributesData = File.ReadAllText("../Infrastructure/Data/SeedData/attributes.json");
                var attributes = JsonSerializer.Deserialize<List<Core.Entities.Attribute>>(attributesData);
                if (attributes != null)
                    context.Attributes.AddRange(attributes);

                await context.SaveChangesAsync();
            }

            if (!context.JTProductAttributes.Any())
            {
                var jtProductAttributesData = File.ReadAllText("../Infrastructure/Data/SeedData/jtProductAttributes.json");
                var jtProductAttributes = JsonSerializer.Deserialize<List<JTProductAttribute>>(jtProductAttributesData);
                if (jtProductAttributes != null)
                    context.JTProductAttributes.AddRange(jtProductAttributes);

                await context.SaveChangesAsync();
            }

            //if (context.ChangeTracker.HasChanges()) await context.SaveChangesAsync();
        }
    }
}
