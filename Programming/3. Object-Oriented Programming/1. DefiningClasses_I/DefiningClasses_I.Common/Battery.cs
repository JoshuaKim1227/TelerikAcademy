namespace DefiningClasses_I.Core
{
    using System;

    public class Battery
    {
        // Initializing data types
        private string model;
        private int? hoursIdle;
        private int? hoursTalk;
        private BatteryType batteryType;

        // Constructors
        public Battery()
        {
            this.Model = null;
            this.HoursIdle = null;
            this.HoursTalk = null;
        }

        public Battery(string model)
        {
            this.Model = model;
            this.HoursIdle = null;
            this.HoursTalk = null;
        }

        public Battery(string model, int hoursIdle)
        {
            this.Model = model;
            this.HoursIdle = hoursIdle;
            this.HoursTalk = null;
        }

        public Battery(string model, int hoursIdle, int hoursTalk)
        {
            this.Model = model;
            this.HoursIdle = hoursIdle;
            this.HoursTalk = hoursTalk;
        }

        public Battery(string model, int hoursIdle, int hoursTalk, BatteryType batteryType)
        {
            this.Model = model;
            this.HoursIdle = hoursIdle;
            this.HoursTalk = hoursTalk;
            this.BatteryType = batteryType;
        }

        // Properties
        public string Model
        {
            get { return this.model; }
            set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Battery model must be at least 3 characters.");
                }

                this.model = value;
            }
        }

        public int? HoursIdle
        {
            get { return this.hoursIdle; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Hours idle cannot be a negative number.");
                }

                this.hoursIdle = value;
            }
        }

        public int? HoursTalk
        {
            get { return this.hoursTalk; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Hours talk cannot be a negative number.");
                }

                this.hoursTalk = value;
            }
        }

        public BatteryType BatteryType
        {
            get { return this.batteryType; }
            set
            {
                if (BatteryType != BatteryType.LiIon && BatteryType != BatteryType.NiMh && BatteryType != BatteryType.NiCd)
                {
                    throw new ArgumentException("Battery type must be one of the three predefined types.");   
                }

                this.batteryType = value;
            }
        }
    }
}
