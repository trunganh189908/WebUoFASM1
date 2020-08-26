﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebUoFASM1.Models
{
    public class Trainer
    {
        public int Id { get; set; }

        [Required]
        [DisplayName("Trainer Name")]
        public string Name { get; set; }

        [Required]
        [DisplayName("Trainer Mail")]
        public string Email { get; set; }

        [Required]
        [DisplayName("Traner Type")]
        public string Type { get; set; }

        [Required]
        [DisplayName("Traniee Phone")]
        public string Phone { get; set; }

        public int UserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
    }
}