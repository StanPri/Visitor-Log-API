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
    [RoutePrefix("badges")]
    public class BadgeController : ApiController
    {
        private readonly IBadgeService _badgeService;

        public BadgeController(IBadgeService badgeService)
        {
            _badgeService = badgeService;
        }

        // GET: badges
        [HttpGet]
        [Route("")]
        public IHttpActionResult AllBadges()
        {
            var badges = _badgeService.GetAllBadges();
            if (badges != null)
            {
                var badgeDTOs = badges as List<BadgeDTO> ?? badges.ToList();
                if (badgeDTOs.Any()) return Ok(badgeDTOs);
            }
            return NotFound();
        }

        // GET: badges/5
        [HttpGet]
        [Route("{id:int}", Name = "BadgeByIDRoute")]
        public IHttpActionResult BadgeByID(int id)
        {
            var badge = _badgeService.GetBadgeByID(id);
            if (badge != null) return Ok(badge);
            return NotFound();
        }
    }
}
