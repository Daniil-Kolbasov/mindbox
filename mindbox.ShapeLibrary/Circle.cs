namespace mindbox.ShapeLibrary;

/// <summary>Represents the shape of a circle</summary>
/// <exception cref="ArgumentException"></exception>
public class Circle : Shape
{
    double _value;

    /// <summary>Array of values</summary>
    public double Value
    {
        get => _value;
        init
        {
            if (value <= 0)
                throw new ArgumentException($"The {nameof(_value)} value must be greater than or equal to zero", nameof(Value));
            _value = value;
        }
    }

    public Circle(double value) => Value = value;


    /// <summary>Get the square of the circle.</summary>
    /// <remarks>Default by radius.</remarks>
    public sealed override double GetSquare() => GetSquareByRadius(Value);

    /// <summary>The name of the square formula</summary>
    public enum FomulaNames
    {
        Radius,
        Diameter,
        Perimeter
    }

    /// <summary>Get the square of the circle by the fomula name.</summary>
    public double GetSquare(FomulaNames fomulaName) => fomulaName switch
    {
        FomulaNames.Radius => GetSquareByRadius(Value),
        FomulaNames.Diameter => GetSquareByDiameter(Value),
        FomulaNames.Perimeter => GetSquareByPerimeter(Value),
        _ => throw new NotImplementedException()
    };

    internal static double GetSquareByRadius(double radius) => Math.PI * Math.Pow(radius, 2);

    internal static double GetSquareByDiameter(double diameter) => 1 / 4 * Math.PI * Math.Pow(diameter, 2);

    internal static double GetSquareByPerimeter(double perimeter) => Math.Pow(perimeter, 2) / 4 * Math.PI;
}
