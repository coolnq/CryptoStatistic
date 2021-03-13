using System.Collections.Generic;
using System.Linq;
using CryptoStatistic.Objects.Data;

namespace CryptoStatistic.Managers
{
    public class DayIncomeManager : BaseManager
    {
        public DayIncomeManager(IEnumerable<DayIncomeObject> objects) : base(objects)
        {
        }

        public new IEnumerable<DayIncomeObject> GetAll()
        {
            return base.GetAll().Select(i => new DayIncomeObject(i.time, i.value));
        }

        public new DayIncomeObject GetRow(long unixTime)
        {
            var item = base.GetRow(unixTime);
            return new DayIncomeObject(item.time, item.value);
        }

        public new IEnumerable<DayIncomeObject> GetInvertSlice(long unixTime)
        {
            return base.GetInvertSlice(unixTime).Select(i => new DayIncomeObject(i.time, i.value));
        }

        public new RawIncomeObject GetLast()
        {
            var item = base.GetLast();
            return new RawIncomeObject(item.time, item.value);
        }

        public new DayIncomeObject GetPenultimate()
        {
            var item = base.GetPenultimate();
            return new DayIncomeObject(item.time, item.value);
        }

        public double GetIncome(int days)
        {
            var sum = 0.0;
            if (days > 0)
            {
                var index = objects.Count >= days ? objects.Count - days : objects.Count;
                for (var i = index; i < objects.Count; i++)
                {
                    sum += objects[i].value;
                }
            }

            return sum;
        }
    }
}