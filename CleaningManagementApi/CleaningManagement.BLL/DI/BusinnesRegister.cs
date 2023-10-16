using CleaningManagement.BLL.Services;
using CleaningManagement.BLL.Services.Interface;
using CleaningManagement.DAL.DI;
using CleaningManagement.DAL.Entities;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NiceFactory.BLL.Models;

namespace CleaningManagement.BLL.DI
{
    public static class BusinnesRegister
    {
        public static void AddBusinessLogicDependency(this IServiceCollection services, IConfiguration config)
        {
            services.AddScoped(typeof(IGenericService<>), typeof(GenericService<,>));
            services.AddScoped(typeof(IGenericService<CleaningPlan>), typeof(GenericService<CleaningPlan, CleaningPlanEntity>));

            services.AddDataAccess(config);

        }
    }

}
