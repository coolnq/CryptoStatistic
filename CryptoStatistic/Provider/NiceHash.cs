using System;
using System.Collections.Generic;
using CryptoStatistic.Helpers;
using CryptoStatistic.Managers;
using CryptoStatistic.Objects.Data;
using CryptoStatistic.Web;

namespace CryptoStatistic.Provider
{
    public class NiceHash : BaseDataProvider
    {
        private string userKey;
        private string url;
        private double balance;
        private double paid;

        public NiceHash(string userKey)
        {
            providerName = "NiceHash";
            this.userKey = userKey;
            url = "https://api2.nicehash.com/main/api/v2/";
        }

        public override double GetBalance()
        {
            return balance;
        }

        public override double GetTotalBalance()
        {
            return paid;
        }

        protected override IEnumerable<RawIncomeObject> GetRawData()
        {
            var client = new StandardClient();
            var rawIncomes = new List<RawIncomeObject>();
            //?afterTimestamp=1614200400000
            var json = client.Execute(url + "mining/external/" + userKey + "/rigs/stats/unpaid");
            if (json.Length == 0)
            {
                return rawIncomes.ToArray();
            }

            dynamic obj = Newtonsoft.Json.JsonConvert.DeserializeObject(json);
            var data = obj.data.ToObject<object[]>();

            long lastTime = 0;
            var lastAmount = 0.0;
            var lastLocalAmount = 0.0;
            Array.Reverse(data);
            foreach (var rows in data)
            {
                var localTime = (long) rows[0] / 1000;
                var localAmount = (double) rows[2];
                if (lastTime < localTime)
                {
                    if (lastLocalAmount > localAmount)
                    {
                        lastAmount += lastLocalAmount;
                        payments.Add(new PaymentObject(lastTime, lastLocalAmount));
                    }

                    rawIncomes.Add(new RawIncomeObject((long) rows[0] / 1000, lastAmount + localAmount));
                }

                lastTime = localTime;
                lastLocalAmount = localAmount;
            }

            balance = lastLocalAmount;
            paid = lastAmount + lastLocalAmount;
            return rawIncomes.ToArray();
        }

        //income processing 
        protected override IEnumerable<DayIncomeObject> ConvertRawData(RawIncomeManager incomeManager)
        {
            var lastIncome = 0.0;
            var incomes = new List<DayIncomeObject>();

            var startTime = UnixTimeHelper.GetCurrentDay();

            while (true)
            {
                var rawIncome = incomeManager.GetRow(startTime);
                var income = new DayIncomeObject(rawIncome.time, rawIncome.value);
                if (income.time == 0)
                {
                    break;
                }

                if (lastIncome > 0)
                {
                    income.value = lastIncome - income.value;
                    incomes.Add(income);
                    lastIncome -= income.value;
                }
                else
                {
                    lastIncome = income.value;
                }

                startTime -= 86400;
            }

            incomes.Reverse();
            return incomes.ToArray();
        }
    }
}