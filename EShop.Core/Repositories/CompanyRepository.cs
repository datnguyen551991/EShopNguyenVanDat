using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EShop.Core.Models;
using EShop.Core.Mappers;

namespace EShop.Core.Repositories
{
    public class CompanyRepository
    {

        private static EShopDataContext db = new EShopDataContext();

        public static Company GetById(int id)
        {
            var company = db.Companies.FirstOrDefault(c => c.Id == id);
            List<Category> categories = new List<Category>();
            foreach (var item in company.CompCats)
            {
                categories.Add(CategoryMap.CreateFrom(item.Category));
            }
            return CompanyMap.CreateFrom(company,categories);
        }

        public static List<Company> GetAll()
        {
            List<Company> list = new List<Company>();
            foreach (var company in db.Companies)
            {
                List<Category> categories = new List<Category>();
                foreach (var item in company.CompCats)
                {
                    categories.Add(CategoryMap.CreateFrom(item.Category));
                }
                list.Add(CompanyMap.CreateFrom(company, categories));
            }
            return list;
        }
    }
}
