namespace CryptoStatistic.Objects.Data
{
    public class RawIncomeObject : ValueTimeObject
    {
        public RawIncomeObject()
        {
            time = 0;
            value = 0.0;
            isPayment = false;
        }

        public RawIncomeObject(long t, double a) : base(t, a)
        {
        }

        public RawIncomeObject(long t, double a, bool p)
        {
            time = t;
            value = a;
            isPayment = p;
        }

        public bool isPayment { get; set; }
    }
}