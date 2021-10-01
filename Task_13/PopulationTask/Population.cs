using System;

namespace PopulationTask
{
    public static class Population
    {
        public static int GetYears(int initialPopulation, double percent, int visitors, int currentPopulation)
        {
            if (initialPopulation <= 0)
            {
                throw new ArgumentException("invalid argument", nameof(initialPopulation));
            }

            if (visitors < 0)
            {
                throw new ArgumentException("invalid argument", nameof(visitors));
            }

            if (currentPopulation <= 0)
            {
                throw new ArgumentException("invalid argument", nameof(currentPopulation));
            }

            if (currentPopulation < initialPopulation)
            {
                throw new ArgumentException("invalid argument", nameof(currentPopulation));
            }

            if (percent < 0 || percent > 100)
            {
                throw new ArgumentOutOfRangeException(nameof(percent), "invalid argument");
            }

            var doubleInitialPopulation = Convert.ToDouble(initialPopulation);
            int counter = 0;

            while (doubleInitialPopulation <= currentPopulation)
            {
                doubleInitialPopulation += visitors + (doubleInitialPopulation * percent / 100);
                counter++;
            }

            return counter;
        }
    }
}
