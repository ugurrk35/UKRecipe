using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UKRecipe.Shared.Entities.Abstract;

namespace UKRecipe.Entities.Concrete
{
    public class Recipe : EntityBase, IEntity
    {
        public int Id { get; set; }
        public int CookTimesMinutes { get; set; }
        public int NutritionId { get; set; }
        public virtual Nutrition Nutrition { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Instruction> Instructions { get; set; }
        public virtual ICollection<Section> Sections { get; set; }
        public virtual ICollection<Tag> Tags { get; set; }
        public int TotalTimesMinutes { get; set; }
     
        public string Description { get; set; }
        public string ThumbnailUrl { get; set; }
        public string Yields { get; set; }
        public int PrepTimesMinutes { get; set; }
        public int CategoryId { get; set; }   
        public virtual Category Category { get; set; }
    }
}
