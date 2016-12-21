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

        #region Constructor
        public AssetController(IAssetService assetService)
        {
            _assetService = assetService;
        }
        #endregion

        #region Asset

        // GET: assets
        [HttpGet]
        [Route("")]
        public IHttpActionResult AllAssets()
        {
            var assets = _assetService.GetAllAssets();
            if (assets != null)
            {
                var assetsDTOs = assets as List<AssetDTO> ?? assets.ToList();
                if (assetsDTOs.Any()) return Ok(assetsDTOs);
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
        [HttpPost]
        [Route("")]
        [ValidateModel]
        public HttpResponseMessage CreateAsset([FromBody]AssetDTO assetDTO)
        {
            int newID = _assetService.CreateAsset(assetDTO);
            string uri = Url.Link("AssetByIDRoute", new { id = newID });
            // Generate a link to the new campus and set the location header in the response.
            var response = new HttpResponseMessage(HttpStatusCode.Created);
            response.Headers.Location = new System.Uri(uri);
            return response;
        }


        #endregion

        #region AssetHistory

        #endregion

        #region AssetType
        // GET: assettypes
        [HttpGet]
        [Route("~/assettypes")]
        public IHttpActionResult AllAssetTypes()
        {
            var assets = _assetService.GetAllAssetTypes();
            if (assets != null)
            {
                var assetsDTOs = assets as List<AssetTypeDTO> ?? assets.ToList();
                if (assetsDTOs.Any()) return Ok(assetsDTOs);
            }
            return NotFound();
        }

        // GET: assettypes/5
        [HttpGet]
        [Route("~/assettypes/{id:int}", Name = "AssetTypeByIDRoute")]
        public IHttpActionResult AssetTypeByID(int id)
        {
            var asset = _assetService.GetAssetTypeByID(id);
            if (asset != null) return Ok(asset);
            return NotFound();
        }

        [HttpPost]
        [Route("~/assettypes")]
        [ValidateModel]
        public HttpResponseMessage CreateAssetType([FromBody]AssetTypeDTO assetTypeDTO)
        {
            int newID = _assetService.CreateAssetType(assetTypeDTO);
            string uri = Url.Link("AssetTypeByIDRoute", new { id = newID });
            // Generate a link to the new campus and set the location header in the response.
            var response = new HttpResponseMessage(HttpStatusCode.Created);
            response.Headers.Location = new System.Uri(uri);
            return response;
        }


        #endregion

        #region AssetTypeHistory

        #endregion

    }
}
