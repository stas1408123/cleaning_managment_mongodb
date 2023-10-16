using AutoMapper;
using CleaningManagement.Api.ViewModels.CleaningPlan;
using NiceFactory.BLL.Models;

namespace CleaningManagement.Api.Mappers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CleaningPlan, CleaningPlanViewModel>().ReverseMap();
            CreateMap<CleaningPlan, AddCleaningPlanViewModel>().ReverseMap();
        }
    }
}
