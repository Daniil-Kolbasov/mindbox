namespace mindbox.ShapeLibrary;

/// <summary>
/// Represents the shape of a triangle
/// </summary>
/// <exception cref="ArgumentException"></exception>
public class Triangle : Shape
{
    double _sideA, _sideB, _sideC;
    public double SideA
    {
        get => _sideA;
        init => _sideA = ChackGreaterThanZero(value);
    }
    public double SideB
    {
        get => _sideB;
        init => _sideB = ChackGreaterThanZero(value);
    }
    public double SideC
    {
        get => _sideC;
        init => _sideC = ChackGreaterThanZero(value);
    }
    double ChackGreaterThanZero(double value)
    {
        if (value <= 0)
            throw new ArgumentException("The sides of a triangle cannot be less than or equal to zero");
        return value;
    }

    public Triangle(double sideA, double sideB, double sideC)
    {
        SideA = sideA;
        SideB = sideB;
        SideC = sideC;
    }

    public sealed override double GetSquare() => GetSuareByHeron(SideA, SideB, SideC);

    internal static double GetSuareByHeron(double a, double b, double c)
    {
        double p = (a + b + c) / 2;
        return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
    }
}
