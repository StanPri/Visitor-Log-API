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
    [RoutePrefix("stations")]
    public class StationController : ApiController
    {
        private readonly IStationService _stationService;

        #region Constructor
        public StationController(IStationService stationService)
        {
            _stationService = stationService;
        }
        #endregion

        // GET: stations/5
        [HttpGet]
        [Route("{id:int}", Name = "StationByIDRoute")]
        public IHttpActionResult StationByID(int id)
        {
            var station = _stationService.GetStationByID(id);
            if (station != null) return Ok(station);
            return NotFound();
        }

        // GET: stations
        [HttpGet]
        [Route("")]
        public IHttpActionResult AllStations()
        {
            var stations = _stationService.GetAllStations();
            if (stations != null)
            {
                var stationDTOs = stations as List<StationDTO> ?? stations.ToList();
                if (stationDTOs.Any()) return Ok(stationDTOs);
            }
            return NotFound();
        }

    }
}
