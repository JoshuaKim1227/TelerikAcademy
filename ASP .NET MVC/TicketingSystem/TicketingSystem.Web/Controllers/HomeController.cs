using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TicketingSystem.Web.Models;

namespace TicketingSystem.Web.Controllers
{
    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
            if (this.HttpContext.Cache["ListOfTickets"] == null)
            {
                var viewModel = this.Data.Tickets.All()
                    .OrderByDescending(x => x.Comments.Count())
                    .Take(6)
                    .Select(x => new HomeTicketsViewModel()
                    {
                        Id = x.Id,
                        Title = x.Title,
                        CategoryName = x.Category.Name,
                        AuthorName = x.Author.UserName,
                        CommentsCount = x.Comments.Count(),
                    });

                // TODO: Change the caching time to 1 hour
                this.HttpContext.Cache.Add("ListOfTickets", viewModel.ToList(), null, DateTime.Now.AddSeconds(1), TimeSpan.Zero, System.Web.Caching.CacheItemPriority.Default, null);
            }

            return View(this.HttpContext.Cache["ListOfTickets"]);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}