using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Volo.Abp;
using Volo.Abp.Application.Dtos;

namespace MyCompanyName.MyProjectName.Samples
{
    [RemoteService]
    [Route("api/MyProjectName/person")]
    public class PersonController : MyProjectNameController, IPersonAppService
    {
        private readonly IPersonAppService _personAppService;

        public PersonController(IPersonAppService personAppService)
        {
            _personAppService = personAppService;
        }

        [HttpPost]
        public Task<PersonDto> CreateAsync(CreateUpdatePersonDto input)
        {
            return _personAppService.CreateAsync(input);
        }

        [HttpDelete("id")]
        public Task DeleteAsync(Guid id)
        {
            return _personAppService.DeleteAsync(id);
        }

        [HttpGet("id")]
        public Task<PersonDto> GetAsync(Guid id)
        {
            return _personAppService.GetAsync(id);
        }

        [HttpGet]
        public Task<PagedResultDto<PersonDto>> GetListAsync(PagedAndSortedResultRequestDto input)
        {
            return _personAppService.GetListAsync(input);
        }

        [HttpPatch("id")]
        public Task<PersonDto> UpdateAsync(Guid id, CreateUpdatePersonDto input)
        {
            return _personAppService.UpdateAsync(id, input);
        }
    }
}
