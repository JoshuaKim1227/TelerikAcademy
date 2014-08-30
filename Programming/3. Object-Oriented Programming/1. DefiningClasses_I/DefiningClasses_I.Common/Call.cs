namespace DefiningClasses_I.Core
{
    using System;

    public class Call
    {
        // Initializing data types
        private string date;
        private string time;
        private int dialedPhone;
        private int duration;

        // Constructors
        public Call()
        {
        }

        public Call(string date)
        {
            this.Date = date;
        }

        public Call(string date, string time)
        {
            this.Date = date;
            this.Time = time;
        }

        public Call(string date, string time, int dialedPhone)
        {
            this.Date = date;
            this.Time = time;
            this.DialedPhone = dialedPhone;
        }

        public Call(string date, string time, int dialedPhone, int duration)
        {
            this.Date = date;
            this.Time = time;
            this.DialedPhone = dialedPhone;
            this.Duration = duration;
        }

        // Properties
        public string Date
        {
            get { return this.date; }
            set
            {
                if (value.Length < 6)
                {
                    throw new ArgumentException("Indalid date.");
                }

                this.date = value;
            }
        }

        public string Time
        {
            get { return this.time; }
            set
            {
                if (value.Length < 4)
                {
                    throw new ArgumentException("Invalid time.");
                }

                this.time = value;
            }
        }

        public int DialedPhone
        {
            get { return this.dialedPhone; }
            set
            {
                if (value < 10000)
                {
                    throw new ArgumentException("The phone number must be at least 5 digits.");
                }

                this.dialedPhone = value;
            }
        }

        public int Duration
        {
            get { return this.duration; }
            set
            {
                if (value < 1)
                {
                    throw new ArgumentException("The call duration must be at least 1 second.");
                }

                this.duration = value;
            }
        }
    }
}
