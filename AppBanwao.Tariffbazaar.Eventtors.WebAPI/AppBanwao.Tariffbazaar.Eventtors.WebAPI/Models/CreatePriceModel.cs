using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppBanwao.Tariffbazaar.Eventtors.WebAPI.Models
{
    public class CreatePriceModel
    {
        public bool Booking { get; set; }

        public decimal BookingPrice { get; set; }

        public bool Reservation { get; set; }

        public decimal ReservationPrice { get; set; }

        public Guid PlaceID { get; set; }
    }
}