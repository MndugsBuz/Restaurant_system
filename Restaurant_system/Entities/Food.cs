using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_system.Entities
{
    public class Food
    {
        public string FoodID { get; set; }
        public string FoodName { get; set; }
        public string FoodDescription { get; set; }
        public string UnitofMesuarment { get; set; }
        public decimal FoodPrice { get; set; }

        public Food ()
            { 
            }

        public Food (string foodId, string foodName, string foodDescription, string unitOfMesuarment, decimal foodprice)

        {
            this.FoodID = foodId;
            this.FoodName = foodName;   
            this.FoodDescription = foodDescription;
            this.UnitofMesuarment = unitOfMesuarment;
            this.FoodPrice = foodprice;

        }

    }
}
