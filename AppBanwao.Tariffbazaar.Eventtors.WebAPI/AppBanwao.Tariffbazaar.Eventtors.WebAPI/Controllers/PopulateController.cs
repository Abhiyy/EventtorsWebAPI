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
    public class PopulateController : ApiController
    {
        // GET api/<controller>
        CommonHelper _commHelper = null;
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
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
        
        public IEnumerable<Country> GetCountries()
        {
            _commHelper = new CommonHelper();
            var countries = _commHelper.GetCountries();
            return countries;
        }
       
        public IEnumerable<State> GetStates()
        {
            _commHelper = new CommonHelper();
            var states = _commHelper.GetStates();
            return states;
        }
       
        public IEnumerable<City> GetCities()
        {
            _commHelper = new CommonHelper();
            var cities = _commHelper.GetCities();
            return cities;
        }

        public IEnumerable<PlaceEvent> GetEvents()
        {
            _commHelper = new CommonHelper();
            var events = _commHelper.GetEvents();
            return events;
        }
    }
}