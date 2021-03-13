using System.Linq;
using CryptoStatistic.Helpers;
using CryptoStatistic.Managers;

namespace CryptoStatistic.Objects
{
    public class StatisticObject
    {
        //private double dayBalance;
        private double dayIncome;
        private double dayTrend;
        private double dayAver;
        private double dayExpected;
        private double weekIncome;
        private double weekTrend;
        private double weekAver;
        private double weekExpected;
        private double totalIncome;
        private double totalTrend;

        private DayIncomeManager manager;
        private RawIncomeManager rawManager;

        public StatisticObject(DayIncomeManager manager, RawIncomeManager rawManager)
        {
            this.manager = manager;
            this.rawManager = rawManager;
        }

        public double GetDayIncome()
        {
            return dayIncome;
        }

        public double getDayTrend()
        {
            return dayTrend;
        }

        public double getDayAver()
        {
            return dayAver;
        }

        public double getDayExpected()
        {
            return dayExpected;
        }

        public double getWeekIncome()
        {
            return weekIncome;
        }

        public double getWeekTrend()
        {
            return weekTrend;
        }

        public double getWeekAver()
        {
            return weekAver;
        }

        public double getWeekExpected()
        {
            return weekExpected;
        }

        public double getTotalIncome()
        {
            return totalIncome;
        }

        public double getTotalTrend()
        {
            return totalTrend;
        }

        public void Update()
        {
            var lastRawIncomeTime = rawManager.GetLast().time;
            ////Day Start////
            var currentDay = UnixTimeHelper.GetCurrentDay();
            dayIncome = rawManager.GetLast().value - rawManager.GetRow(currentDay).value;
            var recentIncome = manager.GetLast().value;
            var penultimateIncome = manager.GetPenultimate().value;
            dayTrend = recentIncome / penultimateIncome - 1;

            var lastDayIncomeArray = rawManager.GetInvertSlice(lastRawIncomeTime - 86400);
            var lastDayAmountArray = lastDayIncomeArray.Select(r => r.value).ToArray();
            dayAver = StatisticHelper.GetAverageSpeed(lastDayAmountArray, 86400);
            dayExpected = StatisticHelper.GetMedianSpeed(lastDayAmountArray, 86400);
            ////Day End////

            ////Week Start////
            var weekDayIncome = manager.GetIncome(7);
            weekIncome = weekDayIncome;
            var twoWeekDayIncome = manager.GetIncome(14);
            var weeksDiff = twoWeekDayIncome - weekDayIncome;
            weekTrend = (weeksDiff > 0) ? weekDayIncome / weeksDiff - 1 : 0.0;

            var weekIncomeArray = rawManager.GetInvertSlice(lastRawIncomeTime - 604800);
            var weekIncomeAmountArray = weekIncomeArray.Select(r => r.value).ToArray();
            weekAver = StatisticHelper.GetAverageSpeed(weekIncomeAmountArray, 604800);
            weekExpected = StatisticHelper.GetMedianSpeed(weekIncomeAmountArray, 604800);
            ////Week End////

            ////Total Start////
            var allIncome = manager.GetAll().Select(d => d.value);
            totalIncome = allIncome.Sum();
            totalTrend = StatisticHelper.GetGlobalTrend(allIncome.ToArray());
            ////Total End////
        }
    }
}