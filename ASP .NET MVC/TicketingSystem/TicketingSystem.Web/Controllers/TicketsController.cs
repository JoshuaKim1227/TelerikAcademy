using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TicketingSystem.Models;
using TicketingSystem.Web.Models;
using Microsoft.AspNet.Identity;

namespace TicketingSystem.Web.Controllers
{
    public class TicketsController : BaseController
    {
        public ActionResult Details(int id)
        {
            var ticket = this.Data.Tickets.All()
                .Where(x => x.Id == id)
                .Select(x => new DetailsTicketViewModel()
                {
                    Title = x.Title,
                    Description = x.Description,
                    Priority = x.Priority,
                    AuthorName = x.Author.UserName,
                    ScreenshotURL = x.ScreenshotURL,
                    CategoryName = x.Category.Name,
                    Comments = x.Comments,
                }).FirstOrDefault();

            return View(ticket);
        }

        // TODO: Change the name of the parameter
        public ActionResult ViewAll(string sortCriteria, int id = 1)
        {
            var pageSize = 5;

            // TODO: Improve it
            var numberOfPages = Math.Ceiling((decimal)this.Data.Tickets.All().Count() / pageSize);

            ViewBag.NumberOfPages = numberOfPages;

            // TODO: Make possible to choose order
            //var orderedTickets = this.OrderTicketsBy(sortCriteria);

            var listOfTickets = this.Data.Tickets.All()
                .OrderBy(x => x.Title)
                .Skip(pageSize * (id - 1))
                .Take(pageSize)
                .Select(x => new ViewAllTicketsViewModel()
                { 
                    Title = x.Title,
                    AuthorName = x.Author.UserName, 
                    CategoryName = x.Category.Name, 
                    Priority = x.Priority,
                });

            return View(listOfTickets);
        }

        [HttpGet]
        public ActionResult AddTicket()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddTicket(Ticket ticket)
        {
            if (ModelState.IsValid)
            {
                this.Data.Tickets.Add(ticket);
                this.Data.SaveChanges();
                ticket.Author.Points++;
            }

            return RedirectToAction("Index", "Home");
        }

        [ValidateAntiForgeryToken]
        public ActionResult PostComment(SubmitCommentViewModel commentModel)
        {
            if (ModelState.IsValid)
            {
                var username = this.User.Identity.GetUserName();
                var userId = this.User.Identity.GetUserId();
            }

            return null;
        }

        private IOrderedQueryable<Ticket> OrderTicketsBy(string sortCriteria)
        {
            var allTickets = this.Data.Tickets.All();

            switch (sortCriteria)
	        {
                case "Title":
                    return allTickets.OrderBy(x => x.Title);
                case "Category":
                    return allTickets.OrderBy(x => x.Category);
                case "Author":
                    return allTickets.OrderBy(x => x.Author);
                case "Priority":
                    return allTickets.OrderBy(x => x.Priority);
		        default:
                    return allTickets.OrderBy(x => x.Title);
	        }
        }
	}
}