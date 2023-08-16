using LoanScheduler.Services;
using LoanScheduler.Services.Interfaces;
using System.Web.Http;
using Unity;
using Unity.WebApi;

namespace LoanScheduler
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            container.RegisterType<ILoanService, LoanService>();

            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}