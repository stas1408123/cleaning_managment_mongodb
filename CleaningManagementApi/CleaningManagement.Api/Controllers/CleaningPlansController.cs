using AutoMapper;
using CleaningManagement.Api.ViewModels.CleaningPlan;
using CleaningManagement.BLL.Services.Interface;
using Microsoft.AspNetCore.Mvc;
using NiceFactory.BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace CleaningManagement.Api.Controllers
{
    [ApiController]
    [Route("api/cleaningplans")]
    public class CleaningPlansController : BaseGenericController<CleaningPlanViewModel, CleaningPlan, AddCleaningPlanViewModel>
    {
        public CleaningPlansController(IGenericService<CleaningPlan> repository, IMapper mapper) : base(repository, mapper)
        {

        }

        [HttpGet]
        [Route("GetByCustomerId")]
        public async Task<IReadOnlyList<CleaningPlanViewModel>> GetByCustomerId(int customerId)
        {
            Expression<Func<CleaningPlan, bool>> predicate = p => p.CustomerId == customerId;

            return _mapper.Map<IReadOnlyList<CleaningPlanViewModel>>(await _service.Get(predicate));
        }
    }
}