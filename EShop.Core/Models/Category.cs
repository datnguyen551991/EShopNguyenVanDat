using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Core.Models
{
    public class Category
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public string Description { set; get; }
        public List<Company> Companies { set; get; }
    }
}
