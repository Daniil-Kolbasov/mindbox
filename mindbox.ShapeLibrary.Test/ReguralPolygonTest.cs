
namespace mindbox.ShapeLibrary.Test;

public class ReguralPolygonTest
{
    [Fact]
    public void IsExist_True() => IsExist(true, 15, 3);

    [Fact]
    public void IsExist_False() => IsExist(false, 10, 1);

    private static void IsExist(bool expected, double a, uint n)
    {
        var rp = new ReguralPolygon(a, n);

        var actual = rp.IsExist();

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void GetSquare_Exist() => GetSquare(20.784609690826521, 4, 3);

    [Fact]
    public void GetSquare_NotExist() => GetSquare(0, 4, 2);

    private static void GetSquare(double expected, double a, uint n)
    {
        var rp = new ReguralPolygon(a, n);

        var actual = rp.GetSquare();

        Assert.Equal(expected, actual);
    }
}
