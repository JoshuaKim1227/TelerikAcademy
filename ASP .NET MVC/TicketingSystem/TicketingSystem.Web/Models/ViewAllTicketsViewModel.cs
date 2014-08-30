using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TicketingSystem.Web.Models
{
    public class ViewAllTicketsViewModel
    {
        public string Title { get; set; }

        [Display(Name = "Category")]
        public string CategoryName { get; set; }
        public string AuthorName { get; set; }
        public string Priority { get; set; }
    }
}