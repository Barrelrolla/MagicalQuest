namespace GameLogic.Models
{
    using System;

    public static class RandomGenerator
    {
        public static int GenerateRandomNumber(int min, int max)
        {
            var random = new Random();
            return random.Next(min, max);
        }
    }
}
