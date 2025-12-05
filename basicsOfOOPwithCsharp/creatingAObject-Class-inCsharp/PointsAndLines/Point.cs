namespace PointsAndLines
{
    class Point
    {
        public int x;
        public int y;

        public Point()
            {
        
        }
        
        public Point(int x, int y)
            {
            // Adding this. to distinguish between class fields and constructor parameters. .this makes it explicit that we are referring to the class fields.
            // Without this., the assignment would be ambiguous, as both sides would refer to the constructor parameters.
            // we brought the constructor parameters into the class scope, so we need to use this. to refer to the class fields.
            // This is a common practice in C# to avoid naming conflicts and improve code readability.
            // class fields were changed to camelCase to follow C# naming conventions.
            // hence X was changed to x and Y was changed to y. in the class fields.

            this.x = x;
            this.y = y;
        }
    }
 }