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

        #region Badge

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

        #endregion

        #region BadgeHistory

        #endregion

        #region BadgeType
        // GET: badgetypes
        [HttpGet]
        [Route("~/badgetypes")]
        public IHttpActionResult AllBadgeTypes()
        {
            var badgeTypes = _badgeService.GetAllBadgeTypes();
            if (badgeTypes != null)
            {
                var badgeTypeDTOs = badgeTypes as List<BadgeTypeDTO> ?? badgeTypes.ToList();
                if (badgeTypeDTOs.Any()) return Ok(badgeTypeDTOs);
            }
            return NotFound();
        }

        // GET: badgetype/5
        [HttpGet]
        [Route("~/badgetypes/{id:int}", Name = "BadgeTypeByIDRoute")]
        public IHttpActionResult BadgeTypeByID(int id)
        {
            var badgeType = _badgeService.GetBadgeTypeByID(id);
            if (badgeType != null) return Ok(badgeType);
            return NotFound();
        }

        #endregion

        #region BadgeTypeHistory

        #endregion
    }
}
