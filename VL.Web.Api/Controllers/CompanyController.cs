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
    [RoutePrefix("companies")]
    public class CompanyController : ApiController
    {
        private readonly ICompanyService _companyService;

        public CompanyController(ICompanyService companyService)
        {
            _companyService = companyService;
        }

        // GET: companies
        [HttpGet]
        [Route("")]
        public IHttpActionResult AllCompanies()
        {
            var companies = _companyService.GetAllCompanies();
            if (companies != null)
            {
                var companyDTOs = companies as List<CompanyDTO> ?? companies.ToList();
                if (companyDTOs.Any()) return Ok(companyDTOs);
            }
            return NotFound();
        }

        // GET: companies/5
        [HttpGet]
        [Route("{id:int}", Name = "CompanyByIDRoute")]
        public IHttpActionResult CompanyByID(int id)
        {
            var company = _companyService.GetCompanyByID(id);
            if (company != null) return Ok(company);
            return NotFound();
        }
    }
}
