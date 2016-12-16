using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using VL.Business.Entities;
using VL.Business.Services.Interface;
using VL.Web.Common.Validation;

namespace VL.Web.Api.Controllers
{
    [RoutePrefix("locations")]
    public class LocationController : ApiController
    {
        private readonly ILocationService _locationService;
        public LocationController(ILocationService locationService)
        {
            this._locationService = locationService;
        }

        // GET: locations/5
        [HttpGet]
        [Route("{id:int}", Name = "LocationByIDRoute")]
        public IHttpActionResult LocationByID(int id)
        {
            var location = _locationService.GetLocationByID(id);
            if (location != null)
                return Ok(location);
            return NotFound();
        }

        [HttpPost]
        [Route("")]
        [ValidateModel]
        public HttpResponseMessage CreateLocation([FromBody]LocationDTO locationDTO)
        {
            int newID = _locationService.CreateLocation(locationDTO);
            string uri = Url.Link("LocationByIDRoute", new { id = newID });
            var response = new HttpResponseMessage(HttpStatusCode.Created);
            response.Headers.Location = new System.Uri(uri);
            return response;
        }
        
        // GET: locations
        [HttpGet]
        [Route("")]
        public IHttpActionResult AllLocations()
        {
            var locations = _locationService.GetAllLocations();
            if (locations != null)
            {
                var locationDTOs = locations as List<LocationDTO> ?? locations.ToList();
                if (locationDTOs.Any()) return Ok(locations);
            }
            return NotFound();
        }

        [HttpGet]
        [Route("~/campuses/{campusID:int}/locations", Name = "")]
        public IHttpActionResult LocationsByCampusID(int campusID)
        {
            var locations = _locationService.GetLocationsByCampusID(campusID);
            if(locations != null)
            {
                var locationModels = locations as List<LocationDTO> ?? locations.ToList();
                if (locations.Any()) return Ok(locationModels);
            }
            return NotFound();
        }
    }
}
