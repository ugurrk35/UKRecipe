using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UKRecipe.Data.Abstract
{
    public interface IUnitOfWork : IAsyncDisposable
    {
        ICategoryRepository Categories { get; }
        IIngredientRepository Ingredients { get; }
        IMeasurementRepository Measurements { get; }
        IRecipeRepository Recipes { get; }
      
        ITagRepository Tags { get; }
        IComponentRepository Components { get; }
        IInstructionRepository Instructions { get; }
        INutritionRepository Nutritions { get; }
        ISectionRepository Sections { get; }
        IUnitRepository Units { get; }
        Task<int> SaveAsync();

    }
}
