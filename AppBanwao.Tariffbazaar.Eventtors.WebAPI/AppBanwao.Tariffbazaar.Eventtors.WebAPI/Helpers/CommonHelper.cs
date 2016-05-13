using AppBanwao.Tariffbazaar.DataAccess;
using AppBanwao.Tariffbazaar.Eventtors.WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppBanwao.Tariffbazaar.Eventtors.WebAPI.Helpers
{
    public class CommonHelper
    {
        TariffBazaarEntities _dbContext = null;

        public List<PlaceModel> GetPlaces(bool Active=true)
        {
            List<PlaceModel> lstPlaces = new List<PlaceModel>();
            _dbContext = new TariffBazaarEntities();
            var places = _dbContext.Places.Where(x=>x.Active==Active).ToList();
            foreach(var place in places)
            {
                lstPlaces.Add(GetPlace(place.PlaceID,_dbContext));
            }
            _dbContext = null;
            return lstPlaces;
        }

        public PlaceModel GetPlace(Guid placeID,TariffBazaarEntities dbContext)
        { 
            var place = dbContext.Places.Where(x=>x.PlaceID == placeID).FirstOrDefault();

            var placeModel = new PlaceModel(place);
            
            return placeModel;
        }

        public Place SavePlace(PlaceModel place)
        {
            _dbContext = new TariffBazaarEntities();
            var ObjPlace = new Place()
            {
                Active = place.Active,
                Area = place.Area,
                AvailableFrom = place.AvailableFrom,
                AvailableTill = place.AvailableTill,
                CreatedDate = DateTime.Now,
                DiningCapacity = place.DiningCapacity,
                Name = place.Name,
                PlaceID = Guid.NewGuid(),
                PlaceType = place.PlaceType,
                SeatingCapacity = place.SeatingCapacity,
                UpdatedDate = DateTime.Now
            };
            _dbContext.Places.Add(ObjPlace);
            _dbContext.SaveChanges();
            _dbContext = null;
            return ObjPlace;
        }

        public PlaceContactDetail SaveContactDetails(PlaceContactModel contact)
        {
            _dbContext = new TariffBazaarEntities();
            var objContact = new PlaceContactDetail()
            {
                PlaceID = contact.PlaceID,
                PrimaryPOCName = contact.PrimaryPOCName,
                PrimaryPOCNumber = contact.PrimaryPOCNumber,
                SecondaryPOCName = contact.SecondaryPOCName,
                SecondaryPOCNumber = contact.SecondaryPOCNumber
            };
            _dbContext.PlaceContactDetails.Add(objContact);
            _dbContext.SaveChanges();
            _dbContext = null;
            return objContact;
        }

        public PlaceAddress SaveAddressDetails(PlaceAddressModel address)
        {
            _dbContext = new TariffBazaarEntities();

            var objplaceAddress = new PlaceAddress()
            {
                Addressline1 = address.Addressline1,
                Addressline2 = address.Addressline2,
                CityID = address.CityID,
                Country = address.Country,
                LandMark = address.LandMark,
                LongLatDetails = address.LongLatDetails,
                PlaceID = address.PlaceID,
                StateID = address.StateID,
                PrimaryEmailAddress = address.PrimaryEmailAddress,
                WebsiteLink = address.WebsiteLink
            };
            _dbContext.PlaceAddresses.Add(objplaceAddress);
            _dbContext.SaveChanges();
            _dbContext = null;
            return objplaceAddress;
        }

        public PlaceOwnerDetail SaveOwnerDetails(PlaceOwnerModel owner)
        {
            _dbContext = new TariffBazaarEntities();
            var objOwner = new PlaceOwnerDetail()
            {
              CityID = owner.CityID,
              CountryID = owner.CountryID,
              OwnerAddress = owner.OwnerAddress,
              OwnerContact = owner.OwnerContact,
              Ownername = owner.Ownername,
              StateID = owner.StateID,
                PlaceID = owner.PlaceID
                
            };
            _dbContext.PlaceOwnerDetails.Add(objOwner);
            _dbContext.SaveChanges();
            _dbContext = null;
            return objOwner;
        }

        public bool CreateFoodMenu(CreateFoodMenuModel foodmenu)
        {
            
            _dbContext = new TariffBazaarEntities();
            if (foodmenu.Vegetarian)
            {
                var vegFood = new PlaceFoodMenu() { FoodMenu = foodmenu.VegFoodMenu, FoodType = 1, PlaceID = foodmenu.PlaceID, PlateCostMin = Convert.ToDecimal(foodmenu.VegFoodMinCost), PlateCostMax = Convert.ToDecimal(foodmenu.VegFoodMaxCost) };
                _dbContext.PlaceFoodMenus.Add(vegFood);
                _dbContext.SaveChanges();
            }

            if (foodmenu.NonVegetarian)
            {
                var vegFood = new PlaceFoodMenu() { FoodMenu = foodmenu.NonVegFoodMenu, FoodType = 2, PlaceID = foodmenu.PlaceID, PlateCostMin = Convert.ToDecimal(foodmenu.NonVegFoodMinCost), PlateCostMax = Convert.ToDecimal(foodmenu.NonVegFoodMaxCost) };
                _dbContext.PlaceFoodMenus.Add(vegFood);
                _dbContext.SaveChanges();
            }
            _dbContext = null;
            return true;
        }

        public bool CreatePriceDetail(CreatePriceModel price)
        {

            _dbContext = new TariffBazaarEntities();
            if (price.Booking)
            {
                var BookPrice = new PlacePriceDetail() {AmountType = "Booking", PlaceID = price.PlaceID, Amount = price.BookingPrice };
                _dbContext.PlacePriceDetails.Add(BookPrice);
                _dbContext.SaveChanges();
            }

            if (price.Reservation)
            {
                var reservePrice = new PlacePriceDetail() { AmountType = "Reservation", PlaceID = price.PlaceID, Amount = price.ReservationPrice };
                _dbContext.PlacePriceDetails.Add(reservePrice);
                _dbContext.SaveChanges();
            }

            _dbContext = null;
            return true;
        }

        public PlacePropModel SavePlaceProperties(PlacePropModel pp)
        {
            _dbContext = new TariffBazaarEntities();

            var placeprop = new PlacesProp()
            {
                AirConditioned = pp.AirConditioned,
                EventOptions = pp.EventOptions.Remove(pp.EventOptions.Length-1),
                IsShaded = pp.IsShaded,
                PlaceID = pp.PlaceID,
                Rooms = pp.Rooms
            };
            _dbContext.PlacesProps.Add(placeprop);
            _dbContext.SaveChanges();
            pp.PlacePropID = placeprop.PlacePropID;
            _dbContext = null;
            return pp;

        }

        public bool SaveImages(ImagesModel images)
        {
            _dbContext = new TariffBazaarEntities();
            images.ImageLink = images.ImageLink.Remove(images.ImageLink.Length-1);
            var imageArr = images.ImageLink.Split(';');

            foreach (var img in imageArr)
            {
                var objImage = new PlaceImage() { PlaceID = images.PlaceID,ImageLink= img};
                _dbContext.PlaceImages.Add(objImage);
                _dbContext.SaveChanges();
            }
            _dbContext = null;
            return true;
        }

        public List<PlaceType> GetPlaceTypes()
        {
            _dbContext = new TariffBazaarEntities();
            var placetypes = _dbContext.PlaceTypes.ToList();
            _dbContext = null;
            return placetypes;
        }

        public List<Country> GetCountries()
        {
            _dbContext = new TariffBazaarEntities();
            var countries = _dbContext.Countries.ToList();
            _dbContext = null;
            return countries;
        }

        public List<State> GetStates()
        {
            _dbContext = new TariffBazaarEntities();
            var states = _dbContext.States.ToList();
            _dbContext = null;
            return states;
        }

        public List<City> GetCities()
        {
            _dbContext = new TariffBazaarEntities();
            var cities = _dbContext.Cities.ToList();
            _dbContext = null;
            return cities;
        }

        public List<PlaceEvent> GetEvents()
        {
            _dbContext = new TariffBazaarEntities();
            var events = _dbContext.PlaceEvents.ToList();
            _dbContext = null;
            return events;
        }
    }
}