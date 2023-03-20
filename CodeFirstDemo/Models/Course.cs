﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstDemo.Models
{
    public class Course
    {
        [Key]
        public int Id { get; set; }
        
        [Required]        
        public string Name { get; set; }

        public string Description { get; set; }
    }
}
