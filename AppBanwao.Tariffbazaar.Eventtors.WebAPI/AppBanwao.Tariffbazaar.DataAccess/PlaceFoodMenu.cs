//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AppBanwao.Tariffbazaar.DataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class PlaceFoodMenu
    {
        public int FoodID { get; set; }
        public Nullable<System.Guid> PlaceID { get; set; }
        public Nullable<int> FoodType { get; set; }
        public string FoodMenu { get; set; }
        public Nullable<decimal> PlateCostMin { get; set; }
        public Nullable<decimal> PlateCostMax { get; set; }
    
        public virtual Place Place { get; set; }
    }
}