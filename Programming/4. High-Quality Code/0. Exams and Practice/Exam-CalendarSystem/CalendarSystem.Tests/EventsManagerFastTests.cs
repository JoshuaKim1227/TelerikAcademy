using System;
using System.Globalization;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace CalendarSystem.Tests
{
    [TestClass]
    public class EventsManagerTests
    {
        [TestMethod]
        public void TestAddEvent()
        {
            EventsManager eventManager = new EventsManager();
            EventsProcessor eventProcessor = new EventsProcessor(eventManager);

            DateTime date = DateTime.ParseExact("2012-03-26T09:00:00", "yyyy-MM-ddTHH:mm:ss", CultureInfo.InvariantCulture);

            Event calendarEvent = new Event
            {
                EventDate = date,
                Title = "C# exam",
                Location = null
            };

            EventsManager eventsManager = new EventsManager();

            eventsManager.AddEvent(calendarEvent);

            string expectedTitle = "C# exam";
            string expectedLocation = null;

            IEnumerable<Event> eventsList = eventsManager.ListEvents(date, 1);
            Event testEvent = new Event();

            foreach (Event ev in eventsList)
            {
                testEvent = ev;
            }

            Assert.AreEqual(date, testEvent.EventDate);
            Assert.AreEqual(expectedTitle, testEvent.Title);
            Assert.AreEqual(expectedLocation, testEvent.Location);
        }

        [TestMethod]
        public void TestDeleteEventsByTitle()
        {
            EventsManager eventManager = new EventsManager();
            EventsProcessor eventProcessor = new EventsProcessor(eventManager);

            DateTime date = DateTime.ParseExact("2011-03-26T09:00:00", "yyyy-MM-ddTHH:mm:ss", CultureInfo.InvariantCulture);

            Event calendarEvent = new Event
            {
                EventDate = date,
                Title = "C# exam",
                Location = null
            };

            EventsManager eventsManager = new EventsManager();

            eventsManager.AddEvent(calendarEvent);

            eventsManager.DeleteEventsByTitle("C# exam");

            IEnumerable<Event> eventsList = eventManager.ListEvents(date, 3);

            int expected = 0;
            int actual = 0;

            foreach (Event currentEvent in eventsList)
            {
                actual++;
            }

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestListEventsAll()
        {
            EventsManager eventManager = new EventsManager();
            EventsProcessor eventProcessor = new EventsProcessor(eventManager);

            DateTime firstEventDate = DateTime.ParseExact("2009-03-26T12:00:00", "yyyy-MM-ddTHH:mm:ss", CultureInfo.InvariantCulture);

            Event firstEvent = new Event
            {
                EventDate = firstEventDate,
                Title = "C# exam",
                Location = null
            };

            DateTime secondEventDate = DateTime.ParseExact("2010-03-26T10:00:00", "yyyy-MM-ddTHH:mm:ss", CultureInfo.InvariantCulture);

            Event secondEvent = new Event
            {
                EventDate = secondEventDate,
                Title = "C# exam",
                Location = "Gabrovo"
            };

            DateTime thirdEventDate = DateTime.ParseExact("2013-03-26T07:43:00", "yyyy-MM-ddTHH:mm:ss", CultureInfo.InvariantCulture);

            Event thirdEvent = new Event
            {
                EventDate = thirdEventDate,
                Title = "C# exam",
                Location = null
            };

            DateTime listingDateTime = DateTime.ParseExact("2001-03-26T07:43:00", "yyyy-MM-ddTHH:mm:ss", CultureInfo.InvariantCulture);

            EventsManager eventsManager = new EventsManager();

            eventsManager.AddEvent(firstEvent);
            eventsManager.AddEvent(secondEvent);
            eventsManager.AddEvent(thirdEvent);

            IEnumerable<Event> eventsList = eventsManager.ListEvents(listingDateTime, 3);

            int expectedEventsCount = 3;
            int actualEventsCount = 0;

            foreach (Event calendarEv in eventsList)
            {
                actualEventsCount++;
            }

            Assert.AreEqual(expectedEventsCount, actualEventsCount);
        }


        [TestMethod]
        public void TestListEventsPartial()
        {
            EventsManager eventManager = new EventsManager();
            EventsProcessor eventProcessor = new EventsProcessor(eventManager);

            DateTime firstEventDate = DateTime.ParseExact("2009-03-26T12:00:00", "yyyy-MM-ddTHH:mm:ss", CultureInfo.InvariantCulture);

            Event firstEvent = new Event
            {
                EventDate = firstEventDate,
                Title = "C# exam",
                Location = null
            };

            DateTime secondEventDate = DateTime.ParseExact("2010-03-26T10:00:00", "yyyy-MM-ddTHH:mm:ss", CultureInfo.InvariantCulture);

            Event secondEvent = new Event
            {
                EventDate = secondEventDate,
                Title = "C# exam",
                Location = "Gabrovo"
            };

            DateTime thirdEventDate = DateTime.ParseExact("2013-03-26T07:43:00", "yyyy-MM-ddTHH:mm:ss", CultureInfo.InvariantCulture);

            Event thirdEvent = new Event
            {
                EventDate = thirdEventDate,
                Title = "C# exam",
                Location = null
            };

            DateTime listingDateTime = DateTime.ParseExact("2010-03-26T10:00:00", "yyyy-MM-ddTHH:mm:ss", CultureInfo.InvariantCulture);

            EventsManager eventsManager = new EventsManager();

            eventsManager.AddEvent(firstEvent);
            eventsManager.AddEvent(secondEvent);
            eventsManager.AddEvent(thirdEvent);

            IEnumerable<Event> eventsList = eventsManager.ListEvents(listingDateTime, 3);

            int expectedEventsCount = 2;
            int actualEventsCount = 0;

            foreach (Event calendarEv in eventsList)
            {
                actualEventsCount++;
            }

            Assert.AreEqual(expectedEventsCount, actualEventsCount);
        }

        [TestMethod]
        public void TestListEventsSame()
        {
            EventsManager eventManager = new EventsManager();
            EventsProcessor eventProcessor = new EventsProcessor(eventManager);

            DateTime firstEventDate = DateTime.ParseExact("2009-03-26T12:00:00", "yyyy-MM-ddTHH:mm:ss", CultureInfo.InvariantCulture);

            Event firstEvent = new Event
            {
                EventDate = firstEventDate,
                Title = "C# exam",
                Location = null
            };

            DateTime secondEventDate = DateTime.ParseExact("2009-03-26T12:00:00", "yyyy-MM-ddTHH:mm:ss", CultureInfo.InvariantCulture);

            Event secondEvent = new Event
            {
                EventDate = secondEventDate,
                Title = "C# exam",
                Location = null
            };

            DateTime thirdEventDate = DateTime.ParseExact("2009-03-26T12:00:00", "yyyy-MM-ddTHH:mm:ss", CultureInfo.InvariantCulture);

            Event thirdEvent = new Event
            {
                EventDate = thirdEventDate,
                Title = "C# exam",
                Location = null
            };

            DateTime listingDateTime = DateTime.ParseExact("2001-03-26T07:43:00", "yyyy-MM-ddTHH:mm:ss", CultureInfo.InvariantCulture);

            EventsManager eventsManager = new EventsManager();

            eventsManager.AddEvent(firstEvent);
            eventsManager.AddEvent(secondEvent);
            eventsManager.AddEvent(thirdEvent);

            IEnumerable<Event> eventsList = eventsManager.ListEvents(listingDateTime, 3);

            int expectedEventsCount = 3;
            int actualEventsCount = 0;

            foreach (Event calendarEv in eventsList)
            {
                actualEventsCount++;
            }

            Assert.AreEqual(expectedEventsCount, actualEventsCount);
        }

        [TestMethod]
        public void TestListEventsSamePartial()
        {
            EventsManager eventManager = new EventsManager();
            EventsProcessor eventProcessor = new EventsProcessor(eventManager);

            DateTime firstEventDate = DateTime.ParseExact("2009-03-26T12:00:00", "yyyy-MM-ddTHH:mm:ss", CultureInfo.InvariantCulture);

            Event firstEvent = new Event
            {
                EventDate = firstEventDate,
                Title = "C# exam",
                Location = null
            };

            DateTime secondEventDate = DateTime.ParseExact("2009-03-26T12:00:00", "yyyy-MM-ddTHH:mm:ss", CultureInfo.InvariantCulture);

            Event secondEvent = new Event
            {
                EventDate = secondEventDate,
                Title = "C# exam",
                Location = null
            };

            DateTime thirdEventDate = DateTime.ParseExact("2009-03-26T12:00:00", "yyyy-MM-ddTHH:mm:ss", CultureInfo.InvariantCulture);

            Event thirdEvent = new Event
            {
                EventDate = thirdEventDate,
                Title = "C# exam",
                Location = null
            };

            DateTime listingDateTime = DateTime.ParseExact("2001-03-26T07:43:00", "yyyy-MM-ddTHH:mm:ss", CultureInfo.InvariantCulture);

            EventsManager eventsManager = new EventsManager();

            eventsManager.AddEvent(firstEvent);
            eventsManager.AddEvent(secondEvent);
            eventsManager.AddEvent(thirdEvent);

            IEnumerable<Event> eventsList = eventsManager.ListEvents(listingDateTime, 2);

            int expectedEventsCount = 2;
            int actualEventsCount = 0;

            foreach (Event calendarEv in eventsList)
            {
                actualEventsCount++;
            }

            Assert.AreEqual(expectedEventsCount, actualEventsCount);
        }
    }
}