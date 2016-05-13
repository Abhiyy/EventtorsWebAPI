using AppBanwao.Tariffbazaar.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace AppBanwao.Tariffbazaar.Eventtors.WebAPI.Models
{
    [Serializable]
    [DataContract(IsReference = true)]
    public class ImagesModel
    {
        public ImagesModel(){}

        public ImagesModel(ICollection<PlaceImage> images)
        {
            PlaceImages = new List<ImagesModel>();
            foreach (var img in images)
            {
                this.ImageLinkID = img.ImageLinkID;
                this.PlaceID = img.PlaceID;
                this.ImageLink = img.ImageLink;


                PlaceImages.Add(this);
            }
        }

        [DataMember]
        public int ImageLinkID { get; set; }
        [DataMember]
        public Nullable<System.Guid> PlaceID { get; set; }
        [DataMember]
        public string ImageLink { get; set; }

        [DataMember]
        public List<ImagesModel> PlaceImages { get; set; }
    }
}