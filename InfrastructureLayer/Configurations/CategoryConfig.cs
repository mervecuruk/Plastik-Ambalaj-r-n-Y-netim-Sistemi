using DomainLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace InfrastructureLayer.Configurations
{
    public class CategoryConfig : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {

            builder.HasData(
            new Category { CategoryId = 1, CategoryName = "Food Packaging", IsActive = true },
            new Category { CategoryId = 2, CategoryName = "Beverage Packaging", IsActive = true },
            new Category { CategoryId = 3, CategoryName = "Cosmetic Packaging", IsActive = true },
            new Category { CategoryId = 4, CategoryName = "Medical Packaging", IsActive = true },
            new Category { CategoryId = 5, CategoryName = "Pharmaceutical Packaging", IsActive = true },
            new Category { CategoryId = 6, CategoryName = "Flexible Packaging", IsActive = true },
            new Category { CategoryId = 7, CategoryName = "Rigid Packaging", IsActive = true },
            new Category { CategoryId = 8, CategoryName = "Plastic Bags", IsActive = true },
            new Category { CategoryId = 9, CategoryName = "Shrink Wrap", IsActive = true },
            new Category { CategoryId = 10, CategoryName = "Blister Packaging", IsActive = true },
            new Category { CategoryId = 11, CategoryName = "Thermoformed Packaging", IsActive = true },
            new Category { CategoryId = 12, CategoryName = "Vacuum Packaging", IsActive = true },
            new Category { CategoryId = 13, CategoryName = "Stretch Film", IsActive = true },
            new Category { CategoryId = 14, CategoryName = "Plastic Bottles", IsActive = true },
            new Category { CategoryId = 15, CategoryName = "Plastic Containers", IsActive = true },
            new Category { CategoryId = 16, CategoryName = "Plastic Caps and Closures", IsActive = true },
            new Category { CategoryId = 17, CategoryName = "Disposable Utensils", IsActive = true },
            new Category { CategoryId = 18, CategoryName = "Clamshell Packaging", IsActive = true },
            new Category { CategoryId = 19, CategoryName = "Film Packaging", IsActive = true },
            new Category { CategoryId = 20, CategoryName = "Injection Molded Packaging", IsActive = true },
            new Category { CategoryId = 21, CategoryName = "PET Bottles", IsActive = true },
            new Category { CategoryId = 22, CategoryName = "HDPE Containers", IsActive = true },
            new Category { CategoryId = 23, CategoryName = "LDPE Bags", IsActive = true },
            new Category { CategoryId = 24, CategoryName = "Polypropylene Packaging", IsActive = true },
            new Category { CategoryId = 25, CategoryName = "Polystyrene Packaging", IsActive = true },
            new Category { CategoryId = 26, CategoryName = "Polyvinyl Chloride (PVC) Packaging", IsActive = true },
            new Category { CategoryId = 27, CategoryName = "Biodegradable Packaging", IsActive = true },
            new Category { CategoryId = 28, CategoryName = "Compostable Packaging", IsActive = true },
            new Category { CategoryId = 29, CategoryName = "E-commerce Packaging", IsActive = true },
            new Category { CategoryId = 30, CategoryName = "Industrial Packaging", IsActive = true }
        );
        }
    }
}
