using System;
using System.Globalization;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace CalendarSystem.Tests
{
    [TestClass]
    public class CommandTests
    {
        [TestMethod]
        public void TestParseAddEvent()
        {
            string command = "AddEvent 2012-03-26T09:00:00 | C# exam";

            Command parsedCommand = Command.Parse(command);

            string expectedName = "AddEvent";
            string actualName = parsedCommand.commandName;

            string[] expectedArguments = { "2012-03-26T09:00:00", "C# exam" };
            string[] actualArguments = parsedCommand.commandArguments;

            Assert.AreEqual(expectedName, actualName);
            CollectionAssert.AreEqual(expectedArguments, actualArguments);
        }

        [TestMethod]
        public void TestParseAddEventWithLocation()
        {
            string command = "AddEvent 2012-01-21T20:00:00 | party Viki | home";

            Command parsedCommand = Command.Parse(command);

            string expectedName = "AddEvent";
            string actualName = parsedCommand.commandName;

            string[] expectedArguments = { "2012-01-21T20:00:00", "party Viki", "home" };
            string[] actualArguments = parsedCommand.commandArguments;

            Assert.AreEqual(expectedName, actualName);
            CollectionAssert.AreEqual(expectedArguments, actualArguments);
        }

        [TestMethod]
        public void TestParseDeleteEvents()
        {
            string command = "DeleteEvents c# exam";

            Command parsedCommand = Command.Parse(command);

            string expectedName = "DeleteEvents";
            string actualName = parsedCommand.commandName;

            string[] expectedArguments = { "c# exam" };
            string[] actualArguments = parsedCommand.commandArguments;

            Assert.AreEqual(expectedName, actualName);
            CollectionAssert.AreEqual(expectedArguments, actualArguments);
        }

        [TestMethod]
        public void TestParseListEvents()
        {
            string command = "ListEvents 2012-03-07T08:00:00 | 2";

            Command parsedCommand = Command.Parse(command);

            string expectedName = "ListEvents";
            string actualName = parsedCommand.commandName;

            string[] expectedArguments = { "2012-03-07T08:00:00", "2" };
            string[] actualArguments = parsedCommand.commandArguments;

            Assert.AreEqual(expectedName, actualName);
            CollectionAssert.AreEqual(expectedArguments, actualArguments);
        }
    }
}