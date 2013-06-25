using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EShop.Core.Repositories;
using EShop.Web.Models;

namespace Eshop.Web.Controllers
{
    public abstract class BaseController : Controller
    {
        //
        // GET: /Base/

        public BaseController()
        {
            LayoutPageViewModel model = new LayoutPageViewModel
            {
                companies = CompanyRepository.GetAll()
            };
            ViewData["LayoutPageViewModel"] = model;
        }
    }
}
