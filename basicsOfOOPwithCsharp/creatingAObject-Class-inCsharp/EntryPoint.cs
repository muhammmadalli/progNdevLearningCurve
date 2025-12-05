using PointsAndLines;
class EntryPoint
{
    static void Main()
    {
        System.Console.WriteLine("Hello, World!");
        Point point = new Point();
    
        point.X = 5;
        System.Console.WriteLine("Only Point X coordinate: " + point.X);
        point.Y = 20;
        System.Console.WriteLine("ALL Point coordinates: X = " + point.X + ", Y = " + point.Y);
    }
}