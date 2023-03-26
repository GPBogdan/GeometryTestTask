using Geometry.Interfaces;

namespace Geometry.Realizations
{
    public class Triangle : ITriangle
    {
        public double EdgeA { get; }
        public double EdgeB { get; }
        public double EdgeC { get; }

        private readonly Lazy<bool> _isRightTriangle;
        public bool IsRightTriangle => _isRightTriangle.Value;

        private double eps = Constans.Constants.CalculationAccuracy;

        public Triangle(double edgeA, double edgeB, double edgeC)
        {
            if (edgeA < eps) throw new ArgumentException("Incorrect side value", nameof(edgeA));
            if (edgeB < eps) throw new ArgumentException("Incorrect side value", nameof(edgeB));
            if (edgeC < eps) throw new ArgumentException("Incorrect side value", nameof(edgeC));

            var maxEdge = Math.Max(edgeA, Math.Max(edgeB, edgeC));
            var perimeter = edgeA + edgeB + edgeC;
            if ((perimeter - maxEdge) - maxEdge < eps)
                throw new ArgumentException("The longest side of the triangle must be less than the sum of the other sides");

            EdgeA = edgeA;
            EdgeB = edgeB;
            EdgeC = edgeC;

            _isRightTriangle = new Lazy<bool>(GetIsRightTriangle);
        }

        private bool GetIsRightTriangle()
        {
            double maxEdge = EdgeA, b = EdgeB, c = EdgeC;
            if (b - maxEdge > eps)
                Utils.Utils.Swap(ref maxEdge, ref b);

            if (c - maxEdge > eps)
                Utils.Utils.Swap(ref maxEdge, ref c);

            return Math.Abs(Math.Pow(maxEdge, 2) - Math.Pow(b, 2) - Math.Pow(c, 2)) < eps;
        }

        public double GetSquare()
        {
            var halfP = (EdgeA + EdgeB + EdgeC) / 2d;
            var square = Math.Sqrt(
                halfP
                * (halfP - EdgeA)
                * (halfP - EdgeB)
                * (halfP - EdgeC)
            );

            return square;
        }
    }
}
