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
    public class PlaceOwnerModel
    {
        public PlaceOwnerModel() { }

        public PlaceOwnerModel(ICollection<PlaceOwnerDetail> owner)
        {
            OwnerDetails = new List<PlaceOwnerModel>();

            foreach (var o in owner) {
               var own = new PlaceOwnerModel(){
                CityID = o.CityID,
                CountryID = o.CountryID,
                OwnerAddress = o.OwnerAddress,
                OwnerContact = o.OwnerContact,
                Ownername = o.Ownername,
                PlaceID = o.PlaceID,
                PlaceOwnerID = o.PlaceOwnerID,
                StateID = o.StateID
            };
                OwnerDetails.Add(own);
                own = null;
            }
        }
        [DataMember]
        public int PlaceOwnerID { get; set; }
        [DataMember]
        public Nullable<System.Guid> PlaceID { get; set; }
        [DataMember]
        public string Ownername { get; set; }
        [DataMember]
        public string OwnerContact { get; set; }
        [DataMember]
        public string OwnerAddress { get; set; }
        [DataMember]
        public Nullable<int> CityID { get; set; }
        [DataMember]
        public Nullable<int> StateID { get; set; }
        [DataMember]
        public Nullable<int> CountryID { get; set; }
        [DataMember]
        public List<PlaceOwnerModel> OwnerDetails { get; set; }
    }
}