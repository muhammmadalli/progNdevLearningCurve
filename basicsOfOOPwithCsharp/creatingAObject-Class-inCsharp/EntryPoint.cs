class Point
{
    public int X;
    public int Y;
}


class EntryPoint
{
    static void Main()
    {
        System.Console.WriteLine("Hello, World!");
        Point point = new Point();
    
        point.X = 5;
        System.Console.WriteLine("Point X coordinate: " + point.X);
        point.Y = 20;
        System.Console.WriteLine("Point coordinates: X = " + point.X + ", Y = " + point.Y);
    }
}