namespace mindbox.ShapeLibrary;

public class Circle(double length, Circle.SquareMode paramType = Circle.SquareMode.Radius) : IShape
{
    public double Length { get; set; } = length;
    public SquareMode Mode { get; set; } = paramType;
    public enum SquareMode
    {
        Radius,
        Diameter,
        Perimeter
    }

    public double GetSquare() => Mode switch
    {
        SquareMode.Radius => GetSquareByRadius(Length),
        SquareMode.Diameter => GetSquareByDiameter(Length),
        SquareMode.Perimeter => GetSquareByPerimeter(Length),
        _ => throw new NotImplementedException(),
    };

    public bool IsExist() => Length != 0;
    #region fomulas for find square
    private static double GetSquareByRadius(double radius) => Math.PI * Math.Pow(radius, 2);

    private static double GetSquareByDiameter(double diameter) => Math.PI * Math.Pow(diameter, 2) / 4d;

    private static double GetSquareByPerimeter(double perimeter)
    {
        if (perimeter == 0) return 0;
        return Math.Pow(perimeter, 2) / 4 * Math.PI;
    }
    #endregion
}
