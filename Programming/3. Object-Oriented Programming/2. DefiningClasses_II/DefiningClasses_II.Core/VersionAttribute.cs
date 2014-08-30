namespace DefiningClasses_II.Core
{
    using System;

    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Enum)]
    public class VersionAttribute : Attribute
    {
        // Constructor
        public VersionAttribute(int major, int minor)
        {
            this.Major = major;
            this.Minor = minor;
        }

        // Properties
        public int Major { get; private set; }

        public int Minor { get; private set; }
    }
}