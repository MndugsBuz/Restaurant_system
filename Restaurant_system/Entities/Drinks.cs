using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_system.Entities
{
    public class Drinks
    {
        
        public string DrinkID { get; set; }
        public string DrinkName { get; set; }
        public string DrinkDescription { get; set; }
        public string UnitofMesuarment { get; set; }
        public decimal DrinkPrice { get; set; }

        public Drinks()
        {
        }

        public Drinks(string drinkId, string drinkName, string drinkDescription, string unitOfMesuarment, decimal drinkprice)

        {
            this.DrinkID = drinkId;
            this.DrinkName = drinkName;
            this.DrinkDescription = drinkDescription;
            this.UnitofMesuarment = unitOfMesuarment;
            this.DrinkPrice = drinkprice;

        }

    }
}

