using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UKRecipe.Shared.Entities.Abstract;

namespace UKRecipe.Entities.Concrete
{
    public class Unit : EntityBase, IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Abbreviation { get; set; }
        public string DisplaySingular { get; set; }
        public string DisplayPlural { get; set; }
        public ICollection<Measurement> Measurements { get; set; }
    }
}
