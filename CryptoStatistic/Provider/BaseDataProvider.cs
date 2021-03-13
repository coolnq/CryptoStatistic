using System.Collections.Generic;
using System.Linq;
using CryptoStatistic.Managers;
using CryptoStatistic.Objects.Data;

namespace CryptoStatistic.Provider
{
    public abstract class BaseDataProvider
    {
        protected string providerName;
        private IEnumerable<DayIncomeObject> dayIncomes;
        private IEnumerable<RawIncomeObject> rawIncomes;
        protected List<PaymentObject> payments = new List<PaymentObject>();

        public virtual double GetBalance()
        {
            return 0.0;
        }

        public virtual double GetTotalBalance()
        {
            return 0.0;
        }

        public IEnumerable<PaymentObject> GetPayments()
        {
            return payments;
        }

        public IEnumerable<DayIncomeObject> GetDayIncomes()
        {
            return dayIncomes;
        }

        public IEnumerable<RawIncomeObject> GetRawIncomes()
        {
            return rawIncomes;
        }

        protected abstract IEnumerable<RawIncomeObject> GetRawData();

        protected abstract IEnumerable<DayIncomeObject> ConvertRawData(RawIncomeManager incomeManager);

        public void Update()
        {
            var rawIncomes = GetRawData();
            var manager = new RawIncomeManager(rawIncomes);
            dayIncomes = ConvertRawData(manager);
            this.rawIncomes = rawIncomes.ToArray();
        }
    }
}