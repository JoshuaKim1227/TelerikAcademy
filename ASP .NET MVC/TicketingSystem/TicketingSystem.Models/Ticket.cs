using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TicketingSystem.Models
{
    public class Ticket
    {
        private string priority;
        private ICollection<Comment> comments;

        public Ticket()
        {
            this.Priority = "medium";
            comments = new List<Comment>();
        }

        public int Id { get; set; }

        public virtual ApplicationUser Author { get; set; }

        public virtual Category Category { get; set; }

        [Required]
        [ShouldNotContainBug]
        public string Title { get; set; }

        [Required]
        public string Priority
        {
            get
            {
                return this.priority;
            }
            set
            {
                if (value == "low" || value == "medium" || value == "high")
                {
                    this.priority = value;
                }
                else
                {
                    this.priority = "medium";
                }
            }
        }

        public string ScreenshotURL { get; set; }

        [ShouldNotContainHTML]
        public string Description { get; set; }

        public virtual ICollection<Comment> Comments
        {
            get { return this.comments; }
            set { this.comments = value; }
        }
    }
}
