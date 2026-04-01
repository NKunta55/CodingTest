using System;

namespace Prime.Services
{
    public class PrimeService
    {
        public bool IsPrime(int candidate)
        {
            if (candidate <= 1)
                return false;

            if (candidate == 2)
                return true;

            if (candidate % 2 == 0)
                return false;

            var limit = (int)Math.Sqrt(candidate);
            for (int i = 3; i <= limit; i += 2)
            {
                if (candidate % i == 0)
                    return false;
            }

            return true;
        }
    }
}