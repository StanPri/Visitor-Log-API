using System;
using System.Collections.Generic;
using System.Linq;
using System.Transactions;
using VL.Business.Entities;
using VL.Business.Services.Mapper;
using VL.Data.Model;

namespace VL.Business.Services.Implementation
{
    public class CompanyService : Interface.ICompanyService
    {
        private readonly IUnitOfWork _unitOfWork;

        public CompanyService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public int CreateCompany(CompanyDTO companyDTO)
        {
            throw new NotImplementedException();
        }

        public bool DeleteCompany(int companyID)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CompanyDTO> GetAllCompanies()
        {
            var companies = _unitOfWork.CompanyRepository.GetAll();
            if (companies.Any()) return companies.ToDTOs();
            return null;
        }

        public CompanyDTO GetCompanyByID(int companyID)
        {
            var company = _unitOfWork.CompanyRepository.GetByID(campusID);
            if (company != null) return company.ToDTO();
            return null;
        }

        public bool UpdateCompany(int companyID, CompanyDTO companyDTO)
        {
            throw new NotImplementedException();
        }
    }
}
