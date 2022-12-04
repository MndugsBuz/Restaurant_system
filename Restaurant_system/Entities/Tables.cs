using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_system.Entities
{
    public class Tables
    {
           
            public string TableId { get; set; }
            public string TableName { get; set; }
            public string WaiterId { get; set; }
            public bool TableStatus { get; set; }            
            public int NumberofSeats { get; set; }

            public Tables()
            {
            }

            public Tables(string id, string name, string waiterId, bool tableStatus, int numberOfSeats)
            {
                this.TableId = id;
                this.TableName = name;
                this.WaiterId = waiterId;
                this.TableStatus = tableStatus;
                this.NumberofSeats = numberOfSeats;
            }
       
    }
}
