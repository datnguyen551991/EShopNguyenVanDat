using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EShop.Web.Models;
using EShop.Core.Repositories;

namespace Eshop.Web.Controllers
{
    public class ProductController : BaseController
    {
        //
        // GET: /Product/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ProductDetail(int id)
        {
            ProductPageViewModel model = new ProductPageViewModel
            {
                product = ComputerRepository.GetById(id)
            };
            return View(model);
        }

    }
}
