﻿using System;
using System.Collections.Generic;

namespace OplevOgDel.Web.Models.Dto
{
    public class ExperienceDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public CategoryDto Category { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public IEnumerable<PictureDto> Pictures { get; set; }
    }
}
