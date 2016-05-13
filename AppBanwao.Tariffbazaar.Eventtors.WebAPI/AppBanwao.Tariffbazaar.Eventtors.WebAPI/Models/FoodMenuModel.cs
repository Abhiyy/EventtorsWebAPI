using AppBanwao.Tariffbazaar.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace AppBanwao.Tariffbazaar.Eventtors.WebAPI.Models
{
    [Serializable]
    [DataContract(IsReference=true)]
    public class FoodMenuModel
    {
        public FoodMenuModel() { }

        public FoodMenuModel(ICollection<PlaceFoodMenu> foodmenus)
        {
            FoodMenus = new List<FoodMenuModel>();

            foreach (var foodmenu in foodmenus)
            {
                this.FoodID = foodmenu.FoodID;
                this.FoodMenu = foodmenu.FoodMenu;
                this.FoodType = foodmenu.FoodType;
                this.PlaceID = foodmenu.PlaceID;
                this.PlateCostMax = foodmenu.PlateCostMax;
                this.PlateCostMin = foodmenu.PlateCostMin;
                FoodMenus.Add(this);
            }
        
        }

        [DataMember]
        public int FoodID { get; set; }
        [DataMember]
        public Nullable<System.Guid> PlaceID { get; set; }
        [DataMember]
        public Nullable<int> FoodType { get; set; }
        [DataMember]
        public string FoodMenu { get; set; }
        [DataMember]
        public Nullable<decimal> PlateCostMin { get; set; }
        [DataMember]
        public Nullable<decimal> PlateCostMax { get; set; }
        [DataMember]
        public List<FoodMenuModel> FoodMenus { get; set;}


    }
}