using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UKRecipe.Data.Abstract;
using UKRecipe.Entities.Concrete;
using UKRecipe.Entities.Dtos;
using UKRecipe.Services.Abstract;
using UKRecipe.Services.Utilities;
using UKRecipe.Shared.Utilities.Results.Abstract;
using UKRecipe.Shared.Utilities.Results.ComplexTypes;
using UKRecipe.Shared.Utilities.Results.Concrete;

namespace UKRecipe.Services.Concrete
{
    public class RecipeManager : IRecipeService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public RecipeManager(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<IResult> AddAsync(RecipeAddDto recipeAddDto)
        {
            var recipess=_mapper.Map<Recipe>(recipeAddDto);
            await _unitOfWork.Recipes.AddAsync(recipess);
            await _unitOfWork.SaveAsync();
            return new Result(ResultStatus.Success, $"{recipeAddDto.Name} adlı tarif başarıyla eklenmiştir.");
        }

        public async Task<IDataResult<RecipeDto>> GetAsync(int recipeId)
        {
            var recipe = await _unitOfWork.Recipes.GetAsync(c => c.Id == recipeId,c=>c.Instructions,c=>c.Sections,c=>c.Nutrition,c=>c.Tags);
            if (recipe != null)
            {
                return new DataResult<RecipeDto>(ResultStatus.Success, new RecipeDto
                {
                    Recipe = recipe,
                    
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<RecipeDto>(ResultStatus.Error, Messages.Category.NotFound(isPlural: false), new RecipeDto
            {
                Recipe = null,
                ResultStatus = ResultStatus.Error,
                Message = Messages.Category.NotFound(isPlural: false)
            });
        }

       
    }
}
