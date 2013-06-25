using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EShop.Core.Repositories;
using EShop.Web.Models;

namespace Eshop.Web.Controllers
{
    public class HomeController :BaseController
    {
        //
        // GET: /Home/
        public ActionResult Index()
        {
            HomePageViewModel model = new HomePageViewModel
            {
                hotProducts = ComputerRepository.GetHotProducts(),
                frontProducts = ComputerRepository.GetFrontProduct()
            };
            return View(model);
        }

    }
}
