namespace CryptoStatistic.Objects.Data
{
    public class ValueTimeObject
    {
        public ValueTimeObject()
        {
            time = 0;
            value = 0.0;
        }

        public ValueTimeObject(long t, double v)
        {
            time = t;
            value = v;
        }

        public long time { get; set; }
        public double value { get; set; }
    }
}