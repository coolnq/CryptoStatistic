using System.Collections.Generic;
using System.Linq;
using CryptoStatistic.Objects.Data;

namespace CryptoStatistic.Managers
{
    public class RawIncomeManager : BaseManager
    {
        public RawIncomeManager(IEnumerable<RawIncomeObject> rawIncomes) : base(rawIncomes)
        {
        }

        public new IEnumerable<RawIncomeObject> GetAll()
        {
            return base.GetAll().Select(i => new RawIncomeObject(i.time, i.value));
        }

        public new RawIncomeObject GetRow(long unixTime)
        {
            var item = base.GetRow(unixTime);
            return new RawIncomeObject(item.time, item.value);
        }

        public new RawIncomeObject GetFirst()
        {
            var item = base.GetFirst();
            return new RawIncomeObject(item.time, item.value);
        }

        public new RawIncomeObject GetLast()
        {
            var item = base.GetLast();
            return new RawIncomeObject(item.time, item.value);
        }

        public new IEnumerable<RawIncomeObject> GetInvertSlice(long unixTime)
        {
            return base.GetInvertSlice(unixTime).Select(i => new RawIncomeObject(i.time, i.value));
        }
    }
}