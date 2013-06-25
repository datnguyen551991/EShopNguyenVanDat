using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Core.Mappers
{
    public class CompanyMap
    {
        public static EShop.Core.Models.Company CreateFrom(EShop.Core.DAL.Company company,
            List<EShop.Core.Models.Category> categories)
        {
            return new EShop.Core.Models.Company
            {
                Id = company.Id,
                Name = company.Name,
                Description = company.Description,
                Categories = categories
            };
        }
    }
}
