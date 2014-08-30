using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketingSystem.Models
{
    public class Category
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        // TODO: Set Collection propery's field and initialization. I don't know why.
        public ICollection<Ticket> Tickets { get; set; }
    }
}
