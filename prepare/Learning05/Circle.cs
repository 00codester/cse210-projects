class Circle : Shape{
    double _radius;

    public Circle(string color, double radius){
        SetColor(color);
        _radius = radius;
    }

    public override double GetArea()
    {
        double area = 3.14 * (_radius * _radius);
        return area;
    }
}