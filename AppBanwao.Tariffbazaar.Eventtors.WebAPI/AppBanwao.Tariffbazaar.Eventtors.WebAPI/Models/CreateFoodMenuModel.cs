using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppBanwao.Tariffbazaar.Eventtors.WebAPI.Models
{
    public class CreateFoodMenuModel
    {
        public int FoodMenuID { get; set; }

        public bool Vegetarian { get; set; }

        public bool NonVegetarian { get; set; }

        public string VegFoodMenu { get; set; }

        public string NonVegFoodMenu { get; set; }

        public double VegFoodMinCost { get; set; }
        public double VegFoodMaxCost { get; set; }

        public double NonVegFoodMinCost { get; set; }
        public double NonVegFoodMaxCost { get; set; }

        public Guid PlaceID { get; set; }

    }
}