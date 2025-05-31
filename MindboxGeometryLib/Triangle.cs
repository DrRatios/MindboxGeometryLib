namespace MindboxGeometryLib;

public class Triangle : IShape
{
    public string Name => "Triangle";
    public int SidesCount => 3;
    public int SideA { get; }
    public int SideB { get; }
    public int SideC { get; }
    public Triangle(int sideA, int sideB, int sideC)
    {
        ValidateSides(sideA, sideB, sideC);
        SideA = sideA;
        SideB = sideB;
        SideC = sideC;
    }
    
    public double CalculateArea()
    {
        // Формула Герона
        double p = CalculatePerimeter() / 2;
        return Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
    }

    public double CalculatePerimeter()
    {
        return SideA + SideB + SideC;
    }
    private static void ValidateSides(double a, double b, double c)
    {
        if (a <= 0 || b <= 0 || c <= 0)
            throw new ArgumentException("Стороны должны быть положительными");
        if (!(a + b > c && a + c > b && b + c > a))
            throw new ArgumentException("Недопустимые стороны треугольника, приведите треугольник к формуле (a + b > c && a + c > b && b + c > a)");
    }
    
    public bool IsRightAngled()
    {
        double[] sides = { SideA, SideB, SideC };
        Array.Sort(sides); // Сортируем стороны по возрастанию

        // Теорема Пифагора: a² + b² = c² (где c — наибольшая сторона)
        double aSquared = sides[0] * sides[0];
        double bSquared = sides[1] * sides[1];
        double cSquared = sides[2] * sides[2];

        // Сравнение с учётом погрешности вычислений
        return Math.Abs(aSquared + bSquared - cSquared) < 0.0001;
    }
}