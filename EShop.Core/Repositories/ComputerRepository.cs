using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EShop.Core.Models;
using EShop.Core.Mappers;

namespace EShop.Core.Repositories
{
    public class ComputerRepository
    {
        private static EShopDataContext db = new EShopDataContext();

        public static Computer GetById(int id)
        {
            var computer = db.Computers.FirstOrDefault(c => c.Id == id);
            return ComputerMap.createFrom(computer);
        }

        public static List<Computer> GetAll()
        {
            List<Computer> list = new List<Computer>();
            foreach (var computer in db.Computers)
            {
                list.Add(ComputerMap.createFrom(computer));
            }
            return list;
        }

        public static List<Computer> GetHotProducts()
        {
            List<Computer> list = new List<Computer>();
            foreach (var computer in db.Computers.Where( c=>c.IsHotProduct==true))
            {
                list.Add(ComputerMap.createFrom(computer));
            }
            return list;
        }

        public static List<Computer> GetFrontProduct()
        {
            List<Computer> list = new List<Computer>();
            foreach (var computer in db.Computers.Where(c => c.IsFrontProduct == true))
            {
                list.Add(ComputerMap.createFrom(computer));
            }
            return list;
        }
    }
}
