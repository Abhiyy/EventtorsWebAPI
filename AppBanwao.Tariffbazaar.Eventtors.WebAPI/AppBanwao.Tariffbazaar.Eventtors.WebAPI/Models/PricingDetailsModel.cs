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
    public class PricingDetailsModel
    {
        public PricingDetailsModel() { }

        public PricingDetailsModel(ICollection<PlacePriceDetail> prices)
        {
            PriceDetails = new List<PricingDetailsModel>();

            foreach (var p in prices)
            {
                var pri = new PricingDetailsModel()
                {
                    Amount = p.Amount,
                    AmountType = p.AmountType,
                    PlaceID = p.PlaceID,
                    PlacePriceID = p.PlacePriceID
                };
                PriceDetails.Add(pri);
                pri=null;
            }
        }
        [DataMember]
        public int PlacePriceID { get; set; }
        [DataMember]
        public Nullable<System.Guid> PlaceID { get; set; }
        [DataMember]
        public string AmountType { get; set; }
        [DataMember]
        public Nullable<decimal> Amount { get; set; }
        [DataMember]
        public List<PricingDetailsModel> PriceDetails { get; set; }
    }
}