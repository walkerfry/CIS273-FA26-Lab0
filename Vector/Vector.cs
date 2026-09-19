namespace Vector;

public struct Vector
{

    public Vector(double x, double y)
    {
        X = x;
        Y = y;
    }
    

    public double X { get; set; }
    public double Y { get; set; }

    public double Magnitude => Math.Sqrt(X*X + Y*Y);
    
    public double Direction => Math.Atan2(Y, X) * 180/Math.PI;

    //METHODS

    //Instance Methods

    public Vector Add(Vector v)
    {
        Vector result = new Vector();
        result.X = this.X + v.X;
        result.Y = this.Y + v.Y;
        return result;
    }

    public Vector Subtract(Vector v)
    {
        Vector result = new Vector();
        result.X = this.X - v.X;
        result.Y = this.Y - v.Y;
        return result;
    }

    public double Dot(Vector v)
    {
        return this.X * v.X + this.Y * v.Y;
    }

    public double AngleBetween(Vector v)
    {
        double dot = this.Dot(v);
        double magnitudes = this.Magnitude * v.Magnitude;
        return Math.Acos(dot / magnitudes) * 180 / Math.PI;
    }

    public Vector Multiply(double scalar)
    {
        Vector result = new Vector();
        result.X = this.X * scalar;
        result.Y = this.Y * scalar;
        return result;
    }

    public Vector Divide(double scalar)
    {
        Vector result = new Vector();
        result.X = this.X / scalar;
        result.Y = this.Y / scalar;
        return result;
    }

    public Vector Normalize()
    {
        return this.Divide(this.Magnitude);
    }

    public override string ToString()
    {
        return $"<{X}, {Y}>";
    }

    //Static Methods

    public static Vector Add(Vector v1, Vector v2)
    {
        return v1.Add(v2);
    }

    public static Vector Subtract(Vector v1, Vector v2)
    {
        return v1.Subtract(v2);
    }

    public static double Dot(Vector v1, Vector v2)
    {
        return v1.Dot(v2);
    }

    public static double AngleBetween(Vector v1, Vector v2)
    {
        return v1.AngleBetween(v2);
    }

    public static Vector Multiply(Vector v, double scalar)
    {
        return v.Multiply(scalar);
    }

    public static Vector Divide(Vector v, double scalar)
    {
        return v.Divide(scalar);
    }

    public static Vector Normalize(Vector v)
    {
        return v.Normalize();
    }

    //Operators
    
    public static Vector operator +(Vector v1, Vector v2)
    {
        return Vector.Add(v1,v2);
    }

    public static Vector operator -(Vector v1, Vector v2)
    {
        return Vector.Subtract(v1,v2);
    }

    public static double operator *(Vector v1, Vector v2)
    {
        return Vector.Dot(v1,v2);
    }

    public static Vector operator *(Vector v, double scalar)
    {
        return Vector.Multiply(v, scalar);
    }

    public static Vector operator /(Vector v, double scalar)
    {
        return Vector.Divide(v, scalar);
    }
}
