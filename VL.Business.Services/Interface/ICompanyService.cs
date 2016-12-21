using System.Collections.Generic;
using VL.Business.Entities;

namespace VL.Business.Services.Interface
{
    public interface ICompanyService
    {
        #region Company
        CompanyDTO GetCompanyByID(int companyID);
        IEnumerable<CompanyDTO> GetAllCompanies();
        int CreateCompany(CompanyDTO companyDTO);
        bool UpdateCompany(int companyID, CompanyDTO companyDTO);
        bool DeleteCompany(int companyID);
        #endregion
    }
}
