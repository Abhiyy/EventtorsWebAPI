using AppBanwao.Tariffbazaar.DataAccess;
using AppBanwao.Tariffbazaar.Eventtors.WebAPI.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AppBanwao.Tariffbazaar.Eventtors.WebAPI.Controllers
{
    public class PlacetypeController : ApiController
    {
        // GET api/<controller>
        CommonHelper _commHelper = null;
        public IEnumerable<PlaceType> Get()
        {_commHelper = new CommonHelper();
            var placetypes = _commHelper.GetPlaceTypes();
            return placetypes;
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }


    }
}