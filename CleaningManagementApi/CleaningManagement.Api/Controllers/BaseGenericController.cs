using AutoMapper;
using CleaningManagement.BLL.Services.Interface;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CleaningManagement.Api.Controllers
{
    public class BaseGenericController<TViewModel, TModel, TUpdateViewModel> : ControllerBase
        where TViewModel : class
        where TModel : class
        where TUpdateViewModel : class
    {
        protected readonly IGenericService<TModel> _service;
        protected readonly IMapper _mapper;

        public BaseGenericController(IGenericService<TModel> repository, IMapper mapper)
        {
            _service = repository;
            _mapper = mapper;
        }

        [HttpGet]
        [HttpHead]
        [Route("GetAll")]
        public async Task<IReadOnlyList<TViewModel>> GetAll()
        {
            return _mapper.Map<IReadOnlyList<TViewModel>>(await _service.GetAll());
        }

        [HttpGet("{id}")]
        public async Task<TViewModel> GetById(Guid id)
        {
            return _mapper.Map<TViewModel>(await _service.GetById(id));
        }

        [HttpPost]
        [Route("Add")]
        public async Task<TViewModel> Add(TUpdateViewModel model)
        {
            return _mapper.Map<TViewModel>(await _service.Add(_mapper.Map<TModel>(model)));
        }

        [HttpDelete("{id}")]
        public async Task Delete(Guid id)
        {
            await _service.Delete(id);
        }

        [HttpPut]
        [Route("Update")]
        public async Task<TViewModel> Update(TViewModel model)
        {
            return _mapper.Map<TViewModel>(await _service.Update(_mapper.Map<TModel>(model)));
        }
    }
}
