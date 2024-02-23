namespace mindbox.ShapeLibrary;

public class Shape(params double[] values)
{
    readonly double[] _values = values;

    /// <summary>Array of values</summary>
    public double[] Values => _values;

    /// <summary>Get the square of the shape depending on the number of variables.</summary>
    /// <returns>The square of the shape.</returns>
    public virtual double GetSquare() => Values.Length switch
    {
        0 => 0,
        1 => Circle.GetSquareByRadius(Values[0]),
        3 => Triangle.GetSuareByHeron(Values[0], Values[1], Values[2]),
        _ => throw new NotImplementedException()
    };
}
