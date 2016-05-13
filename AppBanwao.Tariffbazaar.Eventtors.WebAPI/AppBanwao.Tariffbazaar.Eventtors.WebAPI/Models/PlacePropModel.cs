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
    public class PlacePropModel
    {
        public PlacePropModel(){}

        public PlacePropModel(ICollection<PlacesProp> prop)
        {
            PlaceProperties = new List<PlacePropModel>();
            foreach (var p in prop)
            {
                this.AirConditioned = p.AirConditioned;
                this.EventOptions = p.EventOptions;
                this.IsShaded = p.IsShaded;
                this.PlaceID = p.PlaceID;
                this.PlacePropID = p.PlacePropID;
                this.Rooms = p.Rooms;

                PlaceProperties.Add(this);
            }
        }
        [DataMember]
        public int PlacePropID { get; set; }
        [DataMember]
        public Nullable<System.Guid> PlaceID { get; set; }
        [DataMember]
        public Nullable<int> Rooms { get; set; }
        [DataMember]
        public Nullable<bool> AirConditioned { get; set; }
        [DataMember]
        public string EventOptions { get; set; }
        [DataMember]
        public Nullable<bool> IsShaded { get; set; }
        [DataMember]
        public List<PlacePropModel> PlaceProperties { get; set; }

    }
}