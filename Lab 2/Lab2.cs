
using System.Numerics;
using ShapesLibary;


Shape[] Shapes = new Shape[20];
float totalArea = 0f;

for (int i = 0; i < Shapes.Length;i++)
{
    Shapes[i] = Shape.GenerateShape();
}

foreach (Shape shape in Shapes)
{
    Console.WriteLine(shape);
    totalArea += shape.Area;
}

float totalSum = totalArea / 20;


Console.WriteLine("--------------------");

Console.WriteLine($"The total Area of all the shapes is {totalArea.ToString("f2")}");
Console.WriteLine($"And the average Area of all the shapes is {totalSum.ToString("f2")}");