using System;
using System.ComponentModel.DataAnnotations;
using Volo.Abp.Application.Dtos;

namespace MyCompanyName.MyProjectName.Samples
{
    public class PersonDto : EntityDto<Guid>
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    public class CreateUpdatePersonDto
    {
        public Guid Id { get; set; }

        [Required]
        [StringLength(128)]
        public string Name { get; set; }

        [Required]
        public int Age { get; set; }
    }
}