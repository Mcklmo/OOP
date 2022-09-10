namespace OOP
{
    class Vector
    {
        public Vector(double x, double y)
        {
            _x = x;
            _y = y;
        }
        double _x;
        double _y;
        public string GetVector()
        {
            return $"({_x},{_y})";
        }
        public Vector Add(Vector v1)
        {
            return new Vector(v1._x+_x,v1._y+_y);
        }
        public Vector Subtract(Vector v1)
        {
            return new Vector(_x-v1._x,_y-v1._y);
        }
        public Vector Scale(double x)
        {
            return new Vector(_x*x,_y*x);
        }
    }
}

