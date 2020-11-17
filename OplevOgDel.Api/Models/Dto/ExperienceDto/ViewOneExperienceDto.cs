using OplevOgDel.Api.Data.Models;
using System;

namespace OplevOgDel.Api.Models.Dto.ExperienceDto
{
    public class ViewOneExperienceDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public Guid CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
