using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UKRecipe.Shared.Entities.Abstract;

namespace UKRecipe.Entities.Concrete
{
    public class Nutrition : EntityBase, IEntity
    {
        public int Id { get; set; }
        public int Protein { get; set; }
        public int Fat { get; set; }
        public int Calories { get; set; }
        public int Sugar { get; set; }
        public int Carbohydrates { get; set; }
        public int Fiber { get; set; }
        public virtual ICollection<Recipe> Recipes { get; set; }
    }
}
