﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPAUESAN.Shopping.DOMAIN.Core.DTO
{
    public class CategoryDTO
    {
        public int Id { get; set; }
        public string? Description { get; set; }
        public bool? IsActive { get; set; }
    }

    public class CategoryDescriptionDTO
    {
        public int Id { get; set; }
        public string? Description { get; set; }
    }

    public class CategoryInsertDTO
    {
        public string? Description { get; set; }
        public bool? IsActive { get; set; }
    }

    public class CategoryOnlyDescriptionDTO
    {
        public string? Description { get; set; }
    }
}
