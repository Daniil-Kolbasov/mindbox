using System.Security.Cryptography.X509Certificates;

namespace mindbox.ShapeLibrary;

public class Triangle(double a, double b, double c) : IShape
{
    public double A { get; set; } = a;
    public double B { get; set; } = b;
    public double C { get; set; } = c;

    public double GetSquare()
    {
        if (!IsExist()) return 0;

        return GetSuareByHeron(A, B, C);
    }

    public bool IsExist() => A + B > C && B + C > A && A + C > B;

    public bool IsRectangular()
    {
        if (A * A + B * B == C * C)
            return true;
        if (B * B + C * C == A * A)
        {
            (C, A) = (A, C);
            return true;
        }
        if (A * A + C * C == B * B)
        {
            (B, C) = (C, B);
            return true;
        }
        return false;
    }

    private static double GetSuareByHeron(double a, double b, double c)
    {
        double p = (a + b + c) / 2;
        return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
    }
}
