
using System.Numerics;
using ShapesLibary;


//Vector2 center = new Vector2(4.0f, 3.0f);
//Vector2 size = new Vector2(4.0f, 4.0f);
//Rectangle myRectangle = new Rectangle(center,size);

//float radius = 5.0f;
//Circle myCirlce = new Circle(center, radius);

//Vector3 center = new Vector3(4.0f, 7.0f, 4.0f);
//float size = 4.0f;

////Vector3 size = new Vector3(4.0f, 4.0f, 4.0f);

//Sphere mySphere = new Sphere(center, size);

////Cuboid myCuboid = new Cuboid(center, size);

//Console.WriteLine(mySphere);
//Console.WriteLine(mySphere.Area);
////Console.WriteLine(myCuboid.Circumference);



Shape[] Shapes = new Shape[20];
float totalArea = 0f;

for (int i = 0; i < Shapes.Length;i++)
{
    Shapes[i] = Shape.GenerateShape();
}

foreach (Shape shape in Shapes)
{
    Console.WriteLine(shape);
    totalArea =+ shape.Area;
}

float totalSum = totalArea / 20;

Console.WriteLine("--------------------");

Console.WriteLine($"The total Area of all the shapes is {totalArea.ToString("f2")}");
Console.WriteLine($"And the average Area of all the shapes is {totalSum.ToString("f2")}");