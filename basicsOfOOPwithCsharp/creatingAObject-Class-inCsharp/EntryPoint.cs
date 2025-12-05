using PointsAndLines;
class EntryPoint
{
    static void Main()
    {
        System.Console.WriteLine("Hello, World!");
        Point point = new Point(5, 10);

        Point point2 = new Point();
        point2.X= 69;

        System.Console.WriteLine("Point2 coordinate: " + point2.X);
        System.Console.WriteLine("Point1 coordinates: X = " + point.X + ", Y = " + point.Y);
    }
}