namespace mindbox.ShapeLibrary;

public class ReguralPolygon(double length, uint number) : IShape
{
    public double A { get; set; } = length;
    public uint N { get; set; } = number;

    public double GetSquare()
    {
        if (!IsExist()) return 0;

        return A * A * (double)N / 4d * Math.Tan(Math.PI / (double)N);
    }

    public bool IsExist() => N > 2;
}
