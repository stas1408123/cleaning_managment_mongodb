using CleaningManagement.DAL;
using CleaningManagement.DAL.Entities;
using CleaningManagement.DAL.Repositorise;
using NiceFactory.DAL.Repositorise.Interface;

namespace NiceFactory.DAL.Repositorise
{
    internal class CleaningPlanRepository : GenericRepository<CleaningPlanEntity>, ICleaningPlanRepository
    {
        public CleaningPlanRepository(CleaningManagementDbContext context) : base(context)
        {
        }
    }
}
