﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookStoreAppMVC.Models
{
    public class Category
    {
        [Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        [DisplayName("Category Name")]
        public string? Name { get; set; }
        [DisplayName("Display Order")]
        [Range(1,100)]
        public int DisplayOrder { get; set; }
    }
}
