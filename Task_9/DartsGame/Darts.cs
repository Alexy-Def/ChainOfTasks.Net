using System;

namespace DartsGame
{
    public static class Darts
    {
        public static int GetScore(double x, double y)
        {
            double yourRadius = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));

            if (yourRadius > 10)
            {
                return 0;
            }
            else if (yourRadius <= 1)
            {
                return 10;
            }
            else if (yourRadius <= 5)
            {
                return 5;
            }
            else
            {
                return 1;
            }
        }
    }
}
