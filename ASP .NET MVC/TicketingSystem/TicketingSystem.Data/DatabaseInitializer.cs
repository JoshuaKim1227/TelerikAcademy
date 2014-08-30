using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Data.Entity.Validation;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketingSystem.Models;

namespace TicketingSystem.Data
{
    public class DatabaseInitializer : DbMigrationsConfiguration<TicketingSystemDbContext>
    {
        public DatabaseInitializer()
        {
            this.AutomaticMigrationsEnabled = true;
            this.AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(TicketingSystemDbContext context)
        {
            if (context.Tickets.Count() > 0)
            {
                return;
            }

            Random rand = new Random();

            ApplicationUser user = new ApplicationUser() { UserName = "Test" };
            Category category = new Category() { Name = "Bugs" };

            for (int i = 0; i < 12; i++)
            {
                var descriptionLength = rand.Next(1, 5);
                string description = string.Empty;

                for (int j = 0; j < descriptionLength; j++)
                {
                    description += "Description ";
                }

                Ticket ticket = new Ticket();
                var commentsCount = rand.Next(1, 20);

                for (int j = 0; j < commentsCount; j++)
                {
                    ticket.Comments.Add(new Comment() { Author = "Ivan", Content = "This is the comment's content" });
                }


                ticket.Title = "Sample Ticket " + (i + 1);
                ticket.Author = user;
                ticket.Category = category;

                ticket.Description = description;
                ticket.ScreenshotURL = "http://i1-win.softpedia-static.com/screenshots/JumpBox-for-the-Mantis-Bug-Tracking-System_2.png";

                context.Tickets.Add(ticket);
            }

            context.SaveChanges();

            base.Seed(context);
        }
    }
}
