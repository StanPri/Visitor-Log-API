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
    [RoutePrefix("assets")]
    public class AssetController : ApiController
    {
        private readonly IAssetService _assetService;

        public AssetController(IAssetService assetService)
        {
            _assetService = assetService;
        }

        // GET: assets
        [HttpGet]
        [Route("")]
        public IHttpActionResult AllAssets()
        {
            var assets = _assetService.GetAllAssets();
            if (assets != null)
            {
                var assetsDTOs = assets as List<AssetDTO> ?? assets.ToList();
                if (assetsDTOs.Any()) return Ok(assets);
            }
            return NotFound();
        }

        // GET: campuses/5
        [HttpGet]
        [Route("{id:int}", Name = "AssetByIDRoute")]
        public IHttpActionResult AssetByID(int id)
        {
            var asset = _assetService.GetAssetByID(id);
            if (asset != null) return Ok(asset);
            return NotFound();
        }

    }
}
