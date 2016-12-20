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
    [RoutePrefix("visits")]
    public class VisitController : ApiController
    {
        private readonly IVisitService _visitService;

        #region Constructor
        public VisitController(IVisitService visitService)
        {
            _visitService = visitService;
        }
        #endregion

        // GET: visits/5
        [HttpGet]
        [Route("{id:int}", Name = "VisitByIDRoute")]
        public IHttpActionResult VisitByID(int id)
        {
            var visit = _visitService.GetVisitByID(id);
            if (visit != null) return Ok(visit);
            return NotFound();
        }

        // GET: visits
        [HttpGet]
        [Route("")]
        public IHttpActionResult AllVisits()
        {
            var visits = _visitService.GetAllVisits();
            if (visits != null)
            {
                var visitDTOs = visits as List<VisitDTO> ?? visits.ToList();
                if (visitDTOs.Any()) return Ok(visitDTOs);
            }
            return NotFound();
        }


    }
}
