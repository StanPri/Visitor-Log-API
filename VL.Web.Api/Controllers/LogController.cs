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
    [RoutePrefix("logs")]
    public class LogController : ApiController
    {
        private readonly ILogService _logService;

        #region Constructor
        public LogController(ILogService logService)
        {
            _logService = logService;
        }
        #endregion

        // GET: logs/5
        [HttpGet]
        [Route("{id:int}", Name = "LogByIDRoute")]
        public IHttpActionResult LogByID(int id)
        {
            var log = _logService.GetLogByID(id);
            if (log != null) return Ok(log);
            return NotFound();
        }

        // GET: logs
        [HttpGet]
        [Route("")]
        public IHttpActionResult AllLogs()
        {
            var logs = _logService.GetAllLogs();
            if (logs != null)
            {
                var logDTOs = logs as List<LogDTO> ?? logs.ToList();
                if (logDTOs.Any()) return Ok(logDTOs);
            }
            return NotFound();
        }


    }
}
