using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UKRecipe.Entities.Concrete;
using UKRecipe.Shared.Data.Abstract;

namespace UKRecipe.Data.Abstract
{
    public interface INutritionRepository: IEntityRepository<Nutrition>
    {

    }
}
