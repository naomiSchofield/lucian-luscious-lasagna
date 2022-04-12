using System;

    class Lasagna
    {
        public int ExpectedMinutesInOven()
        {
            return 40;
        }

        public int RemainingMinutesInOven(int i)
        {
            var expectedMinutes = ExpectedMinutesInOven();
            var remainingMinutes = expectedMinutes - i;
            return remainingMinutes;
        }

        public int PreparationTimeInMinutes(int i)
        {
            var layers = i;
            var prepTime = layers * 2;
            return prepTime;
        }

        public int ElapsedTimeInMinutes(int i, int i1)
        {
            var prepTime = PreparationTimeInMinutes(i);
           return prepTime + i1;
        }
    }

