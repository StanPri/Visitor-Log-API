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
    [RoutePrefix("visitors")]
    public class VisitorController : ApiController
    {
        private readonly IVisitorService _visitorService;

        #region Constructor
        public VisitorController(IVisitorService visitorService)
        {
            _visitorService = visitorService;
        }
        #endregion

        // GET: visitors/5
        [HttpGet]
        [Route("{id:int}", Name = "VisitorByIDRoute")]
        public IHttpActionResult VisitorByID(int id)
        {
            var visitor = _visitorService.GetVisitorByID(id);
            if (visitor != null) return Ok(visitor);
            return NotFound();
        }

        // GET: visitors
        [HttpGet]
        [Route("")]
        public IHttpActionResult AllVisitors()
        {
            var visitors = _visitorService.GetAllVisitors();
            if (visitors != null)
            {
                var visitorDTOs = visitors as List<VisitorDTO> ?? visitors.ToList();
                if (visitorDTOs.Any()) return Ok(visitorDTOs);
            }
            return NotFound();
        }


    }
}
