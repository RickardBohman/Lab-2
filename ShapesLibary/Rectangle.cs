using ShapesLibary;
using System.Drawing;
using System.Numerics;

public class Rectangle : Shape2D
{

    private Vector2 _center;
    private Vector2 _size;
   

    public Rectangle(Vector2 center, Vector2 size)
    {
        _center = center;
        _size = size;
    }

    public Rectangle(Vector2 center, float width)
    {
        _center = center;
        _size = new Vector2(width,width);
    }

    public bool IsSquare
    {
        get { return _size.X == _size.Y; }
    }


    public override float Circumference => (_size.X * _size.X) * (_size.Y * _size.Y);

    public override Vector3 Center => new Vector3(_size.X, _size.Y, 0);

    public override float Area => _size.X * _size.Y;

    public override string ToString()
    {
        return IsSquare ? $"Square @:{_center.ToString("f2")} w == h {_size.X.ToString("f2")}" :
            $"Rectangle @{ _center.ToString("f2")}: w = { _size.X.ToString("f2")} , h = { _size.Y.ToString("f2")}";
    }

        //$"Rectangle @{_center}: w = {_size.X} , h = {_size.Y} ";

    //public override string ToString() => $"Square @:{_center} w == h {_width}";
}
//Omkrets = 2a + 2b // x*x + y*y
//area = x * y
