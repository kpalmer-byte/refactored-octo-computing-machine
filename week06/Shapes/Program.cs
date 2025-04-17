using System;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square("red", 10);

        string square_color = square.GetColor();
        double square_area = square.GetArea();

        Console.WriteLine($"Square Color: {square_color}");
        Console.WriteLine($"Square Area: {square_area}");

        Rectangle rectangle = new Rectangle("yellow", 10, 4);

        string rectangle_color = rectangle.GetColor();
        double rectangle_area = rectangle.GetArea();

        Console.WriteLine($"Rectangle Color: {rectangle_color}");
        Console.WriteLine($"Rectangle Area: {rectangle_area}");

        Circle circle = new Circle("pink", 2);

        string circle_color = circle.GetColor();
        double circle_area = circle.GetArea();

        Console.WriteLine($"Circle Color: {circle_color}");
        Console.WriteLine($"Circle Area: {circle_area}");
    }
}