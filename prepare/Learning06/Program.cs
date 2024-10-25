using System;
using System.Reflection.Metadata.Ecma335;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning06 World!");

        List<Shape> shapes = new List<Shape>();

        Square shape1 = new Square("Red",3);
        shapes.Add(shape1);

        Rectangle shape2 = new Rectangle("Blue",4,7);
        shapes.Add(shape2);

        Circle shape3 = new Circle("Yellow",9);
        shapes.Add(shape3);

        foreach (Shape shape in shapes)
            {
                string specificColor = shape.GetColor();

                double area = shape.GetArea();

                Console.WriteLine($"The {specificColor} shape has an area of {area}");
            }




    }
}