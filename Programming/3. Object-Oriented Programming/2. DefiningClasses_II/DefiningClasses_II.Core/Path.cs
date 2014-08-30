namespace DefiningClasses_II.Core
{
    using System;
    using System.Collections.Generic;

    public class Path
    {
        // Fileld
        private List<Point3D> sequenceOfPoints = new List<Point3D>();

        // Property
        public List<Point3D> SequenceOfPoints
        {
            get
            {
                return this.sequenceOfPoints;
            }

            set
            {
                this.sequenceOfPoints = value;
            }
        }
    }
}
