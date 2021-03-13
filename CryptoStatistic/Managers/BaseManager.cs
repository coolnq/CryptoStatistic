using System.Collections.Generic;
using System.Linq;
using CryptoStatistic.Helpers;
using CryptoStatistic.Objects.Data;

namespace CryptoStatistic.Managers
{
    public class BaseManager
    {
        protected List<ValueTimeObject> objects;

        public BaseManager(IEnumerable<ValueTimeObject> objects)
        {
            this.objects = new List<ValueTimeObject>();
            this.objects.AddRange(objects);
        }

        protected IEnumerable<ValueTimeObject> GetAll()
        {
            return objects.ToArray();
        }

        protected ValueTimeObject GetRow(long unixTime)
        {
            var lastData = new ValueTimeObject();
            if (objects.Count > 0)
            {
                lastData.value = objects[0].value;
                lastData.time = objects[0].time;

                for (var i = objects.Count - 1; i > -1; i--)
                {
                    if (unixTime == objects[i].time)
                    {
                        lastData.time = objects[i].time;
                        lastData.value = objects[i].value;
                        return lastData;
                    }

                    if (objects[i].time < unixTime && lastData.time > unixTime)
                    {
                        lastData.value = IncomeHelper.Interpolate(unixTime, objects[i],
                            new ValueTimeObject(lastData.time, lastData.value));
                        lastData.time = unixTime;
                        return lastData;
                    }

                    lastData.time = objects[i].time;
                    lastData.value = objects[i].value;
                }
            }

            lastData.time = 0;
            lastData.value = 0;
            return lastData;
        }

        protected ValueTimeObject GetFirst()
        {
            return objects.Count > 0 ? objects.First() : new ValueTimeObject();
        }

        protected ValueTimeObject GetLast()
        {
            return objects.Count > 0 ? objects.Last() : new ValueTimeObject();
        }

        protected IEnumerable<ValueTimeObject> GetInvertSlice(long unixTime)
        {
            var incomeSlice = new List<ValueTimeObject>();
            for (var i = objects.Count - 1; i > -1; i--)
            {
                if (unixTime > objects[i].time)
                {
                    break;
                }

                incomeSlice.Add(objects[i]);
            }

            incomeSlice.Reverse();
            return incomeSlice.ToArray();
        }

        protected ValueTimeObject GetPenultimate()
        {
            return GetRowWithInvertOffset(1);
        }

        private ValueTimeObject GetRowWithInvertOffset(int offset)
        {
            var index = objects.Count - offset;
            return index > 0 ? objects[index - 1] : new ValueTimeObject();
        }
    }
}