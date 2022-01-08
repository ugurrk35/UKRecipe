using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UKRecipe.Entities.Concrete;
using UKRecipe.Entities.Dtos;

namespace UKRecipe.Services.AutoMapper.Profiles
{
    public class RecipeProfile:Profile
    {
        public RecipeProfile()
        {
            CreateMap<RecipeAddDto, Recipe>();
            CreateMap<Recipe, RecipeAddDto>();

        }
    }
}
