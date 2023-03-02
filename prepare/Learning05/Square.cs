class Square : Shape{

    double _side;
    public Square(string color, double side){
        SetColor(color);
        _side = side;
    }

    public override double GetArea()
    {
        double area = _side * _side;
        return area;
    }

}