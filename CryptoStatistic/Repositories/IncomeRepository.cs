using System.Collections.Generic;
using System.IO;
using System.Linq;
using CryptoStatistic.Objects.Data;

namespace CryptoStatistic.Repositories
{
    public class IncomeDataRepository
    {
        public IEnumerable<DayIncomeObject> GetIncomes()
        {
            var incomes = new List<DayIncomeObject>();
            using (var fs = new FileStream("./Data/incomes.idat", FileMode.OpenOrCreate))
            {
                if (fs.Length > 0)
                {
                    var br = new BinaryReader(fs);
                    var count = br.ReadInt32();
                    for (var i = 0; i < count; i++)
                    {
                        var income = new DayIncomeObject();
                        income.time = br.ReadInt64();
                        income.value = br.ReadDouble();
                        incomes.Add(income);
                    }
                }
            }

            return incomes.ToArray();
        }

        public void SaveIncomes(IEnumerable<DayIncomeObject> rows)
        {
            using (var fs = new FileStream("./Data/incomes.idat", FileMode.OpenOrCreate))
            {
                var bw = new BinaryWriter(fs);
                bw.Write(rows.Count());
                foreach (var row in rows)
                {
                    bw.Write(row.time);
                    bw.Write(row.value);
                }

                bw.Flush();
            }
        }
    }
}