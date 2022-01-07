using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UKRecipe.Data.Abstract;
using UKRecipe.Entities.Dtos;
using UKRecipe.Services.Abstract;
using UKRecipe.Services.Utilities;
using UKRecipe.Shared.Utilities.Results.Abstract;
using UKRecipe.Shared.Utilities.Results.ComplexTypes;
using UKRecipe.Shared.Utilities.Results.Concrete;

namespace UKRecipe.Services.Concrete
{
    public class SectionManager : ISectionService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public SectionManager(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<IDataResult<SectionDto>> GetAsync(int sectionId)
        {
            var section = await _unitOfWork.Sections.GetAsync(c => c.Id == sectionId,c=>c.Components);
            if (section != null)
            {
                return new DataResult<SectionDto>(ResultStatus.Success, new SectionDto
                {
                    Section = section,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<SectionDto>(ResultStatus.Error, Messages.Section.NotFound(isPlural: false), new SectionDto
            {
                Section = null,
                ResultStatus = ResultStatus.Error,
                Message = Messages.Category.NotFound(isPlural: false)
            });
        }
    }
}
