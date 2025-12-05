using PointsAndLines;
class EntryPoint
{
    static void Main()
    {
        System.Console.WriteLine("Hello, World!");
        Point point = new Point(5, 10);

        System.Console.WriteLine("Only Point X coordinate: " + point.X);
        System.Console.WriteLine("ALL Point coordinates: X = " + point.X + ", Y = " + point.Y);
    }
}