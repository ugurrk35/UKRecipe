using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UKRecipe.Data.Abstract;
using UKRecipe.Data.Concrete;
using UKRecipe.Data.Concrete.EntityFramework.Contexts;
using UKRecipe.Services.Abstract;
using UKRecipe.Services.Concrete;

namespace UKRecipe.Services.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection LoadMyServices(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddDbContext<RecipeDbContext>();
           
            serviceCollection.AddScoped<IUnitOfWork, UnitOfWork>();
            serviceCollection.AddScoped<ICategoryService, CategoryManager>();
            serviceCollection.AddScoped<IRecipeService, RecipeManager>();
            serviceCollection.AddScoped<ISectionService, SectionManager>();
            return serviceCollection;
        }

    }
}
