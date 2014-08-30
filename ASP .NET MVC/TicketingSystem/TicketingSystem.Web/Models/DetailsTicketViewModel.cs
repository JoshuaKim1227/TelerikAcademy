using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using TicketingSystem.Models;

namespace TicketingSystem.Web.Models
{
    public class DetailsTicketViewModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Priority { get; set; }
        public string AuthorName { get; set; }

        [Display(Name = "Screenshot URL")]
        public string ScreenshotURL { get; set; }

        [Display(Name="Category")]
        public string CategoryName { get; set; }
        public ICollection<Comment> Comments { get; set; }
    }
}