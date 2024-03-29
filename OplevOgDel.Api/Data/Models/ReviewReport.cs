﻿using OplevOgDel.Api.Data.Base;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OplevOgDel.Api.Data.Models
{
    [Table("ReviewReports")]
    public class ReviewReport : BaseModel
    {
        [Required( ErrorMessage = "A report description is required")]
        public string Description { get; set; }
        public Guid ProfileId { get; set; }
        public Profile Creator { get; set; }
        public Guid ReviewId { get; set; }
        public Review Review { get; set; }
    }
}
