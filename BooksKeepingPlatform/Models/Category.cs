﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace BooksKeepingPlatform1.Models
{
    public class Category
    {

        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        [DisplayName("Category Name")]
        public string Name { get; set; }
        [DisplayName("Display Order")]
        [Range(1, 100, ErrorMessage = "Display Order must be between 1-200")]
        public int DisplayOrder { get; set; }
    
    }
}




