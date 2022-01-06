using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UKRecipe.Data.Abstract;
using UKRecipe.Entities.Concrete;
using UKRecipe.Shared.Data.Concrete.EntityFramework;

namespace UKRecipe.Data.Concrete.EntityFramework.Repositories
{
    public class EfTagRepository : EfEntityRepositoryBase<Tag>, ITagRepository
    {
        public EfTagRepository(DbContext context) : base(context)
        {

        }
    }
}
