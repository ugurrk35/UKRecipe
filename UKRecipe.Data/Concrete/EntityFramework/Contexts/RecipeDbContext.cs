using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using UKRecipe.Data.Concrete.EntityFramework.Mappings;
using UKRecipe.Entities.Concrete;

namespace UKRecipe.Data.Concrete.EntityFramework.Contexts
{
    public class RecipeDbContext:DbContext
    {

        public DbSet<Category> Categories { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Measurement> Measurements { get; set; }
        public DbSet<Instruction> Instructions { get; set; }
        public DbSet<Recipe> Recipes { get; set; }
    
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Component> Components { get; set; }
        public DbSet<Nutrition> Nutritions { get; set; }
        public DbSet<Section> Sections { get; set; }
        public DbSet<Unit> Units { get; set; }
      


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-8I58UG8\\SQLEXPRESS; database = Recipee; Trusted_Connection= true");
            optionsBuilder.UseLazyLoadingProxies();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
       

    }
}
