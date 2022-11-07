using System.Numerics;

namespace ShapesLibary
{
    public class Sphere : Shape3D
    {
        private Vector3 _center;
        private float _radius;

        public Sphere(Vector3 center, float radius)
        {
            _center = center;
            _radius = radius;
        }


        public override Vector3 Center => new Vector3(_center.X, _center.Y, _center.Z);

        public override float Area => 4 * (float)Math.PI * (_radius * _radius);

        public override float Volume => (4 * (float)Math.PI * (_radius * _radius * _radius)) / 3;

        public override string ToString() => $"Sphere @:{_center.ToString("f2")} r = {_radius.ToString("f2")}, Area {Area}";
    }

}


