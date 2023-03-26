namespace Geometry.Interfaces
{
    public interface ITriangle : IShape
    {
        double EdgeA { get; }
        double EdgeB { get; }
        double EdgeC { get; }

        bool IsRightTriangle { get; }
    }
}
