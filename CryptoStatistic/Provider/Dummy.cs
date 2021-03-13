using System.Collections.Generic;
using CryptoStatistic.Managers;
using CryptoStatistic.Objects.Data;

namespace CryptoStatistic.Provider
{
    public class Dummy : BaseDataProvider
    {
        protected override IEnumerable<RawIncomeObject> GetRawData()
        {
            return new RawIncomeObject[0];
        }

        protected override IEnumerable<DayIncomeObject> ConvertRawData(RawIncomeManager incomeManager)
        {
            return new DayIncomeObject[0];
        }
    }
}