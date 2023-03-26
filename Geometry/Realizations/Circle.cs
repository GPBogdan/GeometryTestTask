using Geometry.Interfaces;

namespace Geometry.Realizations
{
    public class Circle : IShape
    {
        public const double MinRadius = Constans.Constants.MinRadius;

        public Circle(double radius)
        {
            if (radius - MinRadius < Constans.Constants.CalculationAccuracy) 
                throw new ArgumentException("Incorrect radius", nameof(radius));
            Radius = radius;
        }

        public double Radius { get; }

        public double GetSquare()
        {
            return Math.PI * Math.Pow(Radius, 2d);
        }
    }
}
