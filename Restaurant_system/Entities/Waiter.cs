using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_system.Entities
{
    public class Waiter<T1, T2, T3, T4, T5>
    {
        public T1 WaiterId { get; set; }
        public T2 Name { get; set; }
        public T3 Table { get; set; }
        public T4 VisitorId { get; set; }
        public T5 VisitorOrder { get; set; }

        public Waiter ()
        {

        }

        public Waiter (T1 waiterId, T2 name, T3 table, T4 visitorId, T5 visitorOrder)
        {
            this.WaiterId = waiterId;
            this.Name = name;
            this.Table = table;
            this.VisitorId = visitorId;
            this.VisitorOrder = visitorOrder;
        }
    }
}
