using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using VL.Business.Entities;
using VL.Business.Services.Interface;

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

    }
}
