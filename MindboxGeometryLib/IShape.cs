namespace MindboxGeometryLib;

public interface IShape
{
    // Обязательные свойства
    string Name { get; }
    int SidesCount { get; }
    
    // Обязательные методы
    double CalculateArea();
    double CalculatePerimeter();
}