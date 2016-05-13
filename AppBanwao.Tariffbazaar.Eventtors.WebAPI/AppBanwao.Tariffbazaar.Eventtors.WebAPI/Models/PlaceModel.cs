using AppBanwao.Tariffbazaar.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace AppBanwao.Tariffbazaar.Eventtors.WebAPI.Models
{
    
    public class PlaceModel
    {
        public PlaceModel() { }
        public PlaceModel(Place place)
        { 
                Active = place.Active;
                Area = place.Area;
                AvailableFrom = place.AvailableFrom;
                AvailableTill = place.AvailableTill;
                CreatedDate = place.CreatedDate;
                DiningCapacity = place.DiningCapacity;
                Name = place.Name;
                PlaceAddresses = new PlaceAddressModel(place.PlaceAddresses).PlaceAddresses;
                PlaceContactDetails = new PlaceContactModel(place.PlaceContactDetails).ContactDetails;
                PlaceFoodMenus = new FoodMenuModel(place.PlaceFoodMenus).FoodMenus;
                PlaceID = place.PlaceID;
                PlaceOwnerDetails = new  PlaceOwnerModel(place.PlaceOwnerDetails).OwnerDetails;
                PlacePriceDetails = new PricingDetailsModel(place.PlacePriceDetails).PriceDetails;
                PlacesProps = new PlacePropModel(place.PlacesProps).PlaceProperties;
                PlaceImgs = new ImagesModel(place.PlaceImages).PlaceImages;
                PlaceType = place.PlaceType;
                SeatingCapacity = place.SeatingCapacity;
                UpdatedDate = place.UpdatedDate;
        }
        public System.Guid PlaceID { get; set; }
        public string Name { get; set; }
        public string SeatingCapacity { get; set; }
        public string DiningCapacity { get; set; }
        public Nullable<decimal> Area { get; set; }
        public Nullable<System.DateTime> AvailableFrom { get; set; }
        public Nullable<System.DateTime> AvailableTill { get; set; }
        public Nullable<int> PlaceType { get; set; }
        public Nullable<bool> Active { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }

        
        public List<PlaceAddressModel> PlaceAddresses { get; set; }

        public List<PlaceContactModel> PlaceContactDetails { get; set; }

        public List<FoodMenuModel> PlaceFoodMenus { get; set; }

        public List<PlaceOwnerModel> PlaceOwnerDetails { get; set; }

        public List<PricingDetailsModel> PlacePriceDetails { get; set; }

        public List<PlacePropModel> PlacesProps { get; set; }
        public List<ImagesModel> PlaceImgs { get; set; }
    }
}