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
    
    public partial class PlaceImage
    {
        public int ImageLinkID { get; set; }
        public Nullable<System.Guid> PlaceID { get; set; }
        public string ImageLink { get; set; }
    
        public virtual Place Place { get; set; }
    }
}
