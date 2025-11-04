Console.WriteLine("Task2 : Constants");
class Circle
{
    // Declare a constant variable
    public const double PI = 3.14;

    // Method to calculate area
    public static double GetArea(double radius)
    {
        return PI * radius * radius;
    }

    // Method to calculate perimeter
    public static double GetPerimeter(double radius)
    {
        return 2 * PI * radius;
    }
    class Program
    {
        static void Main()
        {
            // Try to modify the constant (This will cause a compilation error)
            //Circle.PI = 3.14159;   //   error CS0131: The left-hand side of an assignment must be a variable, property or indexer [D:\Application Development\Workshop2\Task2\Task2.csproj]
            Circle c = new Circle();
            double radius = 7;

            Console.WriteLine($"Area of Circle: {Circle.GetArea(radius)}");
            Console.WriteLine($"Perimeter of Circle: {Circle.GetPerimeter(radius)}");
        }
    }
}