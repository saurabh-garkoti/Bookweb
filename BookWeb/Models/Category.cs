﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BookWeb.Models
{
    public class Category
    {
        [Key] 
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        [DisplayName("Display Order")]
        [Range(1,100,ErrorMessage ="Display order must be between 1 to 100 only!")]
        public int DisplayOrder { get; set; }
        //public int MyProperty {  get; set; }
        public DateTime CreateDateTime { get; set; } = DateTime.Now;
    }
}
