using System.Transactions;

namespace mindbox.ShapeLibrary;

public class ReguralPolygon (double length, uint number) : IShape
{
    public double A { get; set; } = length;
    public uint N { get; set; } = number;

    public double GetSquare()
    {
        if (A == 0) return 0;

        return A * A * N / 4 *  Math.Tan(Math.PI / N);
    }
}
