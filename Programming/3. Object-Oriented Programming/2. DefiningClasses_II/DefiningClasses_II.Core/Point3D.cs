namespace DefiningClasses_II.Core
{
    using System;

    public struct Point3D
    {
        // Fields
        private static readonly Point3D ZeroPointField = new Point3D(0, 0, 0);

        public Point3D(int x, int y, int z) : this()
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        // Properties
        public static Point3D ZeroPoint
        {
            get { return ZeroPointField; }
        }

        public int X { get; set; }

        public int Y { get; set; }

        public int Z { get; set; }

        // Methods
        public override string ToString()
        {
            return string.Format("Point X: {0}\nPoint Y: {1}\nPoint Z: {2}", this.X, this.Y, this.Z);
        }
    }
}
