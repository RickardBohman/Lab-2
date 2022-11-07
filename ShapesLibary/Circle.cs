using System.Numerics;

namespace ShapesLibary
{
    public class Circle : Shape2D
    {

        //Skapa private properties och sedan feeders till dom.
        //Sedan gör du uträkingen.

        private Vector2 _center;
        private float _radius;

        public float areaRadius;

        public Circle(Vector2 center, float radius)
        {
            _center = center;
            _radius = radius;
            areaRadius = radius;
        }


        public override float Circumference => (float)Math.PI * areaRadius * 2;

        public override Vector3 Center => new Vector3(Center.X, Center.Y, 0f);

        public override float Area => (float)Math.PI * areaRadius * areaRadius;

        public override string ToString() => $"circle @{_center.ToString("f2")}: r ={_radius.ToString("f2")}, Area: {Area}";

    }

}























