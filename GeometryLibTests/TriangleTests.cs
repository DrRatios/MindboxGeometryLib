
using MindboxGeometryLib;
using Xunit.Abstractions;

namespace GeometryLibTests;

public class TriangleTests(ITestOutputHelper testOutputHelper)
{
    private readonly Triangle _triangle = new Triangle(2, 5, 4);

    [Fact]
    public void CalculatePerimeterTest()
    {
        var perimeter = _triangle.CalculatePerimeter();
        Assert.True(perimeter > 0);
        Assert.Equal(11, _triangle.CalculatePerimeter());
    }
    [Fact]
    public void CalculateAreaTest()
    {
        var area = _triangle.CalculateArea();
        Assert.True(area > 0);
        Assert.Equal(3.799671038392666, _triangle.CalculateArea());
    }
    [Fact]
    public void ValidationTest()
    {
        Assert.Throws<ArgumentException>(() => new Triangle(1, 2, 3));
    }
}