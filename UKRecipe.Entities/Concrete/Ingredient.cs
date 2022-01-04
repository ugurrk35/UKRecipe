﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UKRecipe.Shared.Entities.Abstract;

namespace UKRecipe.Entities.Concrete
{
    public class Ingredient : EntityBase, IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string DisplaySingular { get; set; }
        public string DisplayPlural { get; set; }
        public ICollection<Component> Components { get; set; }
    }
}
