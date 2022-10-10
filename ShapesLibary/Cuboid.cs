using ShapesLibary;
using System.Numerics;
// -------------------------------

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

    public override float Volume => (((_size.Y / 2) * (_size.Y / 2)) * (float)Math.PI) * _size.X; 
    
    public override string ToString()
    {
        return IsCube? $"Cube @:{_center.ToString("f2")} w , h & l = {_size.X.ToString("f2")}" :
            $"Cuboid @:{_center.ToString("f2")} w = {_size.X.ToString("f2")} h = {_size.Y.ToString("f2")} l = {_size.Z.ToString("f2")}";
    }
  }
/*
 * Area =  2*(lw + wh + lh) || 2*(l*w + w*h + l*h)
“cuboid @(3.0, 4.0, 5.0): w = 4.0, h = 5.0, l=2.0
 * 
 * Volume = ((radius * radius) * pi * hight 
 */

// public override string ToString() => $"Cuboid @:{_center} w = {_size.X} h = {_size.Y} l = {_size.Z}";

//public override string ToString() => $"Cube @:{_center} w , h & l = {_width}";

