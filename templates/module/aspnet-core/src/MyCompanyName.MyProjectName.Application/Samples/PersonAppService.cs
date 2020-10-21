using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Linq;

namespace MyCompanyName.MyProjectName.Samples
{
    public class PersonAppService :
       CrudAppService<Person, PersonDto, Guid, PagedAndSortedResultRequestDto,
                           CreateUpdatePersonDto, CreateUpdatePersonDto>,
       IPersonAppService
    {
        public PersonAppService(IRepository<Person, Guid> repository) : base(repository)
        {
        }
    }
}