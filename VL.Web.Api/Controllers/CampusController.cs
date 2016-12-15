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
    [RoutePrefix("campuses")]
    public class CampusController : ApiController
    {
        private readonly ICampusService _campusService;

        #region Constructors
        public CampusController(ICampusService campusService)
        {
            _campusService = campusService;

        }
        #endregion

        // GET: campuses/5
        [HttpGet]
        [Route("{id:int}", Name = "CampusByIDRoute")]
        public IHttpActionResult CampusByID(int id)
        {
            var campus = _campusService.GetCampusByID(id);
            if (campus != null)
                return Ok(campus);
            return NotFound();
        }

        // GET: campuses
        [HttpGet]
        [Route("")]
        public IHttpActionResult AllCampuses()
        {
            var campuses = _campusService.GetAllCampuses();
            if (campuses != null)
            {
                var campusDTOs = campuses as List<CampusDTO> ?? campuses.ToList();
                if (campusDTOs.Any())
                    return Ok(campuses);
            }
            return NotFound();
        }

        [HttpPost]
        [ValidateModel]
        public HttpResponseMessage CreateCampus([FromBody]CampusDTO campusDTO )
        {
            int newID = _campusService.CreateCampus(campusDTO);
            string uri = Url.Link("CampusByIDRoute", new { id = newID });
            // Generate a link to the new campus and set the location header in the response.
            var response = new HttpResponseMessage(HttpStatusCode.Created);
            response.Headers.Location = new System.Uri(uri);
            return response;
        }

    }
}
