using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UKRecipe.Entities.Concrete;
using UKRecipe.Shared.Entities.Abstract;

namespace UKRecipe.Entities.Dtos
{
    public class SectionDto : DtoGetBase
    {
        public Section Section { get; set; }
    }
}
