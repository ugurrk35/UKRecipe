using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UKRecipe.Shared.Entities.Abstract;

namespace UKRecipe.Entities.Concrete
{
    public class Section : EntityBase, IEntity
    {
        public int Id { get; set; }
        
        public int Position { get; set; }
        public virtual ICollection<Component> Components { get; set; }
    }
}
