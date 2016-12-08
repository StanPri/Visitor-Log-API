using Microsoft.Practices.Unity;
using System.Web.Http;
using Unity.WebApi;
using ITSD.BPAS.Resolver;

namespace VL.Web.Api
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
            //Register Unity Container
            var unityContainer = new UnityContainer();
            RegisterTypes(unityContainer);
            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(unityContainer);
        }

        public static void RegisterTypes(IUnityContainer container)
        {
            //Component initialization via Managed Extensibility Framework (MEF)
            ComponentLoader.LoadContainer(container, ".\\bin", "VL.Web.Api.dll");
            ComponentLoader.LoadContainer(container, ".\\bin", "VL.Business.Services.dll");
            ComponentLoader.LoadContainer(container, ".\\bin", "VL.Data.Model.dll");
        }

    }
}