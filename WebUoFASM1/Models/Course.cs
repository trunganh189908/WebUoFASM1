﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebUoFASM1.Models
{
    public class Course
    {
        public int Id { get; set; }

        [Required]
        [DisplayName("Category Name")]
        public int CategoryId { get; set; }

        public Category Category { get; set; }

        [Required]
        [DisplayName("Course Name")]
        public string Name { get; set; }

        [Required]
        [DisplayName("Course Description")]
        public string Description { get; set; }
    }
}