using System.Numerics;
// -------------------------------

namespace ShapesLibary
{
    public class Cuboid : Shape3D
    {
        private Vector3 _center;
        private Vector3 _size;

        

        public Cuboid(Vector3 center, Vector3 size)
        {
            _center = center;
            _size = size;
        }

        public Cuboid(Vector3 center, float width)
        {
            _center = center;
            _size = new Vector3(width,width,width);
        }

        public bool IsCube
        {
            get { return _size.X == _size.Y && _size.X == _size.Z; }
        }

        public override Vector3 Center => new Vector3(Center.X, Center.Y, Center.Z);

        public override float Area => 2 * (_size.X * _size.Y + _size.X * _size.Z + _size.Y * _size.Z);

        public override float Volume => (_size.X * _size.Y * _size.Z);

        

        public override string ToString()
        {
            return IsCube? $"Cube @:{_center.ToString("f2")} w , h & l = {_size.X.ToString("f2")} Area : {Area}" :
                $"Cuboid @:{_center.ToString("f2")} w = {_size.X.ToString("f2")} h = {_size.Y.ToString("f2")} l = {_size.Z.ToString("f2")}, Area {Area}";
        }
      }

}


