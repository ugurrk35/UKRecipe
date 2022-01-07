using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UKRecipe.Entities.Dtos;
using UKRecipe.Shared.Utilities.Results.Abstract;

namespace UKRecipe.Services.Abstract
{
    public interface ISectionService
    {
        Task<IDataResult<SectionDto>> GetAsync(int sectionId);
    }
}
