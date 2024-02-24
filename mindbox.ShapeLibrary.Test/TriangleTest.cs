using Newtonsoft.Json.Linq;

namespace mindbox.ShapeLibrary.Test;

public class TriangleTest
{
    [Fact]
    public void IsExist_True() => IsExist(true, 2, 3, 4);

    [Fact]
    public void IsExist_False() => IsExist(false, 2, 4, 50);

    private static void IsExist(bool expected, double a, double b, double c)
    {
        var triangle = new Triangle(a, b, c);

        var actual = triangle.IsExist();

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void IsRegtangular_True() => IsRectangular(true, 3, 4, 5);

    [Fact]
    public void IsRegtangular_False() => IsRectangular(false, 2, 3, 4);

    private static void IsRectangular(bool expected, int a, int b, int c)
    {
        var triangle = new Triangle(a, b, c);

        var actual = triangle.IsRectangular();

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void GetSquare_Exist() => GetSquare(6, 3, 4, 5);

    [Fact]
    public void GetSquare_NotExist() => GetSquare(0, 3, 4, 50);

    private void GetSquare(double expected, double a, double b, double c)
    {
        var triangle = new Triangle(a, b, c);

        var actual = triangle.GetSquare();

        Assert.Equal(expected, actual);
    }
}
