using System;

namespace CohesionAndCoupling
{
    public class DiagonalCalculator : ShapeCalculator3D
    {
        private double width;
        private double height;
        private double depth;

        public DiagonalCalculator(double width, double height, double depth)
        {
            this.width = width;
            this.height = height;
            this.depth = depth;
        }

        public double Width
        {
            get
            {
                return this.width;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Width");
                }

                this.width = value;
            }
        }

        public double Height
        {
            get
            {
                return this.height;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Height");
                }

                this.height = value;
            }
        }

        public double Depth
        {
            get
            {
                return this.depth;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Depth");
                }

                this.depth = value;
            }
        }

        public double CalcDiagonalXY()
        {
            double distance = CalcDistance2D(0, 0, Width, Height);

            return distance;
        }

        public double CalcDiagonalXZ()
        {
            double distance = CalcDistance2D(0, 0, Width, Depth);

            return distance;
        }

        public double CalcDiagonalYZ()
        {
            double distance = CalcDistance2D(0, 0, Height, Depth);

            return distance;
        }

        public double CalcDiagonalXYZ()
        {
            double distance = CalcDistance3D(0, 0, 0, Width, Height, Depth);

            return distance;
        }

        public double CalcVolume()
        {
            double volume = Width * Height * Depth;

            return volume;
        }
    }
}