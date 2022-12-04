using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_system.Entities
{
    internal class Validation <T>
    {
        public static void CheckIfValueNotNull ( T value)
        {
            if ( value == null )   throw new ArgumentNullException (nameof(value));
        }
    }
}
