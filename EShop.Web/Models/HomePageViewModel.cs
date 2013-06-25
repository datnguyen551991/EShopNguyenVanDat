using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EShop.Core.Models;

namespace EShop.Web.Models
{
    public class HomePageViewModel
    {
        public List<Computer> hotProducts { set; get; }
        public List<Computer> frontProducts { set; get; }
    }
}