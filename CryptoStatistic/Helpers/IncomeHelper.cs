using CryptoStatistic.Objects.Data;

namespace CryptoStatistic.Helpers
{
    public static class IncomeHelper
    {
        public static double Interpolate(long f, ValueTimeObject si, ValueTimeObject ei)
        {
            return si.value + (ei.value - si.value) / (ei.time - si.time) * (f - si.time);
        }
    }
}