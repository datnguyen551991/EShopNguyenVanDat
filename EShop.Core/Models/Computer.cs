using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Core.Models
{
    public class Computer
    {
        public int Id { set; get; }
        public string Name{set;get;}
        public string ImageURL { set; get; }
        public decimal Price { set; get; }
        public string Description { set; get; }
        public bool IsHotProduct { set; get; }
        public bool IsFrontProduct { set; get; }
        public int CompCatId { set; get; }
    }
}
