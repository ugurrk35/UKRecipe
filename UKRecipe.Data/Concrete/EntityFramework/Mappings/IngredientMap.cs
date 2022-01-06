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
    public class IngredientMap : IEntityTypeConfiguration<Ingredient>
    {
        public void Configure(EntityTypeBuilder<Ingredient> builder)
        {
            builder.HasKey(a => a.Id);
            builder.Property(a => a.Id).ValueGeneratedOnAdd();
            builder.Property(c => c.Name).IsRequired();
            builder.Property(c => c.Name).HasMaxLength(40);
            builder.Property(c => c.DisplayPlural).IsRequired();
            builder.Property(c => c.DisplayPlural).HasMaxLength(40);
            builder.Property(c => c.DisplaySingular).IsRequired();
            builder.Property(c => c.DisplaySingular).HasMaxLength(40);

            builder.ToTable("Ingredients");

        }
    }
}
