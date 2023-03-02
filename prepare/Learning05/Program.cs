using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Learning05 World!");
        // Square square = new Square("red", 2);
        // string squolor = square.GetColor();
        // double squarea = square.GetArea();
        // Console.WriteLine($"{squolor}");
        // Console.WriteLine($"{squarea}");

        // Rectangle rec = new Rectangle("blue", 2,3);
        // string recColor = rec.GetColor();
        // double recArea = rec.GetArea();
        // Console.WriteLine(recColor);
        // Console.WriteLine(recArea);

        // Circle cir = new Circle("green", 2);
        // string cirColor = cir.GetColor();
        // double cirArea = cir.GetArea();
        // Console.WriteLine(cirColor);
        // Console.WriteLine(cirArea);

        List<Shape> shapes = new List<Shape>();

        shapes.Add(new Square("red", 2));
        shapes.Add(new Rectangle("blue", 3, 4));
        shapes.Add(new Circle("green", 3));

        foreach(Shape shape in shapes){
            // Console.WriteLine(shape.GetColor());
            // Console.WriteLine(shape.GetArea());

            string color = shape.GetColor();
            double area = shape.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}.");

        }
    }
}