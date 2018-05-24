using System;

namespace RobHaleVt.TestCore
{
    public class BaseTestFixture
    {
        private Random _random;

        public Random Random => _random ?? (_random = new Random(DateTime.Now.Millisecond));
    }
}
