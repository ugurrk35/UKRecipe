using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UKRecipe.Shared.Entities.Abstract;

namespace UKRecipe.Entities.Concrete
{
    public class Step : EntityBase, IEntity
    {
        public int Id { get; set; }

        public string DisplayText{ get; set; }

        public int Position { get; set; }
    }
}
