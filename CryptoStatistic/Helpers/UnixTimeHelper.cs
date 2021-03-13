using System;

namespace CryptoStatistic.Helpers
{
    public static class UnixTimeHelper
    {
        public static long GetCurrentDay()
        {
            return (long) Convert(DateTime.Today);
        }

        public static long GetCurrentTime()
        {
            return (long) Convert(DateTime.Now);
        }

        public static DateTime UnixTimeToDateTime(double unixTime)
        {
            DateTime epoch = new DateTime(1970, 1, 1, 0, 0, 0, 0).ToLocalTime();
            return epoch.AddSeconds(unixTime);
        }

        public static double Convert(DateTime dateTime)
        {
            DateTime epoch = new DateTime(1970, 1, 1, 0, 0, 0, 0).ToLocalTime();
            TimeSpan span = (dateTime.ToLocalTime() - epoch);
            return span.TotalSeconds;
        }
    }
}