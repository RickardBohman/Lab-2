using System.Numerics;

namespace ShapesLibary
{
    public abstract class Shape
    {
        public abstract Vector3 Center { get; }
        public abstract float Area { get; }


        public static Shape GenerateShape()
        {
                
                int RandomNumber = Random.Shared.Next(0, 6);
                

                switch (RandomNumber)
                {
                    case 0:
                        Vector2 center0 = new Vector2(Random.Shared.NextSingle() * 200 - 100, Random.Shared.NextSingle() * 200 - 100);
                        float radius0 = Random.Shared.NextSingle() * 200 - 100;

                        return new Circle(center0, radius0);


                    case 1:
                        Vector2 center1 = new Vector2(Random.Shared.NextSingle() * 200 - 100, Random.Shared.NextSingle() * 200 - 100);
                        Vector2 size1 = new Vector2(Random.Shared.NextSingle() * 200 - 100, Random.Shared.NextSingle() * 200 - 100);

                        return new Rectangle(center1, size1);

                    case 2:
                        Vector2 center2 = new Vector2(Random.Shared.NextSingle() * 200 - 100, Random.Shared.NextSingle() * 200 - 100);
                        Vector2 size2 = new Vector2(Random.Shared.NextSingle() * 200 - 100);

                        return new Rectangle(center2, size2);


                    case 3:
                        Vector3 center3 = new Vector3(Random.Shared.NextSingle() * 200 - 100, Random.Shared.NextSingle() * 200 - 100, Random.Shared.NextSingle() * 200 - 100);
                        Vector3 size3 = new Vector3(Random.Shared.NextSingle() * 200 - 100, Random.Shared.NextSingle() * 200 - 100, Random.Shared.NextSingle() * 200 - 100);

                        return new Cuboid(center3, size3);


                    case 4:
                        Vector3 center4 = new Vector3(Random.Shared.NextSingle() * 200 - 100, Random.Shared.NextSingle() * 200 - 100, Random.Shared.NextSingle() * 200 - 100);
                        Vector3 size4 = new Vector3(Random.Shared.NextSingle() * 200 - 100);

                        return new Cuboid(center4, size4);



                    case 5:
                        Vector3 center5 = new Vector3(Random.Shared.NextSingle() * 200 - 100, Random.Shared.NextSingle() * 200 - 100, Random.Shared.NextSingle() * 200 - 100);
                        float radius5 = Random.Shared.NextSingle() * 200 - 100;

                        return new Sphere(center5, radius5);


                    default:
                            return null;

                   
                }



           
        }
    }
}

