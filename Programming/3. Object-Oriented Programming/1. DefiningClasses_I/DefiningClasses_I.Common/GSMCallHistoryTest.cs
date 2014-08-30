using System;
using DefiningClasses_I.Core;
using System.Collections.Generic;

namespace DefiningClasses_I.Core
{
    public class GSMCallHistoryTest
    {
        public static void Test()
        {
            GSM mobileDevice = new GSM("HTC", "Turbo", 400, "Kolio", new Battery("Sony", 30, 3, BatteryType.NiCd), new Display(10, 16000000));

            mobileDevice.AddCall("15.06.2010", "13:43", 0811123432, 56);
            mobileDevice.AddCall("12.05.2011", "16:23", 0811132432, 231);
            mobileDevice.AddCall("09.02.2012", "11:25", 0854723432, 16);
            mobileDevice.AddCall("23.11.2011", "09:13", 0812124231, 26);
            mobileDevice.AddCall("17.07.2011", "20:43", 0856723232, 113);

            mobileDevice.ShowCallHistoryInfo();

            decimal totalPrice = mobileDevice.CalculateCallsPrice(0.37);
            Console.WriteLine("\nTotal price of calls is {0}", totalPrice);

            mobileDevice.DeleteLongestCall();
            totalPrice = 0;

            totalPrice = mobileDevice.CalculateCallsPrice(0.37);
            Console.WriteLine("Total price of calls is {0}", totalPrice);

            mobileDevice.ClearHistory();

            mobileDevice.ShowCallHistoryInfo();
        }
    }
}
