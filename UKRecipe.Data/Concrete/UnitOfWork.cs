using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UKRecipe.Data.Abstract;
using UKRecipe.Data.Concrete.EntityFramework.Contexts;
using UKRecipe.Data.Concrete.EntityFramework.Repositories;

namespace UKRecipe.Data.Concrete
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly RecipeDbContext _context;
        
        private EfCategoryRepository _categoryRepository;
        private EfIngredientRepository _ingredientRepository;
        private EfMeasurementRepository _measurementRepository;
        private EfInstructionRepository _instructionRepository;
        private EfRecipeRepository _recipeRepository;
       
        private EfTagRepository _tagRepository;
        private EfUnitRepository _unitRepository;
        private EfSectionRepository _sectionRepository;
        private EfNutritionRepository _nutritionRepository;
        private EfComponentRepository _componentRepository;

        public UnitOfWork(RecipeDbContext context)
        {
            _context = context;
        }

        public ICategoryRepository Categories => _categoryRepository ?? new EfCategoryRepository(_context);

        public IIngredientRepository Ingredients => _ingredientRepository ?? new EfIngredientRepository(_context);

        public IMeasurementRepository Measurements => _measurementRepository ?? new EfMeasurementRepository(_context);

        public IRecipeRepository Recipes => _recipeRepository ?? new EfRecipeRepository(_context);

       

        public ITagRepository Tags => _tagRepository ?? new EfTagRepository(_context);

        public IComponentRepository Components =>_componentRepository ?? new EfComponentRepository(_context);


        public ISectionRepository Sections => _sectionRepository ?? new EfSectionRepository(_context);

        public IUnitRepository Units => _unitRepository ?? new EfUnitRepository(_context);

        public IInstructionRepository Instructions => _instructionRepository ?? new EfInstructionRepository(_context);

        public INutritionRepository Nutritions => _nutritionRepository ?? new EfNutritionRepository(_context);

        public async ValueTask DisposeAsync()
        {
            await _context.DisposeAsync();
        }

        public async Task<int> SaveAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
