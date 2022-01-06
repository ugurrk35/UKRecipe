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
    public class ComponentMap : IEntityTypeConfiguration<Component>
    {
        public void Configure(EntityTypeBuilder<Component> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).ValueGeneratedOnAdd();
            builder.Property(c => c.RawText).IsRequired();
            builder.Property(c => c.RawText).HasMaxLength(200);
            builder.Property(c => c.Position).IsRequired();
            builder.HasOne<Ingredient>(a => a.Ingredient).WithMany(c => c.Components).HasForeignKey(a => a.IngredientId);
            builder.ToTable("Components");



        }
    }
}
