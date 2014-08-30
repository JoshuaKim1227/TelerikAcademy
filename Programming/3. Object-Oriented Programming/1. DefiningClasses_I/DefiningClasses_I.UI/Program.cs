using System;
using System.Collections.Generic;
using DefiningClasses_I.Core;

namespace DefiningClasses_I.UI
{
    class Program
    {
        static void Main()
        {
            List<GSM> mobileDevices = new List<GSM>();

            mobileDevices.Add(new GSM("Sony Ericsson", "K700I", 75, "Goshko"));
            mobileDevices.Add(new GSM("Nokia", "Experia", 150));
            mobileDevices.Add(new GSM("Samsung", "Galaxy", 230, "Kircho"));
            mobileDevices.Add(new GSM("Apple", "IPhone"));
            mobileDevices.Add(new GSM("HTC", "Turbo", 400, "Kolio"));
            mobileDevices.Add(new GSM("HTC", "Turbo", 400, "Kolio", new Battery("Sony", 30, 3, BatteryType.NiCd)));
            mobileDevices.Add(new GSM("HTC", "Turbo", 400, "Kolio", new Battery("Sony", 30, 3, BatteryType.NiCd), new Display(10, 16000000)));

            foreach (GSM mobileDevice in mobileDevices)
            {
                Console.WriteLine(mobileDevice);
            }

            Console.WriteLine(GSM.IPhone4S);

            GSMCallHistoryTest.Test();
        }
    }
}
