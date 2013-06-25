using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Core.Mappers
{
    public class ComputerMap
    {

        public static EShop.Core.Models.Computer createFrom(EShop.Core.DAL.Computer computer){
            return new EShop.Core.Models.Computer
            {
                Id = computer.Id,
                Name = computer.Name,
                ImageURL = computer.ImageURL,
                Price = computer.Price,
                Description = computer.Description,
                CompCatId = computer.CompCatId,
                IsFrontProduct = computer.IsFrontProduct,
                IsHotProduct = computer.IsHotProduct
            };
        }
    }
}
