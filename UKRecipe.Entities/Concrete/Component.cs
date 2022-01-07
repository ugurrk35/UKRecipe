using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UKRecipe.Shared.Entities.Abstract;

namespace UKRecipe.Entities.Concrete
{
    public class Component : EntityBase, IEntity
    {
        public int Id { get; set; }
        public string RawText { get; set; }
        public int Position { get; set; }
        public virtual ICollection<Measurement> Measurements { get; set; }
        public int IngredientId { get; set; }
        public virtual Ingredient Ingredient { get; set; }
    }
}
