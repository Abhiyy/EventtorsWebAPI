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
    public class PlaceContactModel
    {

        public PlaceContactModel() { }

        public PlaceContactModel(ICollection<PlaceContactDetail> contacts)
        {
            ContactDetails = new List<PlaceContactModel>();
            foreach (var con in contacts)
            {
                var contact = new PlaceContactModel()
                {
                  PlaceContactID = con.PlaceContactID,
                  PlaceID = con.PlaceID,
                  PrimaryPOCName = con.PrimaryPOCName,
                  PrimaryPOCNumber = con.PrimaryPOCNumber,
                  SecondaryPOCName = con.SecondaryPOCName,
                  SecondaryPOCNumber = con.SecondaryPOCNumber
                };
                ContactDetails.Add(contact);
                contact = null;
            }

        }


        [DataMember]
        public int PlaceContactID { get; set; }
        [DataMember]
        public Nullable<System.Guid> PlaceID { get; set; }
        [DataMember]
        public string PrimaryPOCName { get; set; }
        [DataMember]
        public string PrimaryPOCNumber { get; set; }
        [DataMember]
        public string SecondaryPOCName { get; set; }
        [DataMember]
        public string SecondaryPOCNumber { get; set; }
        [DataMember]
        public List<PlaceContactModel> ContactDetails { get; set; }
    }
}