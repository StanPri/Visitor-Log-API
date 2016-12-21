using System;
using System.Collections.Generic;
using System.Linq;
using VL.Business.Services.Implementation;
using VL.Business.Services.Interface;
using VL.Data.Model;
using VL.Data.Model.GenericRepository;
using VL.Tests.Helpers;
using VL.Business.Services.Mapper;
using VL.Business.Entities;

using NSubstitute;
using VL.Business.Services.Tests.Fakes.VL.Data.Model;
using Xunit;

namespace VL.Business.Services.Tests.Implementation
{
    public class CompanyServiceTests
    {
        #region Variables
        private ICompanyService _companyService;
        private IUnitOfWork _unitOfWork;
        private CompanyRepositoryFake _companyRepository;
        private CompanyRepositoryFake _companyTypeRepository;
        private VisitorLogContext _visitorLogContext;

        #endregion

        #region Constructor - Setup
        public CompanyServiceTests()
        {
            _visitorLogContext = Substitute.For<VisitorLogContext>();
            _companyRepository = new CompanyRepositoryFake(_visitorLogContext);
            _unitOfWork = Substitute.For<IUnitOfWork>();
            _unitOfWork.CompanyRepository.Returns(_companyRepository);
            _companyService = new CompanyService(_unitOfWork);
        }
        #endregion

        #region Company Tests
        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(4)]
        [InlineData(5)]
        [InlineData(6)]
        public void WhenGettingComanyByID_AssertReturnedCompany(int id)
        {
            var company = _companyService.GetCompanyByID(id);
            Asset.Equals(id, company.ID);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        [InlineData(int.MinValue)]
        [InlineData(int.MaxValue)]
        public void WhenGettingCompanyWithInvalidID_AssertNullReturn(int id)
        {
            var company = _companyService.GetCompanyByID(id);
            Assert.Null(company);
        }

        [Fact]
        public void WhenGettingAllCompanies_AssertReturnedCollection()
        {
            var companies = _companyService.GetAllCompanies();
            Assert.Equal(DataInitializer.GetAllCompanies().Count, companies.Count());
        }

        [Fact]
        public void WhenAllCompaniesCollectionEmpty_AssertReturnedCollectionEmpty()
        {
            //Before testing this, we need to empty what's in the repository
            _companyRepository.GetAll().ToList().ForEach(x => _companyRepository.Delete(x));
            var companies = _companyService.GetAllCompanies();
            Assert.Equal(0, companies.Count());
        }

        #endregion

    }
}
