using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UKRecipe.Shared.Entities.Abstract;

namespace UKRecipe.Entities.Concrete
{
    public class Measurement : EntityBase, IEntity
    {
        public int Id { get; set; }

       
        public string Quantity { get; set; }
        public int UnitId { get; set; }
        public Unit Units { get; set; }

    }
}
