using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NewBrandingStyle.Web.Database;

namespace NewBrandingStyle.Web.ViewComponents
{
    public class LatestItem : ViewComponent
    {
        private readonly ExchangesDbContext _dbContext;
        public IViewComponentResult Invoke()
        {
            var latestItem = _dbContext.Items.OrderByDescending(x => x.Id).First();
            return View("Index", latestItem);
        }

        public LatestItem(ExchangesDbContext dBContext)
        {
            _dbContext = dBContext;
        }
    }
}
