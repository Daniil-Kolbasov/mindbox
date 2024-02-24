namespace mindbox.ShapeLibrary.Test;

public class CircleTest
{
    [Fact]
    public void IsExist_True() => IsExist(true, 2);

    [Fact]
    public void IsExist_False() => IsExist(false, 0);

    private static void IsExist(bool expected, double length)
    {
        var circle = new Circle(length);

        var actual = circle.IsExist();

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void GetSquare_Radius_Positive() => GetSquare(452.38934211693021, 12);

    [Fact]
    public void GetSquare_Radius_Zero() => GetSquare(0, 0);

    [Fact]
    public void GetSquare_Radius_Negative() => GetSquare(452.38934211693021, -12);

    [Fact]
    public void GetSquare_Diameter_Positive() => GetSquare(176.71458676442586, 15, Circle.SquareMode.Diameter);

    [Fact]
    public void GetSquare_Diameter_Zero() => GetSquare(0, 0, Circle.SquareMode.Diameter);

    [Fact]
    public void GetSquare_Diameter_Negative() => GetSquare(113.09733552923255, -12, Circle.SquareMode.Diameter);
    [Fact]
    public void GetSquare_Perimeter_Positive() => GetSquare(0.78539816339744828, 1, Circle.SquareMode.Perimeter);
    [Fact]
    public void GetSquare_Perimeter_Zero() => GetSquare(0, 0, Circle.SquareMode.Perimeter);
    [Fact]
    public void GetSquare_Perimeter_Negative() => GetSquare(3.1415926535897931, -2, Circle.SquareMode.Perimeter);

    private static void GetSquare(double expected, double value, Circle.SquareMode mode = Circle.SquareMode.Radius)
    {
        var circle = new Circle(value, mode);

        var actual = circle.GetSquare();

        Assert.Equal(expected, actual);
    }
}