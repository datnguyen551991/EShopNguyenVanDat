using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Core.Models
{
    public class Company
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public string Description { set; get; }
        public List<Category> Categories { set; get; }
    }
}
