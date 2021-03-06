﻿using System.ComponentModel.Composition;
using VL.Business.Services.Implementation;
using VL.Business.Services.Interface;
using ITSD.BPAS.Resolver;

namespace VL.Business.Services
{
    [Export(typeof(IComponent))]
    public class DependencyResolver : IComponent
    {
        public void SetUp(IRegisterComponent registerComponent)
        {
            registerComponent.RegisterType<IAssetService, AssetService>();
            registerComponent.RegisterType<IBadgeService, BadgeService>();
            registerComponent.RegisterType<ICampusService, CampusService>();
            registerComponent.RegisterType<ICompanyService, CompanyService>();
            registerComponent.RegisterType<IContactService, ContactService>();
            registerComponent.RegisterType<ILocationService, LocationService>();
            registerComponent.RegisterType<ILogService, LogService>();
            registerComponent.RegisterType<IStationService, StationService>();
            registerComponent.RegisterType<IVisitorService, VisitorService>();
            registerComponent.RegisterType<IVisitService, VisitService>();
        }
    }
}
