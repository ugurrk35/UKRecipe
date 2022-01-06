using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UKRecipe.Entities.Concrete;

namespace UKRecipe.Data.Concrete.EntityFramework.Mappings
{
    public class RecipeMap : IEntityTypeConfiguration<Recipe>
    {
        public void Configure(EntityTypeBuilder<Recipe> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).ValueGeneratedOnAdd();
            builder.Property(c => c.Name).IsRequired();
            builder.Property(c => c.Name).HasMaxLength(70);
            builder.Property(c => c.Description).IsRequired();
            builder.Property(c => c.Description).HasMaxLength(200);
            builder.HasOne<Category>(a => a.Category).WithMany(c => c.Recipes).HasForeignKey(a => a.CategoryId);
            builder.HasOne<Nutrition>(a => a.Nutrition).WithMany(c => c.Recipes).HasForeignKey(a => a.NutritionId);
            builder.ToTable("Recipes");
            
            
                
        }
    }
}
