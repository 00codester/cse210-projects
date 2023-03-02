class Rectangle : Shape{
    double _length;
    double _width;

    public Rectangle(string color, double length, double width){
        SetColor(color);
        _length = length;
        _width = width;
    }

    public override double GetArea(){
        double area = _length * _width;
        return area;
    }
}