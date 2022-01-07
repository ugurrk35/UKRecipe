using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UKRecipe.Shared.Entities.Abstract;

namespace UKRecipe.Entities.Concrete
{
    public class Instruction : EntityBase, IEntity
    {
        public int Id { get; set; }
        public string display_text { get; set; }
        public int position { get; set; }

        public int RecipeId { get; set; }
        public virtual Recipe Recipes { get; set; }
    }
}
