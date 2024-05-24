using System;

namespace Dependency_Injections_.Repository
{
    public class RandomNumberGen: IRandomNumberGen
    {
        private readonly Random random;
        public RandomNumberGen()
        {
           var random = new Random();
            this.random = random;
        }
        public int GetRandomNumber()
        {
            
            return random.Next(1,100);
        }
    }
}
