using System;
using System.Collections.Generic;

namespace DefiningClasses_I.Core
{
    public class GSM
    {
        // Initializing data types
        private string model;
        private string manufacturer;
        private int? price;
        private string owner;
        private List<Call> callHistory = new List<Call>();
        private Battery battery;
        private Display display;
        private static GSM iPhone4S = new GSM("Apple", "IPhone 4S", 300, "Gancho");

        // Constructors
        public GSM(string manufacturer, string model)
        {
            Manufacturer = manufacturer;
            Model = model;
            Price = null;
            Owner = null;
        }

        public GSM(string manufacturer, string model, int price)
        {
            Model = model;
            Manufacturer = manufacturer;
            Price = price;
            Owner = null;
        }

        public GSM(string manufacturer, string model, int price, string owner)
        {
            Model = model;
            Manufacturer = manufacturer;
            Price = price;
            Owner = owner;
        }

        public GSM(string manufacturer, string model, int price, string owner, Battery battery)
        {
            Model = model;
            Manufacturer = manufacturer;
            Price = price;
            Owner = owner;
            this.battery = battery;
        }

        public GSM(string manufacturer, string model, int price, string owner, Battery battery, Display display)
        {
            Model = model;
            Manufacturer = manufacturer;
            Price = price;
            Owner = owner;
            this.battery = battery;
            this.display = display;
        }

        // Properties
        public string Model
        {
            get 
            { 
                return this.model; 
            }

            set 
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Model must contain at least 3 characters.");
                }
                this.model = value;
            }
        }

        public string Manufacturer
        {
            get
            { 
                return this.manufacturer; 
            }

            set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Phone model must be at least 3 characters.");
                }
                this.manufacturer = value;
            }
        }

        public int? Price
        {
            get 
            { 
                return this.price; 
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Price cannot be negative number.");
                }
                this.price = value;
            }
        }

        public string Owner
        {
            get { return this.owner; }
            set
            {
                if (value != null && value.Length < 3)
                {
                    throw new ArgumentException("Owner's name must be at least 3 characters.");
                }
                this.owner = value;
            }
        }

        public List<Call> CallHistory
        {
            get { return this.callHistory; }
        }

        public static GSM IPhone4S
        {
            get { return iPhone4S; }
        }

        // Methods
        public override string ToString()
        {
            string info;

            info = String.Format("\nGSM Manufacturer: {0}\nModel: {1}\nPrice: {2}\nOwner: {3}", manufacturer, model, price, owner ?? "No Info");

            if (battery != null)
            {
                info = info + String.Format("\n[GSM Battery]\nModel: {0}\nHours Idle: {1}\nHours Talk: {2}", battery.Model, battery.HoursIdle, battery.HoursTalk); 
            }
            else
            {
                return info;
            }

            if (display != null)
            {
                info = info + String.Format("\n[GSM Display]\nSize: {0}\nNumber of colors: {1}", display.Size, display.NumberOfColors); 
            }
            else
            {
                return info;
            }

            return info;
        }

        public void AddCall(string date, string time, int dialedPhone, int duration)
        {
            CallHistory.Add(new Call(date, time, dialedPhone, duration));
        }

        public void DeleteCall(int index)
        {
            CallHistory.RemoveAt(index);
        }

        public void DeleteLongestCall()
        {
            int longestDuration = 0;
            int indexOfLongestCall = 0;

            for (int index = 0; index < callHistory.Count; index++)
            {
                if (longestDuration < callHistory[index].Duration)
                {
                    longestDuration = callHistory[index].Duration;
                    indexOfLongestCall = index;
                }
            }

            callHistory.RemoveAt(indexOfLongestCall);
        }

        public void ClearHistory()
        {
            CallHistory.Clear();
        }

        public decimal CalculateCallsPrice(double pricePerMin)
        {
            decimal pricePerSecond = (decimal)pricePerMin / 60;
            int totalDuration = 0;
            decimal totalPrice = 0;

            foreach (Call call in CallHistory)
            {
                totalDuration += call.Duration;
            }

            return totalPrice = totalDuration * pricePerSecond;
        }

        public void ShowCallHistoryInfo()
        {
            bool isEmpty = true;

            foreach (Call call in CallHistory)
            {
                isEmpty = false;
                Console.WriteLine("\nCall Date: {0}\nCall Time: {1}\nDialed Phone: {2}\nDuration: {3} seconds",call.Date, call.Time, call.DialedPhone, call.Duration);
            }

            if (isEmpty)
            {
                Console.WriteLine("\nNo calls");
            }
        }
    }
}
