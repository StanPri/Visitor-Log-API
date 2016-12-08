using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using VL.Business.Entities;
using VL.Business.Services.Interface;

namespace VL.Web.Api.Controllers
{
    [RoutePrefix("visitorlogs")]
    public class VisitorLogController : ApiController
    {
        private readonly IVisitorLogService _visitorLogServices;

        #region Constructors
        public VisitorLogController(IVisitorLogService visitorLogServices)
        {
            _visitorLogServices = visitorLogServices;

        }
        #endregion

        // GET: api/visitorlogs/5
        [HttpGet]
        [Route("{id:int}")]
        public IHttpActionResult VisitorLogByID(int id)
        {
            var visitorlog = _visitorLogServices.GetVisitorLogByID(id);
            if (visitorlog != null)
                return Ok(visitorlog);
            return NotFound();
        }

        // GET: api/visitorlogs
        [HttpGet]
        [Route("")]
        public IHttpActionResult AllVisitorLogs()
        {
            var visitorlogs = _visitorLogServices.GetAllVisitorLogs();
            if (visitorlogs != null)
            {
                var visitorLogModels = visitorlogs as List<VisitorLogEntity> ?? visitorlogs.ToList();
                if (visitorLogModels.Any())
                    return Ok(visitorlogs);
            }
            return NotFound();
        }

    }
}
