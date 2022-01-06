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
    public class CategoryProfile : Profile
    {
        public CategoryProfile()
        {
            CreateMap<CategoryAddDto, Category>();

            CreateMap<CategoryUpdateDto, Category>();
                
            CreateMap<Category, CategoryUpdateDto>();
        }
    }
}
