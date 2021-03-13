using System.Collections.Generic;
using System.IO;
using System.Linq;
using CryptoStatistic.Objects.Data;

namespace CryptoStatistic.Repositories
{
    public class PaymentRepository
    {
        public IEnumerable<PaymentObject> GetPayments()
        {
            var payments = new List<PaymentObject>();
            using (var fs = new FileStream("./Data/payments.pdat", FileMode.OpenOrCreate))
            {
                if (fs.Length > 0)
                {
                    var br = new BinaryReader(fs);
                    var count = br.ReadInt32();
                    for (var i = 0; i < count; i++)
                    {
                        var payment = new PaymentObject();
                        payment.time = br.ReadInt64();
                        payment.value = br.ReadDouble();
                        payments.Add(payment);
                    }
                }
            }

            return payments.ToArray();
        }

        public void SavePayments(IEnumerable<PaymentObject> rows)
        {
            using (var fs = new FileStream("./Data/payments.pdat", FileMode.OpenOrCreate))
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