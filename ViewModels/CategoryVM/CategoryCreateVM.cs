﻿using System.ComponentModel.DataAnnotations;

namespace WebApplication1.ViewModels.CategoryVM
{
    public class CategoryCreateVM
    {
        [MaxLength(16)]
        public string Name { get; set; }
    }
}
