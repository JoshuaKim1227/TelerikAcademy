namespace DefiningClasses_I.Core
{
    using System;

    public class Display
    {
        // Initializing data types
        private int? size;
        private int? numberOfColors;

        // Constructors
        public Display()
        {
            this.Size = null;
            this.numberOfColors = null;
        }

        public Display(int size)
        {
            this.Size = size;
        }

        public Display(int size, int numberOfColors)
        {
            this.Size = size;
            this.numberOfColors = numberOfColors;
        }

        // Properties
        public int? Size
        {
            get { return this.size; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Display size cannot be negative number.");
                }
                this.size = value;
            }
        }

        public int? NumberOfColors
        {
            get { return this.numberOfColors; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Number of colors of the display cannot be negative number.");
                }
                this.numberOfColors = value;
            }
        }
    }
}
