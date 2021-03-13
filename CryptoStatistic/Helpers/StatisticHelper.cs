using System.Collections.Generic;
using System.Linq;

namespace CryptoStatistic.Helpers
{
    public static class StatisticHelper
    {
        public static double GetMedianSpeed(double[] data, int duration)
        {
            return GetAverageSpeed(GetMedianIncome(data), duration);
        }

        public static double GetAverageSpeed(double[] data, int duration)
        {
            var aver = 0.0;
            if (data.Count() > 0)
            {
                for (var i = 0; i < data.Length - 1; i++)
                {
                    aver += data[i + 1] - data[i];
                }

                var raz = data.Last() - data.First();

                aver /= data.Length;
                aver *= duration / 300; // 300 секунд - шаг в данных
            }

            return aver;
        }

        private static double[] GetMedianIncome(double[] data)
        {
            var dataArray = data.ToList();
            var count = dataArray.Count;
            if (count > 0)
            {
                var all = new double[count];
                dataArray.Insert(0, dataArray[0]);
                dataArray.Insert(count - 1, dataArray[count - 1]);

                for (var i = 0; i < count; i++)
                {
                    var mass = new List<double>();
                    for (var ii = i; ii < i + 3; ii++)
                    {
                        mass.Add(dataArray[ii]);
                    }

                    mass.Sort();
                    all[i] = mass[1];
                    dataArray[i] = mass[1];
                }

                dataArray.RemoveRange(count, 2);
            }

            return dataArray.ToArray();
        }

        public static double GetGlobalTrend(double[] incomes)
        {
            var percents = new List<double>();
            if (incomes.Count() > 1)
            {
                for (var i = 1; i < incomes.Count(); i++)
                {
                    percents.Add((incomes[i] / incomes[i-1]) * 100 - 100);
                }
            }

            return percents.Sum() / percents.Count();
        }
    }
}