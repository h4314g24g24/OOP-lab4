using System;


namespace OOp4
{
    public static class CoordinateSystem
    {
        public static string DetermineQuarter(Point point)
        {
            if (point.X > 0 && point.Y > 0)
                return "I чверть";
            else if (point.X < 0 && point.Y > 0)
                return "II чверть";
            else if (point.X < 0 && point.Y < 0)
                return "III чверть";
            else if (point.X > 0 && point.Y < 0)
                return "IV чверть";
            else if (point.X == 0 && point.Y == 0)
                return " точика знаходиться на перетині осей ";
            else
                return "Точка знаходиться на осі";

        }
    }
}
