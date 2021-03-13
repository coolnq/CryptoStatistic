using System.Collections.Generic;
using System.Linq;
using CryptoStatistic.Managers;
using CryptoStatistic.Objects.Data;
using CryptoStatistic.Provider;
using CryptoStatistic.Repositories;

namespace CryptoStatistic.Services
{
    public class IncomeService
    {
        private BaseDataProvider dataProvider;
        private readonly IncomeDataRepository incomeRepository;
        private readonly PaymentRepository paymentRepository;

        public IncomeService(BaseDataProvider webDataDataProvider)
        {
            dataProvider = webDataDataProvider;
            incomeRepository = new IncomeDataRepository();
            paymentRepository = new PaymentRepository();
        }

        public void ChangeProvider(BaseDataProvider provider)
        {
            dataProvider = provider;
        }

        public DayIncomeManager GetDayIncomeManager()
        {
            return new DayIncomeManager(GetIncomes());
        }

        public PaymentManager GetPaymentManager()
        {
            return new PaymentManager(GetPayments());
        }

        public RawIncomeManager GetRawIncomeManager()
        {
            return new RawIncomeManager(dataProvider.GetRawIncomes());
        }

        private IEnumerable<DayIncomeObject> GetIncomes()
        {
            var allIncome = incomeRepository.GetIncomes().ToList();
            var lastTime = allIncome.Any() ? allIncome.Last().time : 0;
            allIncome.AddRange(dataProvider.GetDayIncomes().ToList().FindAll(i => i.time > lastTime));
            return allIncome;
        }

        private IEnumerable<PaymentObject> GetPayments()
        {
            var allIncome = paymentRepository.GetPayments().ToList();
            var lastTime = allIncome.Any() ? allIncome.Last().time : 0;
            allIncome.AddRange(dataProvider.GetPayments().ToList().FindAll(i => i.time > lastTime));
            return allIncome;
        }

        public void SaveIncomes(IEnumerable<DayIncomeObject> objects)
        {
            incomeRepository.SaveIncomes(objects);
        }

        public void SavePayments(IEnumerable<PaymentObject> objects)
        {
            paymentRepository.SavePayments(objects);
        }

        public void refreshData()
        {
            dataProvider.Update();
        }

        /* public override IncomeRow[] GetNewDayIncomes()
         {
             var income = new List<IncomeRow>();
             income.AddRange(dayIncome.Skip(lastIncomeIndex));
 
             return income.ToArray();
         }*/
    }
}