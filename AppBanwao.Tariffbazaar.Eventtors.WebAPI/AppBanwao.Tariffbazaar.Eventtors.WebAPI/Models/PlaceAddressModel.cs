using AppBanwao.Tariffbazaar.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace AppBanwao.Tariffbazaar.Eventtors.WebAPI.Models
{
    [Serializable]
    [DataContract(IsReference=true)]
    public class PlaceAddressModel
    {
        public PlaceAddressModel() { }
        public PlaceAddressModel(ICollection <PlaceAddress> placeaddress)
        {
            this.PlaceAddresses = new List<PlaceAddressModel>();
            foreach (var placeaddr in placeaddress)
            {
                var objPlaceaddr = new PlaceAddressModel()
                {
                    PlaceAddressID = placeaddr.PlaceAddressID,
                    PlaceID = placeaddr.PlaceID,
                    Addressline1 = placeaddr.Addressline1,
                    Addressline2 = placeaddr.Addressline2,
                    LandMark = placeaddr.LandMark,
                    CityID = placeaddr.CityID,
                    StateID = placeaddr.StateID,
                    Country = placeaddr.Country,
                    LongLatDetails = placeaddr.LongLatDetails
                };
                PlaceAddresses.Add(objPlaceaddr);
                objPlaceaddr = null;
            }
        }
        [DataMember]
        public List<PlaceAddressModel> PlaceAddresses { get; set; }
        [DataMember]
        public int PlaceAddressID { get; set; }
        [DataMember]
        public Nullable<System.Guid> PlaceID { get; set; }
        [DataMember]
        public string Addressline1 { get; set; }
        [DataMember]
        public string Addressline2 { get; set; }
        [DataMember]
        public string LandMark { get; set; }
        [DataMember]
        public string PrimaryEmailAddress { get; set; }
        [DataMember]
        public string WebsiteLink { get; set; }
        [DataMember]
        public Nullable<int> CityID { get; set; }
        [DataMember]
        public Nullable<int> StateID { get; set; }
        [DataMember]
        public Nullable<int> Country { get; set; }
        [DataMember]
        public string LongLatDetails { get; set; }
    }
}