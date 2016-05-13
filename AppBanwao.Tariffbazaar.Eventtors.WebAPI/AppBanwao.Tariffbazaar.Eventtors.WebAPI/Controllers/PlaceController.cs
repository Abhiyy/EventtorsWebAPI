using AppBanwao.Tariffbazaar.DataAccess;
using AppBanwao.Tariffbazaar.Eventtors.WebAPI.Helpers;
using AppBanwao.Tariffbazaar.Eventtors.WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AppBanwao.Tariffbazaar.Eventtors.WebAPI.Controllers
{
    public class PlaceController : ApiController
    {
        // GET api/<controller>
        CommonHelper _commHelper = null;
        public HttpResponseMessage Get()
        {
            List<PlaceModel> places = null;
            HttpResponseMessage response = null;
            try
            {
              _commHelper= new CommonHelper();
            
              places = _commHelper.GetPlaces();
              response = Request.CreateResponse(HttpStatusCode.OK, places);
              return response;
            }
            catch (Exception ex)
            {

            }
            finally {
                _commHelper = null;
            }
            return response;
        }

        // GET api/<controller>/5
        public HttpResponseMessage Get(Guid id)
        {
            HttpResponseMessage response = null;
            try
            {
                _commHelper = new CommonHelper();

                var place = _commHelper.GetPlace(id,new TariffBazaarEntities());
                response = Request.CreateResponse(HttpStatusCode.OK, place);
                return response;
            }
            catch (Exception ex)
            {

            }
            finally
            {
                _commHelper = null;
            }
            return response;
        }

        // POST api/<controller>
        public Place Post(PlaceModel place)
        {
            try {
                _commHelper = new CommonHelper();
                var placeCreated=_commHelper.SavePlace(place);
                return placeCreated;
            }
            catch (Exception ex)
            { 
            }
            finally{
            _commHelper = null;
            }
            return null;
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }

        public PlaceAddress AddAddress(PlaceAddressModel address)
        {
            try
            {
                _commHelper = new CommonHelper();
                var placeAddress = _commHelper.SaveAddressDetails(address);
                return placeAddress;
            }
            catch (Exception ex)
            {

            }
            finally
            {
                _commHelper = null;
            }

            return null;
        }

        public PlaceContactDetail AddContactDetail(PlaceContactModel contact)
        {
            try
            {
                _commHelper = new CommonHelper();
                var placeContact = _commHelper.SaveContactDetails(contact);
                return placeContact;
            }
            catch (Exception ex)
            {

            }
            finally {
                _commHelper = null;
            }

            return null;
        }

        public PlaceOwnerDetail AddOwnerDetail(PlaceOwnerModel owner)
        {
            try
            {
                _commHelper = new CommonHelper();
                var placeOwner = _commHelper.SaveOwnerDetails(owner);
                return placeOwner;
            }
            catch (Exception ex)
            {

            }
            finally
            {
                _commHelper = null;
            }

            return null;
        }

        public bool AddFoodMenuDetails(CreateFoodMenuModel foodmenu)
        {
            try
            {
                _commHelper = new CommonHelper();
                
                if(_commHelper.CreateFoodMenu(foodmenu))
                return true;
            }
            catch (Exception ex)
            {

            }
            finally
            {
                _commHelper = null;
            }
            return false;
        }

        public bool SavePriceDetails(CreatePriceModel price)
        {
            try
            {
                _commHelper = new CommonHelper();

                if (_commHelper.CreatePriceDetail(price))
                    return true;
            }
            catch (Exception ex)
            {

            }
            finally
            {
                _commHelper = null;
            }
            return false;
        }

        public PlacePropModel SavePlaceProps(PlacePropModel pp)
        {
            try
            {
                _commHelper = new CommonHelper();


                return _commHelper.SavePlaceProperties(pp);
            }
            catch (Exception ex)
            {

            }
            finally
            {
                _commHelper = null;
            }
            return null;
        }

        public bool SaveImages(ImagesModel img)
        {
            try
            {
                _commHelper = new CommonHelper();


                return _commHelper.SaveImages(img);
            }
            catch (Exception ex)
            {

            }
            finally
            {
                _commHelper = null;
            }
            return false;
        }

    }
}