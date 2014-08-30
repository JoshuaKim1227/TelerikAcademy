using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using Wintellect.PowerCollections;

// All access modifiers are set to public for test purposes
namespace CalendarSystem
{
    public class CalendarSystemMain
    {
        public static void Main()
        {
            EventsManager eventManager = new EventsManager();
            EventsProcessor eventProcessor = new EventsProcessor(eventManager);

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "End" || command == null)
                {
                    break;
                }

                Console.WriteLine(eventProcessor.ProcessCommand(Command.Parse(command)));
            }
        }
    }

    public class Command
    {
        public string commandName { get; set; }

        public string[] commandArguments { get; set; }

        public static Command Parse(string cmdForParsing)
        {
            int indexBetweenCommands = cmdForParsing.IndexOf(' ');

            if (indexBetweenCommands == -1)
            {
                throw new Exception("Invalid command: " + cmdForParsing);
            }

            string name = cmdForParsing.Substring(0, indexBetweenCommands);
            string argument = cmdForParsing.Substring(indexBetweenCommands + 1);

            string[] commandArguments = argument.Split('|');

            for (int argCount = 0; argCount < commandArguments.Length; argCount++)
            {
                argument = commandArguments[argCount];
                commandArguments[argCount] = argument.Trim();
            }

            Command command = new Command { commandName = name, commandArguments = commandArguments };

            return command;
        }
    }

    public class EventsManager : IEventsManager
    {
        private readonly MultiDictionary<string, CalendarSystem.Event> eventsByTitle = new MultiDictionary<string, CalendarSystem.Event>(true);
        private readonly OrderedMultiDictionary<DateTime, Event> eventsByDate = new OrderedMultiDictionary<DateTime, Event>(true);

        public void AddEvent(Event calendarEvent)
        {
            string eventTitleLowerCase = calendarEvent.Title.ToLowerInvariant();

            this.eventsByTitle.Add(eventTitleLowerCase, calendarEvent);
            this.eventsByDate.Add(calendarEvent.EventDate, calendarEvent);
        }

        public int DeleteEventsByTitle(string title)
        {
            string titleLowercase = title.ToLowerInvariant();
            ICollection<Event> entriesForDeleting = this.eventsByTitle[titleLowercase];
            int eventsForDeleting = entriesForDeleting.Count;

            foreach (var entry in entriesForDeleting)
            {
                this.eventsByDate.Remove(entry.EventDate, entry);
            }

            this.eventsByTitle.Remove(titleLowercase);

            return eventsForDeleting;
        }

        public IEnumerable<Event> ListEvents(DateTime eventDate, int numberOfEventsForListing)
        {
            IEnumerable<Event> eventsList =
                from calendarEvent in this.eventsByDate.RangeFrom(eventDate, true).Values
                select calendarEvent;

            IEnumerable<Event> finalEventsList = eventsList.Take(numberOfEventsForListing);

            return finalEventsList;
        }
    }

    public interface IEventsManager
    {
        void AddEvent(Event calendarEvent);

        int DeleteEventsByTitle(string eventTitle);

        IEnumerable<Event> ListEvents(DateTime eventDate, int numberOfItemsToList);
    }

    public class Event : IComparable<Event>
    {
        public DateTime EventDate { get; set; }

        public string Title { get; set; }

        public string Location { get; set; }

        public override string ToString()
        {
            string format = "{0:yyyy-MM-ddTH:mm:ss} | {1}";

            if (this.Location != null)
            {
                format += " | {2}";
            }

            string eventAsString = string.Format(format, this.EventDate, this.Title, this.Location);

            return eventAsString;
        }

        public int CompareTo(Event otherEvent)
        {
            int result = DateTime.Compare(this.EventDate, otherEvent.EventDate);

            foreach (char symbol in this.Title)
            {
                if (result == 0)
                {
                    result = string.Compare(this.Title, otherEvent.Title, StringComparison.Ordinal);
                }

                if (result == 0)
                {
                    result = string.Compare(this.Location, otherEvent.Location, StringComparison.Ordinal);
                }
            }

            return result;
        }
    }

    public class EventsProcessor
    {
        private readonly IEventsManager eventsManager;

        public EventsProcessor(IEventsManager eventsManager)
        {
            this.eventsManager = eventsManager;
        }

        public IEventsManager EventsManager
        {
            get
            {
                return this.eventsManager;
            }
        }

        public string ProcessCommand(Command cmd)
        {
            if (cmd.commandName == "AddEvent" && cmd.commandArguments.Length == 2)
            {
                DateTime date = DateTime.ParseExact(cmd.commandArguments[0], "yyyy-MM-ddTHH:mm:ss", CultureInfo.InvariantCulture);

                Event calendarEvent = new Event
                            {
                                EventDate = date,
                                Title = cmd.commandArguments[1],
                                Location = null,
                            };

                this.eventsManager.AddEvent(calendarEvent);

                return "Event added";
            }

            if (cmd.commandName == "AddEvent" && cmd.commandArguments.Length == 3)
            {
                var date = DateTime.ParseExact(cmd.commandArguments[0], "yyyy-MM-ddTHH:mm:ss", CultureInfo.InvariantCulture);

                var e = new Event
                            {
                                EventDate = date,
                                Title = cmd.commandArguments[1],
                                Location = cmd.commandArguments[2],
                            };

                this.eventsManager.AddEvent(e);

                return "Event added";
            }

            if (cmd.commandName == "DeleteEvents" && cmd.commandArguments.Length == 1)
            {
                int numberOfDeletedEvents = this.eventsManager.DeleteEventsByTitle(cmd.commandArguments[0]);

                if (numberOfDeletedEvents == 0)
                {
                    return "No events found";
                }

                return numberOfDeletedEvents + " events deleted";
            }

            if (cmd.commandName == "ListEvents" && cmd.commandArguments.Length == 2)
            {
                DateTime eventDate = DateTime.ParseExact(cmd.commandArguments[0], "yyyy-MM-ddTHH:mm:ss", CultureInfo.InvariantCulture);
                int numberOfEventsForListing = int.Parse(cmd.commandArguments[1]);

                IEnumerable<Event> eventsList = this.eventsManager.ListEvents(eventDate, numberOfEventsForListing).ToList();

                StringBuilder builder = new StringBuilder();

                if (!eventsList.Any())
                {
                    return "No events found";
                }

                foreach (var calendarEvent in eventsList)
                {
                    builder.AppendLine(calendarEvent.ToString());
                }

                return builder.ToString().Trim();
            }

            throw new ArgumentException("Invalid command.", "cmd.commandName");
        }
    }
}