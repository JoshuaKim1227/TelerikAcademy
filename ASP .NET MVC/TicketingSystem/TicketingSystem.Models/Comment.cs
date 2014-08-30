using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketingSystem.Models
{
    public class Comment
    {
        public int Id { get; set; }

        public string Author { get; set; }

        public virtual Ticket Ticket { get; set; }

        [Required]
        public string Content { get; set; }
    }
}
