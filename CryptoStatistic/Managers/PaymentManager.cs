using System.Collections.Generic;
using System.Linq;
using CryptoStatistic.Objects.Data;

namespace CryptoStatistic.Managers
{
    public class PaymentManager : BaseManager
    {
        public PaymentManager(IEnumerable<PaymentObject> objects) : base(objects)
        {
        }

        public new IEnumerable<PaymentObject> GetAll()
        {
            return base.GetAll().Select(i => new PaymentObject(i.time, i.value));
        }
    }
}