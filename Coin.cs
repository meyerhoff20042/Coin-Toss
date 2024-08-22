using System;

namespace Tutorial_5_8_Coin_Toss
{
    public static class Coin
    {
        //=========================================================================WIP================================================================================================//
        // Coin Counters
        private static int _sideUp;
        private static int _headsTotal;
        private static int _tailsTotal;
        private static int _totalTosses;

        public static void FlipCoin()
        {
            Random rand = new Random();
            
            // Get a random integer in the range of 0 through 1.
            // 0 means tails up, 1 means heads up.
            _sideUp = rand.Next(2);

            // Display the side that is up.
            if (_sideUp == 0)
            {
                // Add one to tailsTotal
                _tailsTotal++;
            }
            else
            {
                // Add one to headsTotal
                _headsTotal++;
            }

            _totalTosses++;
        }

        public static void Reset()
        {
            _sideUp = 0;
            _headsTotal = 0;
            _tailsTotal = 0;
            _totalTosses = 0;
        }
    }
}
