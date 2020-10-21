using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace MyCompanyName.MyProjectName.Samples
{
    public interface IPersonAppService :
   ICrudAppService< //Defines CRUD methods
       PersonDto, //Used to show people
       Guid, //Primary key of the person entity
       PagedAndSortedResultRequestDto, //Used for paging/sorting on getting a list of books
       CreateUpdatePersonDto, //Used to create a new book
       CreateUpdatePersonDto> //Used to update a book
    {
    }
}
