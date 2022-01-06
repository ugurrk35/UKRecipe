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
    public class InstructionMap : IEntityTypeConfiguration<Instruction>
    {
        public void Configure(EntityTypeBuilder<Instruction> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).ValueGeneratedOnAdd();
            builder.Property(c => c.display_text).IsRequired();
            builder.Property(c => c.display_text).HasMaxLength(150);
            builder.HasOne<Recipe>(a => a.Recipes).WithMany(c => c.Instructions).HasForeignKey(a => a.RecipeId);
            builder.ToTable("Instructions");



        }
    }
}
