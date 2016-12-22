using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VL.Business.Services.Interface;
using Xunit;
using NSubstitute;
using VL.Web.Api.Controllers;
using System.Threading;
using VL.Business.Entities;
using System.Web.Http.Results;
using System.Net;
using System.Web.Http;
using System.Web.Http.Controllers;
using VL.Tests.Helpers;

namespace VL.Web.Api.Tests.Controllers
{
    /// <summary>
    /// Implements unit tests for <see cref="VL.Web.Api.Controllers.CampusCntroller"/>
    /// </summary>
    public class CampusControllerTest
    {
        private ICampusService _campusServiceMock;
        private CampusController _campusController;

        public CampusControllerTest()
        {
            _campusServiceMock = Substitute.For<ICampusService>();
            _campusController = new CampusController(_campusServiceMock);
        }

        [Fact]
        public void WhenGettingCampusById_AssertCampusReturned()
        {
            _campusServiceMock.GetCampusByID(Arg.Any<int>()).Returns(new CampusDTO { });

            var campusActionResult = _campusController.CampusByID(5) as OkNegotiatedContentResult<CampusDTO>;
            var campus = campusActionResult.Content;
            Assert.NotNull(campus);
        }

        [Fact]
        public void WhenGettingCampusByIdInvalid_AssertNotFound()
        {
            var notFoundResult = _campusController.CampusByID(5) as NotFoundResult;
            Assert.NotNull(notFoundResult);
        }

        [Fact]
        public void WhenGettingAllCampuses_AssertReturnedValues()
        {
            var allCampuses = new[]
            {
                new CampusDTO {ID = 1, Name = "Campus 1" },
                new CampusDTO {ID = 2, Name = "Campus 2" },
                new CampusDTO {ID = 3, Name = "Campus 3" },
            };
            _campusServiceMock.GetAllCampuses().Returns(allCampuses);

            var allCampusesResult = _campusController.AllCampuses() as OkNegotiatedContentResult<IEnumerable<CampusDTO>>;
            Assert.True(allCampusesResult.Content.SequenceEqual(allCampuses));
        }

        [Fact]
        public void WhenAllCampusesEmpty_AssertReturnedValues()
        {
            _campusServiceMock.GetAllCampuses().Returns(new CampusDTO[0]);

            var allCampusesResult = _campusController.AllCampuses() as OkNegotiatedContentResult<IEnumerable<CampusDTO>>;
            Assert.False(allCampusesResult.Content.Any());
        }

        [Fact]
        public void WhenAllCampusesNull_AssertReturnedValues()
        {
            _campusServiceMock.GetAllCampuses().Returns(null as IEnumerable<CampusDTO>);

            var allCampusesResult = _campusController.AllCampuses() as NotFoundResult;
            Assert.NotNull(allCampusesResult);
        }



        [Theory]
        [InlineData("CampusByID", typeof(HttpGetAttribute))]
        [InlineData("AllCampuses", typeof(HttpGetAttribute))]
        [InlineData("CreateCampus", typeof(HttpPostAttribute))]
        public void AssertMethodsHaveHttpActionRoutes(string methodName, Type httpActionType)
        {
            var method = _campusController.GetType().GetMethod(methodName);
            var routingAction = method.GetCustomAttributes(httpActionType, true).Single();
            Assert.NotNull(routingAction);
        }
    }
}
