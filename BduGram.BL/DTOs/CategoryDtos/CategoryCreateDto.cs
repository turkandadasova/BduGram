﻿using BduGram.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BduGram.BL.DTOs.CategoryDtos
{
    public class CategoryCreateDto
    {
        public string Name { get; set; }
        public string Icon { get; set; }
        public static implicit operator Category(CategoryCreateDto dto)
        {
            Category category = new Category
            {
                Icon = dto.Icon,
                Name = dto.Name
            };
            return category;
        }
    }
}
