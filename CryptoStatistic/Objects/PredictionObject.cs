using System.Linq;
using CryptoStatistic.Helpers;
using CryptoStatistic.Managers;

namespace CryptoStatistic.Objects
{
    public class PredictionObject
    {
        private double fullDayAverage;
        private double fullDayMedian;
        private double hourDayAverage;
        private double hourDayMedian;
        private double fullWeekAverage;
        private double fullWeekMedian;
        private double hourWeekAverage;
        private double hourWeekMedian;
        private double fullMonthAverage;
        private double fullMonthMedian;
        private double hourMonthAverage;
        private double hourMonthMedian;

        private DayIncomeManager manager;
        private RawIncomeManager rawManager;

        public PredictionObject(DayIncomeManager manager, RawIncomeManager rawManager)
        {
            this.manager = manager;
            this.rawManager = rawManager;
        }

        public double GetFullDayAverage()
        {
            return fullDayAverage;
        }

        public double GetFullDayMedian()
        {
            return fullDayMedian;
        }

        public double GetHourDayAverage()
        {
            return hourDayAverage;
        }

        public double GetHourDayMedian()
        {
            return hourDayMedian;
        }

        public double GetFullWeekAverage()
        {
            return fullWeekAverage;
        }

        public double GetFullWeekMedian()
        {
            return fullWeekMedian;
        }

        public double GetHourWeekAverage()
        {
            return hourWeekAverage;
        }

        public double GetHourWeekMedian()
        {
            return hourWeekMedian;
        }

        public double GetFullMonthAverage()
        {
            return fullMonthAverage;
        }

        public double GetFullMonthMedian()
        {
            return fullMonthMedian;
        }

        public double GetHourMonthAverage()
        {
            return hourMonthAverage;
        }

        public double GetHourMonthMedian()
        {
            return hourMonthMedian;
        }

        public void Update()
        {
            var lastRawIncomeTime = rawManager.GetLast().time;
            var hourIncomeArray = rawManager.GetInvertSlice(lastRawIncomeTime - 3600);
            var hourIncomeAmountArray = hourIncomeArray.Select(r => r.value).ToArray();

            ////Day Start////
            var dayIncomeArray = rawManager.GetInvertSlice(lastRawIncomeTime - 86400);
            var dayIncomeAmountArray = dayIncomeArray.Select(r => r.value).ToArray();

            fullDayAverage = StatisticHelper.GetAverageSpeed(dayIncomeAmountArray, 86400);
            fullDayMedian = StatisticHelper.GetMedianSpeed(dayIncomeAmountArray, 86400);
            hourDayAverage = StatisticHelper.GetAverageSpeed(hourIncomeAmountArray, 86400);
            hourDayMedian = StatisticHelper.GetMedianSpeed(hourIncomeAmountArray, 86400);
            ////Day End////

            ////Week Start////
            var weekIncomeArray = rawManager.GetInvertSlice(lastRawIncomeTime - 604800);
            var weekIncomeAmountArray = weekIncomeArray.Select(r => r.value).ToArray();

            fullWeekAverage = StatisticHelper.GetAverageSpeed(weekIncomeAmountArray, 604800);
            fullWeekMedian = StatisticHelper.GetMedianSpeed(weekIncomeAmountArray, 604800);
            hourWeekAverage = StatisticHelper.GetAverageSpeed(hourIncomeAmountArray, 604800);
            hourWeekMedian = StatisticHelper.GetMedianSpeed(hourIncomeAmountArray, 604800);
            ////Week End////

            ////Month Start////
            var monthIncomeArray = manager.GetInvertSlice(lastRawIncomeTime - 2629743);
            if (monthIncomeArray.Count() > 27)
            {
                var monthIncomeAmountArray = monthIncomeArray.Select(r => r.value).ToArray();
                fullMonthAverage = StatisticHelper.GetAverageSpeed(monthIncomeAmountArray, 2629743);
                fullMonthMedian = StatisticHelper.GetMedianSpeed(monthIncomeAmountArray, 2629743);
            }

            hourMonthAverage = StatisticHelper.GetAverageSpeed(hourIncomeAmountArray, 2629743);
            hourMonthMedian = StatisticHelper.GetMedianSpeed(hourIncomeAmountArray, 2629743);
            ////Month End////
        }
    }
}