using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EShop.Core.Models;
using EShop.Core.Mappers;

namespace EShop.Core.Repositories
{
    class CategoryRepository
    {

        private static EShopDataContext db = new EShopDataContext();

        public static Category GetById(int id)
        {
            var category = db.Categories.FirstOrDefault(c => c.Id == id);
            return CategoryMap.CreateFrom(category);
        }

        public static List<Category> GetAll()
        {
            List<Category> list = new List<Category>();
            foreach (var category in db.Categories)
            {
                list.Add(CategoryMap.CreateFrom(category));
            }
            return list;
        }
    }
}
