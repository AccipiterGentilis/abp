using System;
using Volo.Abp.Domain.Entities;

namespace MyCompanyName.MyProjectName
{
    public class Person : Entity<Guid>
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
