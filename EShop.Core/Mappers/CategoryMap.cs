using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Core.Mappers
{
    public class CategoryMap
    {
        public static EShop.Core.Models.Category CreateFrom(EShop.Core.DAL.Category category)
        {
            return new EShop.Core.Models.Category { Id = category.Id, 
                Name = category.Name, 
                Description = category.Description };
        }
    }
}
