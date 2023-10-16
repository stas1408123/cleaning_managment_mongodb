using AutoMapper;
using CleaningManagement.DAL.Entities;
using NiceFactory.BLL.Models;

namespace CleaningManagement.BLL.Mappers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CleaningPlanEntity, CleaningPlan>().ReverseMap();
        }
    }
}
