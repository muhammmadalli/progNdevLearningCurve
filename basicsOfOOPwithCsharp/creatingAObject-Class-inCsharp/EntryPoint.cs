using PointsAndLines;
class EntryPoint
{
    static void Main()
    {
        System.Console.WriteLine("Hello, World!");
        Point point = new Point(5, 10);

        Point point2 = new Point();

        System.Console.WriteLine("Point1 coordinate: " + point.X);
        System.Console.WriteLine("Point2 coordinates: X = " + point.X + ", Y = " + point.Y);
    }
}