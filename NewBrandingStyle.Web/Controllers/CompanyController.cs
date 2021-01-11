using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NewBrandingStyle.Web.Models;


namespace NewBrandingStyle.Web.Controllers
{
    public class CompanyController : Controller
    {

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(CompanyItemModel item)
        {
            // TODO add to database

            var viewModel = new CompanyAddedViewModel
            {
                Id = 1,
                Name = item.Name,
            };

            //return View("AddConfirmation", viewModel);

            return RedirectToAction("AddConfirmation");
        }

        [HttpGet]
        public IActionResult AddConfirmation()
        {
            return View();
        }
    }
}
