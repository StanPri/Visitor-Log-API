using System.ComponentModel.Composition;
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
            registerComponent.RegisterType<IVisitorLogService, VisitorLogService>();
        }
    }
}
